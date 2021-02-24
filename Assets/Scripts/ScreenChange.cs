using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScreenChange : MonoBehaviour
{
    public GameObject main;
    public GameObject game;
    public GameObject about;
    public GameObject black;
    public GameObject intro;
    public GameObject officeEnd;
    public GameObject thatsAll;

    public static bool activateTimer= false;

    private void Start()
    {
        Screen.SetResolution(1024,768,false);
        toMain();
    }

    public void toMain()
    {
        main.SetActive(true);
        game.SetActive(false);
        about.SetActive(false);
        black.SetActive(false);
        officeEnd.SetActive(false);
        thatsAll.SetActive(false);
    }

    public void toIntro()
    {
        main.SetActive(false);
        game.SetActive(false);
        intro.SetActive(true);
        about.SetActive(false);
        black.SetActive(false);
    }

    public void toGame()
    {
        main.SetActive(false);
        game.SetActive(true);
        about.SetActive(false);
        black.SetActive(false);
        intro.SetActive(false);
        Debug.Log("Game");
        activateTimer = true;
    }

    public void toAbout()
    {
        main.SetActive(false);
        game.SetActive(false);
        about.SetActive(true);
        intro.SetActive(false);
        black.SetActive(false);
    }

    public void toBlack()
    {
        main.SetActive(false);
        game.SetActive(false);
        about.SetActive(false);
        intro.SetActive(false);
        black.SetActive(true);
    }

}
