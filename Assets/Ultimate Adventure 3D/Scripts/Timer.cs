using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Timer : MonoBehaviour
{
    [SerializeField] public float timer;
    [SerializeField] private Rotator rotator;
    [SerializeField] private Timer tmr;

    void Update()
    {
        timer -= Time.deltaTime;
        
        if (timer < 0)
        {
            timer = 0;
        }
        if (timer == 0)
        {
            rotator.enabled = false;
            tmr.enabled = false;
            timer = 5;
 
        }
        if (tmr.enabled == true)
        {
            rotator.enabled = true;
          
        }
        
    }

}