using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderEffects : MonoBehaviour
{
    public AudioClip thunder;
    public AudioSource speaker;
    public GameObject black;
    public ScreenChange changer;

    // Update is called once per frame
    void Update()
    {
        if (Timer.timerDone || IntroTextChange.introDone)
        {
            thunderEffects();
            Timer.timerDone = false;
            IntroTextChange.introDone = false;
        }
    }

    void thunderEffects()
    {
        speaker.PlayOneShot(thunder);
        changer.toBlack();
    }
}
