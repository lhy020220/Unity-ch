using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float SpeedRatio = 0.01f;
    public float stopSpeed = 0.04f;
    public float decreaseRate = 0.97f;

    private float speed = 0;
    private Vector2 startpos;
    private Vector2 endPos;
    AudioSource audio;

    
    void Start()
    {
        Application.targetFrameRate = 60;  
        audio = Getcomponent<AudioSource>();
    }

  
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))  
        {
            startpos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))  
        {
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - startpos.x;
            speed = swipeLength * SpeedRatio / 10000.0f;
            audio.Play();
        }

        
        transform.Translate(speed, 0, 0);
       
        
        speed *= decreaseRate;

        
        if (Mathf.Abs(speed) < stopSpeed)  
            speed = 0f;
        }
    }
}
