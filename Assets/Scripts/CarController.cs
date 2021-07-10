using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
   
   public static CarController instance;
   
    public WheelCollider FrontR_C,FrontL_C,BackR_C,BackL_C;


    public Transform FrontR_T,FrontL_T,BackR_T,BackL_T,steeringObject; 

    public int bhp;
    public float[] gearRatio,gearUpSpeed, gearDownSpeed;
    public float  brakeTorque, maxSpeedFwd, maxSpeedRev,frictionalForce,engineRPM , maxSteerAngle,maxSteeringUI, maxEngineRPM;
    
    float  moveTorque , currentSpeed , soundRPM , currentSpeedaudio ;
    int Gear;
    Rigidbody thisRB;   

    public AnimationCurve engineBhp;

     void Awake() 
    {
        instance = this;        
    }   

    void Start()
    {   
        thisRB = GetComponent<Rigidbody>();   
        Gear = 1;
        checkValue(); 
    }   

    void Update()
    {
        set_Vehicle_Details();
        get_Vehicle_Details();
    }




    public void getAccleration(float vertical_UserInput)    
    {   
        acclerate(vertical_UserInput); 
        if(vertical_UserInput == 0) Friction(); 
    }



     void acclerate(float vertical_UserInput)
    {
        if (currentSpeed < maxSpeedFwd && currentSpeed > maxSpeedRev && currentSpeed <= gearUpSpeed[Gear])
        {
            float final_moveTorque =  moveTorque * vertical_UserInput;
            BackL_C.motorTorque = final_moveTorque * Time.deltaTime;
            BackR_C.motorTorque = final_moveTorque * Time.deltaTime;           
        }       
        else{ BackL_C.motorTorque = 0; BackR_C.motorTorque = 0; currentSpeedaudio += 10;}
    }


    void Friction()
    {
        BackL_C.brakeTorque = frictionalForce * Time.deltaTime;
        BackR_C.brakeTorque = frictionalForce * Time.deltaTime;
        FrontL_C.brakeTorque = frictionalForce * Time.deltaTime;
        FrontR_C.brakeTorque = frictionalForce * Time.deltaTime;
        BackL_C.motorTorque = 0;
        BackR_C.motorTorque = 0;         
    }



    public void getSteering(float m_steer)
    {
        float m_steering = m_steer;
        float m_SteerAngle = maxSteerAngle * m_steering;
        steer(m_SteerAngle);
        steeringDisp(m_steering);
    }



     void steer(float m_SteerAngle)
    {
        FrontL_C.steerAngle = m_SteerAngle; 
        FrontR_C.steerAngle = m_SteerAngle;       
    }

   
   
    public void getBrake(float m_brake) { brake(m_brake); }
    


    void brake(float breakValue)
    {
        BackL_C.brakeTorque = breakValue * brakeTorque;
        BackR_C.brakeTorque = breakValue * brakeTorque;
        FrontL_C.brakeTorque = breakValue * brakeTorque;
        FrontR_C.brakeTorque = breakValue * brakeTorque;        
    }

   
    
    public void getGear(float m_Gear)
    {
        Gear += (int)m_Gear;
        checkValue();
    }
   
   
    void help_set_Wheel()
    {   
        set_Wheel_Transform(BackL_C,BackL_T);
        set_Wheel_Transform(BackR_C,BackR_T);
        set_Wheel_Transform(FrontL_C,FrontL_T);
        set_Wheel_Transform(FrontR_C,FrontR_T);
    }
    


    void set_Wheel_Transform(WheelCollider colliderW, Transform transformW)
    {
        Vector3 _position = transformW.position;
        Quaternion _rotation = transformW.rotation;
        colliderW.GetWorldPose(out _position,out _rotation);

        transformW.position = _position;
        transformW.rotation = _rotation;      
    }
       
   
   
    void steeringDisp(float angleRotation) 
    {
        angleRotation *=  maxSteeringUI;
        steeringObject.localRotation = Quaternion.Euler(0f, 0f, angleRotation);      
    }
    
    
    
    void get_Vehicle_Details()
    {
        currentSpeed = thisRB.velocity.magnitude * 3.6f;
        engineRPM = Mathf.Round((BackL_C.rpm * gearRatio[Gear]));
		soundRPM = Mathf.Round(engineRPM * (1000 / 420));
        moveTorque = engineBhp.Evaluate(engineRPM) * gearRatio[Gear];     
        UImanager.instance.setNeedle(currentSpeed);   
    }
    
    void set_Vehicle_Details()
    {
        downShifter();
        help_set_Wheel();
        audioSpeed();
    }
    

    void checkValue()
    {   
        int previousGear = Gear;
        if(Gear < 0 )
        {
            Gear = 0;
        }

        if(Gear > 6)
        {
            Gear = 6;
        }
        if(previousGear != Gear ){AudioManager.instance.getGearShift();}
        UImanager.instance.showGear(Gear - 1);
    }

    void audioSpeed()
    {
        AudioManager.instance.setEngineRPM(currentSpeed,gearUpSpeed[Gear]) ;          
    }   


  
    void downShifter()
    {
        if( Gear > 1 && (currentSpeed + 5) < gearUpSpeed[Gear - 1]) Gear--;
        checkValue();
    }

}