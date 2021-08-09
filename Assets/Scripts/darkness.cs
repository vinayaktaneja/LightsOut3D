using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darkness : MonoBehaviour
{
    public Light lt;
    public float startAngle = 140f;
    private Vector3 oldPos;
    bool timerStarted;
    float timer = 0.0f;
    



    // Start is called before the first frame update
    void Start()
    {

        oldPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (oldPos == transform.position)
        {
            timerStarted = true;
            //timer += Time.deltaTime;
            // Debug.Log("Stopped");
        }

        if (timerStarted == true)
        {
          timer += Time.deltaTime;
            //Debug.Log("true");
        }



        if (timer >= 10f)
        {
            lt.spotAngle = 50f;
        }
        else
        {
            lt.spotAngle = 140f;
        }
    

        
        if (oldPos != transform.position)
        {
            //lt.spotAngle = 140f;
            timerStarted = false;
             timer = 0f;
            // Debug.Log("Moving");
            
        }
        else
        {
            oldPos = transform.position;
            timerStarted = true;
            
       }
      
    }
}

            //if (!timerStarted)
                //{
                   
                 //   timer = 0.0f;
                 //   Debug.Log("hello");
                    
               // }

               // else
               // {
                //    timer += Time.deltaTime;
               // }

        //}

       // if (timer >= 10.0f)
       // {
           // timerStarted = false;
           // timer = 0.0f;
          //  lt.spotAngle = 50f;
        //}

       // else
       // {
       //     timerStarted = false;
       // }

        

 