using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Move : MonoBehaviour {

    public Controls controls;
    public float StartPosX;
    public float StartPosY;
    public int Speed;

	// Use this for initialization
	void Start () {
        this.transform.position = new Vector2(StartPosX, StartPosY);
	}

    // Update is called once per frame
    void Update()
    {
        Left(Speed);
        Right(Speed);
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
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector2.right * speed * Time.deltaTime);
		}
	}

}
