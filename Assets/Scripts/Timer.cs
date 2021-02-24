using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public  float startTime;
    public  float timePassed;
    public  float timer;
    public Text timerText;
    public bool startProcessed;
    public static bool timerDone;

    public float spentTime =3.0f;

    // Update is called once per frame
    void Update()
    {
        //start
        if (ScreenChange.activateTimer)
        {
            spentTime = 3.0f;
            startTime = Time.time;
            timer = spentTime;
            Debug.Log("Start");
            startProcessed = true;
            timerDone = false;
        }

        //update
        if (startProcessed)
        {
            Debug.Log(timer);
            ScreenChange.activateTimer = false;

            if (timer > 0)
            {
                Debug.Log("In if statement");
                timePassed = Time.time - startTime;
                timer = spentTime - ((int)timePassed%60);
                Debug.Log(timer);
                timerText.text = "Timer: " + timer;
            }
            else if (timer <= 0)
            {
                startProcessed = false;
                Debug.Log("Timer done");
                timerDone = true;
            }
        }

    }
    
}
