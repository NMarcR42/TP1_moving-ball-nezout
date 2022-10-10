using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    float a;
    private Vector3 scaleChange, pos;
    float x;
    float y;
    float z;

    // Start is called before the first frame update
    void Start()
    {
        // a = Random.Range(0, 2);
        Debug.Log(a);
        // Spawn the end goal at different entrance

        // if(a==0)
        // {
            //doesn't work well
            // scaleChange = new Vector3(10f, 0.1f, 0.5f);
        //     x = 0.17f;
        //     y = 1.2f;
        //     z = -0.488f;
        //     pos = new Vector3(x, y, z);
        //     transform.position = pos;
        // }

        // if(a==1)
        // {
            // scaleChange = new Vector3(10f, 0.1f, 0.5f);            
            x = 0.17f;
            y = 10.77f;
            z = 15.59f;
            pos = new Vector3(x, y, z);
            transform.position = pos;
        // }

        // if(a==2)
        // {
        //     scaleChange = new Vector3(0.5f, 0.1f, 10f);
        //     x = 15.6f;
        //     y = 10.77f;
        //     z = 0.38f;
        //     pos = new Vector3(x, y, z);
        //     transform.position = pos;
        // }

        // if(a==3)
        // {
        //     scaleChange = new Vector3(0.5f, 0.1f, 10f);
        //     x = -15.64f;
        //     y = 10.77f;
        //     z = 0.38f;
        //     pos = new Vector3(x, y, z);
        //     transform.position = pos;
        // }
    }
}
