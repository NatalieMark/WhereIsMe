using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}

    public void Left(int speed)
    {
		if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
	}

    public void Right(int speed)
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

	
	// Update is called once per frame
	void Update () {
            
            
	}
}
