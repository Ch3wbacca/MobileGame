using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
 
    public int health = 1;
    public Text HealthText;
    public Slider healthBar;
    private void Start()
    {
        HealthText.GetComponent<Text>().text =
            "Health: " + health;
        healthBar.GetComponent<Slider>().value = health;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        //if (health <= 0)
        {
            //reload the level
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        //if (GetComponent<Rigidbody2D>().velocity.x <= 0)
        {

          //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
