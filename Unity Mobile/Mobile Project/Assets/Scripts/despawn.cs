using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    public GameObject useless;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject.GetComponent "trash");
    }
}
