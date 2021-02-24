using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Challenges : MonoBehaviour
{
    public float startTime;
    public float timePassed;
    public Text challengeUpdate;
    public AudioSource speaker;
    public AudioSource babyAudio;
    public AudioClip babyCrying;
    public AudioClip footSteps;
    public AudioClip thunder;
    public GameObject button;
    public Text buttonText;
    public GameObject babyButton;
    public GameObject playgroundButton;
    public GameObject refrigiratorButton;
    public GameObject knifeButton;
    public GameObject notBabyButton;
    public Text endText;

    public GameObject officeEnd;
    public GameObject thatsAll;

    public string buttonCommand;
    public string notIdentified;
    public bool timerView;
    public ScreenChange changer;

    public GameObject environmentImage;
    public Texture kitchen;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed = Time.time - startTime;

        if (0.0f< timePassed && timePassed <2.0f)
        {
            babyButton.SetActive(false);
            playgroundButton.SetActive(false);
            notBabyButton.SetActive(false);
            refrigiratorButton.SetActive(false);
            knifeButton.SetActive(false);
            challengeUpdate.text = "Oh no! The electricity is out. Don't be scared.";
            buttonCommand = "babyChallenge";
        }
        
    }

    public void Button()
    {
        if (buttonCommand == "babyChallenge")
        {
            babyAudio.Play();
            officeEnd.SetActive(false);
            thatsAll.SetActive(false);
            babyButton.SetActive(false);
            notBabyButton.SetActive(false);
            playgroundButton.SetActive(false);
            refrigiratorButton.SetActive(false);
            challengeUpdate.text = "Your baby son Pablo woke up with the thunder and now he is scared. He needs mommy.";
            buttonCommand = "Pablo's Room";
            buttonText.text = "Go to Pablo's Room";
        }

        else if (buttonCommand == "Pablo's Room")
        {
            changer.toGame();
            buttonCommand = "info";
        }

        if (buttonCommand == "info")
        {
            challengeUpdate.text = "You were able to see the room for a second with the lightning. Pablo must be in his bed. Click on the bed to pick him up.";
            notIdentified = "bed";
            buttonCommand = "hideText";
            buttonText.text = "Next";
        }

        else if (buttonCommand == "hideText")
        {
            challengeUpdate.text = "";
            button.SetActive(false);
            playgroundButton.SetActive(false);
            refrigiratorButton.SetActive(false);
            babyButton.SetActive(true);
            notBabyButton.SetActive(true);
            buttonCommand = "babyChallenge";
        }
        else if (buttonCommand == "toys")
        {
            challengeUpdate.text = "Maybe playing with his toys will make him happier. Put him in his playground by clicking on it";
            buttonCommand = "playgroundChallenge";
            notIdentified = "playground";
        }
        else if (buttonCommand == "playgroundChallenge")
        {
            challengeUpdate.text = "";
            button.SetActive(false);
            babyButton.SetActive(false);
            playgroundButton.SetActive(true);
            refrigiratorButton.SetActive(false);
            notBabyButton.SetActive(true);
            buttonCommand = "playgroundChallenge";
        }
        else if (buttonCommand == "kitchen")
        {
            environmentImage.GetComponent<RawImage>().texture = kitchen;
            //change the raw image to kitchen and run the same thing
            changer.toGame();
            buttonCommand = "info";
        }

        if (buttonCommand == "info")
        {
            challengeUpdate.text = "You were able to see the kitchen for a second with the lightning. Pablo's favorite food is apples and there were some in the refrigirator. Click on the refrigirator to grab one.";
            buttonCommand = "refrigiratorChallenge";
            buttonText.text = "Next";
            notIdentified = "refrigirator";
        }
        else if (buttonCommand == "refrigiratorChallenge")
        {
            challengeUpdate.text = "";
            button.SetActive(false);
            babyButton.SetActive(false);
            playgroundButton.SetActive(false);
            refrigiratorButton.SetActive(true);
            notBabyButton.SetActive(true);
            buttonCommand = "refrigiratorChallenge";
        }
        else if (buttonCommand == "someoneHere")
        {
            challengeUpdate.text = "Wait, do you here the footsteps?";
            speaker.PlayOneShot(footSteps);
            buttonCommand = "ohNo";
        }
        else if (buttonCommand == "ohNo")
        {
            challengeUpdate.text = "Oh no, someone is here!";
            buttonCommand = "grabKnife";
            notIdentified = "knife";
        }
        else if (buttonCommand == "grabKnife")
        {
            challengeUpdate.text = "Grab a knife to be safe, the knifes were here in the kitchen.";
            buttonCommand = "knifeChallenge";
        }
        else if (buttonCommand == "knifeChallenge")
        {
            challengeUpdate.text = "";
            button.SetActive(false);
            babyButton.SetActive(false);
            playgroundButton.SetActive(false);
            refrigiratorButton.SetActive(false);
            knifeButton.SetActive(true);
            notBabyButton.SetActive(true);
            buttonCommand = "knifeChallenge";
        }
        else if (buttonCommand == "checkComp")
        {
            challengeUpdate.text = "What if they stole your research, go and check your computer.";
            buttonCommand = "office";
            buttonText.text = "Go to Office";
        }
        else if (buttonCommand == "office")
        {
            officeEnd.SetActive(true);
        }

    }

    public void FindBaby()
    {
        challengeUpdate.text = "You picked Pablo up of the bed, but he is still crying. Calm down baby";
        babyButton.SetActive(false);
        notBabyButton.SetActive(false);
        playgroundButton.SetActive(false);
        refrigiratorButton.SetActive(false);
        button.SetActive(true);
        buttonText.text = "Next";
        buttonCommand = "toys";
    }

    public void FindPlayground()
    {
        challengeUpdate.text = "You put Pablo in the playground, but he is still crying. Maybe he is hungry. Go to the kitchen to get some food.";
        babyButton.SetActive(false);
        notBabyButton.SetActive(false);
        playgroundButton.SetActive(false);
        refrigiratorButton.SetActive(false);
        button.SetActive(true);
        buttonText.text = "Go to Kitchen";
        buttonCommand = "kitchen";
    }

    public void FindRefrigirator()
    {
        challengeUpdate.text = "Yes there is the refrigirator, and you grabbed an apple.";
        babyButton.SetActive(false);
        notBabyButton.SetActive(false);
        playgroundButton.SetActive(false);
        refrigiratorButton.SetActive(false);
        button.SetActive(true);
        buttonText.text = "Next";
        buttonCommand = "someoneHere";
    }

    public void FindKnife()
    {
        challengeUpdate.text = "Ok, now you at least have a knife to protect yourself.";
        babyButton.SetActive(false);
        notBabyButton.SetActive(false);
        playgroundButton.SetActive(false);
        refrigiratorButton.SetActive(false);
        knifeButton.SetActive(false);
        button.SetActive(true);
        buttonText.text = "Next";
        buttonCommand = "checkComp";
    }

    public void end()
    {
        thatsAll.SetActive(true);
        officeEnd.SetActive(false);
    }
    public void NotFindBaby()
    {
        if (notIdentified == "bed")
        {
            challengeUpdate.text = "Nope, Pablo isn't there. He is in his bed. Try again.";
            button.SetActive(true);
            babyButton.SetActive(false);
            notBabyButton.SetActive(false);
            playgroundButton.SetActive(false);
            refrigiratorButton.SetActive(false);
            buttonText.text = "Try Again";
            buttonCommand = "hideText";
        }
        else if (notIdentified == "playground")
        {
            challengeUpdate.text = "Nope, the playground isn't there. Try again.";
            button.SetActive(true);
            babyButton.SetActive(false);
            notBabyButton.SetActive(false);
            playgroundButton.SetActive(false);
            refrigiratorButton.SetActive(false);
            buttonText.text = "Try Again";
            buttonCommand = "playgroundChallenge";
        }
        else if (notIdentified == "refrigirator")
        {
            challengeUpdate.text = "Nope, the refrigirator isn't there. Try again.";
            button.SetActive(true);
            babyButton.SetActive(false);
            notBabyButton.SetActive(false);
            playgroundButton.SetActive(false);
            refrigiratorButton.SetActive(false);
            buttonText.text = "Try Again";
            buttonCommand = "refrigiratorChallenge";
        }
        else if (notIdentified == "knife")
        {
            challengeUpdate.text = "Nope, the knives are not there. Try again.";
            button.SetActive(true);
            babyButton.SetActive(false);
            notBabyButton.SetActive(false);
            playgroundButton.SetActive(false);
            refrigiratorButton.SetActive(false);
            buttonText.text = "Try Again";
            buttonCommand = "refrigiratorChallenge";
        }
    }
}
