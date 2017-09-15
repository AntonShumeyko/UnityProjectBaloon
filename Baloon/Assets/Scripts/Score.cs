using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    Text text;

	void Awake () {
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = Globals.Score.ToString();
	}
}
