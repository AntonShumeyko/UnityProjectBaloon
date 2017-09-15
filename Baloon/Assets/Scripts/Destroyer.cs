using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        Globals.HP = Globals.HP - 1;
        //Debug.Log("Entered");
        //Debug.Log(Globals.HP);
        Destroy(col.gameObject);
    }

}
