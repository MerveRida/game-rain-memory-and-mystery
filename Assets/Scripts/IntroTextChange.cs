using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroTextChange : MonoBehaviour
{
    public int count = 0;
    public Text introText;
    public static bool introDone = false;
    public float startTime;
    public float timePassed;

    public void introButton () { 
        if (count == 0){
            introText.text = "Especially if you are about to discover something that will change human history.";
        }
        if (count == 1)
        {
            introText.text = "You have been scanning the human genome for years to find a gene that matches with the gene from extastrapos species that makes them not burn.";
        }
        if (count == 2)
        {
            introText.text = "And now you have found it.";
        }
        if (count == 3)
        {
            introText.text = "This shouldn't be used for evil. You should be careful.";
        }
        if (count == 4)
        {
            introText.text = "They are definetely after you.";
        }
        if (count == 5)
        {
            introDone = true;
        }
        if (count == 6)
        {
            //thats all
        }
        count++;
    }

}
