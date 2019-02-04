using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flagcounter : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Flags;
    public Text FlagCounter;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Flag")
        {
            Flags.GetComponent<Text>().text =
            "Flag: " + Flags;
        }
    }
    

}





