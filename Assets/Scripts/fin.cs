using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class fin : MonoBehaviour
{
   // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy the ball
        Destroy(collision.gameObject);
        Application.Quit();

        //win message
        Debug.Log("GG");

        //Restart
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );

    }
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy the ball
        Destroy(collision.gameObject);
        Application.Quit();

        //win message
        Debug.Log("GG");

        //Restart
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
}
