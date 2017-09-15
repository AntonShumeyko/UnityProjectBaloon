using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour {

    Text text;

    void Awake () {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        text.text = Globals.HP.ToString();
        if (Globals.HP == 0)
            Application.LoadLevel(2);
    }
}
