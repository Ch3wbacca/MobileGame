using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlagCounter : MonoBehaviour
{
    public int Flag = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Flag")
        {
            Flag++;
            Destroy(collision.gameObject);
        }

    }



}
