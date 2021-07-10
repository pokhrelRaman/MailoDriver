using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UImanager : MonoBehaviour
{
    public TMP_Text gearUI;
    public static UImanager instance;

    public Transform Needle;
    void Awake() 
    {
        instance = this;    
    }

    public void showGear(float m_gear)
    {
        gearUI.text = "GEAR:" + m_gear.ToString();
    }

    public void setNeedle(float m_Speed)
    {
        Needle.localRotation = Quaternion.Euler(0,0,122f - m_Speed);
    }

}
