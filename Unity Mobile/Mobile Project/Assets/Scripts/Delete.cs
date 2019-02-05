using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private void OnCollisionExit(Collision collision)
    {
        Destroy(gameObject.tag "useless");
    }

}
