using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour {

    public GameObject my_paddle;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left arrow pressed");
            Vector3 coords;
            coords = my_paddle.gameObject.transform.position;
            if (coords.x > -6.0f)
            {
                coords.x -= 0.1f;
            }
            my_paddle.transform.position = coords;
      
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right arrow pressed");
            Vector3 coords;
            Debug.Log("Left arrow pressed");
            coords = my_paddle.gameObject.transform.position;
            if (coords.x < 4.5f)
            {
                coords.x += 0.1f;
            }
            my_paddle.transform.position = coords;
            Debug.Log(coords.x);
        }
	}
}
