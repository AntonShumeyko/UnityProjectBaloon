using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour {

    public GameObject[] obj;
    float spawnSpeed;

    void Start()
    {
        spawnSpeed = Random.Range(2f, 5f);
        Spawn();
    }

    void Spawn()
    {
        Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
        Invoke("Spawn", spawnSpeed);
    }

}
