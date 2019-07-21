using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour {
    Transform ball_transform;
    float y_speed = -0.1f;
    float x_speed = 0.1f;



    // Use this for initialization
    void Start () {
        ball_transform = this.gameObject.transform;	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 coords;
        coords = ball_transform.position;

        coords.y += y_speed;
        coords.x += x_speed;

        ball_transform.position = coords;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "RightEdge")
        {
            Debug.Log("collision detected right");
            x_speed = x_speed  * -1;
        }

        if (collision.gameObject.name == "TopEdge")
        {
            Debug.Log("collision detected top");
            y_speed = y_speed * -1;
        }

        if (collision.gameObject.name == "BottomEdge")
        {
            Debug.Log("collision detected bottom");
            y_speed = y_speed * -1;

        }

        if (collision.gameObject.name == "LeftEdge")
        {
            Debug.Log("collision detected left");

            x_speed = x_speed * -1;
        }

        if(collision.gameObject.name == "Paddle")
        {
            y_speed = y_speed * -1;
        }

        if(collision.gameObject.tag == "Breakable")
        {
            Destroy(collision.gameObject);
        }
    }

}
