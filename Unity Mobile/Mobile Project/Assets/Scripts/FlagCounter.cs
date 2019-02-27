using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlagCounter : MonoBehaviour
{
    public Text Flag;
    public int Flagcounter = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    
        
    
    {
        if (collision.gameObject.tag == "Flag")
        {
            Flagcounter += 1;
            Flag.GetComponent<Text>().text =
                "Flag " + Flagcounter;
            Destroy(collision.gameObject);
        }

    }



}
