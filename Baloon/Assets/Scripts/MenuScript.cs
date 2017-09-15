using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

    public void LoadGame()
    {
        Globals.HP = 10;
        Globals.Score = 0;
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}