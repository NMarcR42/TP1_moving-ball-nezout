using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Kill object
        Destroy(collision.gameObject);
        Debug.Log("Game over");
        
        //Restart
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Kill object
        Destroy(collision.gameObject);
        Debug.Log("Game over");

        //Restart
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
    }
}
