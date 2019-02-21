using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{

    

    void OnTriggerEnter2D(Collider2D col)
    {
<<<<<<< HEAD
        if (col.gameObject.name == "Player")
=======
        if (collision.gameObject.tag == "Enemy")
>>>>>>> ec2610a56c1f85a9bdaf8989d9355ea86a23d5bb
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
