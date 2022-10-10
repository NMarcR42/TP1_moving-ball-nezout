using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 30;
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        //Vector2 movement = new Vector2(moveX, moveY);
        Vector3 newPosition = new Vector3(0, 10, 0);

        //transform.Rotate(0, moveX * Time.deltaTime * speed,0);
        // transform.Translate(0f,0f, speed * moveY * Time.deltaTime);

        transform.Rotate(Vector3.back * moveX * Time.deltaTime * speed);
        transform.Rotate(Vector3.left * moveY * Time.deltaTime * speed);
        //transform.position += Vector3.back * Time.deltaTime * speed;


    }
}
