using System;
using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerBasicMovement : MonoBehaviour
{
	public string playedId;

	public float speed = 1.0f;


	void Start()
	{
	}


	void Update()
	{
		// keyboard
		var move1 = new Vector3(Input.GetAxis("Horizontal" + playedId), Input.GetAxis("Vertical" + playedId), 0);
		transform.position += move1 * speed * Time.deltaTime;

		// touch joystick
		var move2 = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal" + playedId), CrossPlatformInputManager.GetAxis("Vertical" + playedId), 0);
		transform.position += move2 * speed * Time.deltaTime;
	}
}