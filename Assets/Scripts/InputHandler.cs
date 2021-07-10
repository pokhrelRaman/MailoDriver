using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{   
     public static InputHandler instance;

    PlayerInput input;

    float Steering, Acclerate, Brake ;
    
    void Awake()
    {   
        instance = this;
        
        input = new PlayerInput();

        newInput();
    }


    void newInput()
    {
        input.Car.Steer.performed += steer => { Steering = steer.ReadValue<float>(); };
    
        input.Car.Acclerator.performed += acclerate =>{Acclerate = acclerate.ReadValue<float>(); };
    
        input.Car.Brake.performed += brake => {Brake = brake.ReadValue<float>();};
        
        input.Car.Gear.performed += gear => { CarController.instance.getGear(gear.ReadValue<float>());};
    }


        void Update()
        { 
            CarController.instance.getSteering(Steering);
            CarController.instance.getAccleration(Acclerate);      
            CarController.instance.getBrake(Brake);          
            AudioManager.instance.set_vertical_UserInput(Acclerate);
        }

    /*float Map( float OldValue , float OldMin = -1, float OldMax = 1, float NewMin = 0, float NewMax = 1)
    {
 
    float OldRange = (OldMax - OldMin);
    float NewRange = (NewMax - NewMin);
    float NewValue = (((OldValue - OldMin) * NewRange) / OldRange) + NewMin;
 
    return(NewValue);
    }*/

    void OnEnable()
    {
        input.Car.Enable();
    }
    
    void OnDisable()
    {
        input.Car.Disable();
    }


}

