using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    void OnMouseDown()
    {
        Globals.Score += 100;
        Destroy(this.gameObject);
    }
}