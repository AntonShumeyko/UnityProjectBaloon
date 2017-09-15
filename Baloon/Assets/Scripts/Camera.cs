using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals
{
    public static int Score = 0;
    public static int HP = 10;
}

public class Camera : MonoBehaviour {

    public Transform player;
    public float speed = 0.05f;

	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0, player.transform.position.y - speed , -10);
        if(speed < 0.2f)
            speed += 0.0000001f;
    }
}
