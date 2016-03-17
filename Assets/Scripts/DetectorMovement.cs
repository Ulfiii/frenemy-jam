using UnityEngine;
using System.Collections;

public class DetectorMovement : MonoBehaviour {

	public float minDistance;
	public float maxDistance;
	public float minSpeed;
	public float maxSpeed;

	private float speed;
	private float distanceToMove;
	private float distanceMoved;
	private Vector3 direction;

	private const float pauseDuration = 0.2f;

	void PickNewDirection()
	{
		distanceToMove = Random.Range (minDistance, maxDistance);
		distanceMoved = 0f;

		Vector3 newDirection = direction;
		while (newDirection == direction) {

			int d = Random.Range (0, 4);
			if (d == 0) {
				newDirection = new Vector3 (1, 0);
			} else if (d == 1) {
				newDirection = new Vector3 (-1, 0);
			} else if (d == 2) {
				newDirection = new Vector3 (0, 1);
			} else if (d == 3) {
				newDirection = new Vector3 (0, -1);
			}
		}
		direction = newDirection;

		speed = Random.Range (minSpeed, maxSpeed);
	}
		
	void Start () {

		PickNewDirection ();

	}

	IEnumerator Wait() {
		yield return new WaitForSeconds (pauseDuration);
	}

	void Update () {

		if (distanceMoved < distanceToMove) {

			transform.Translate (direction * speed);
			distanceMoved += speed;

		} else {
			
			StartCoroutine(Wait ());
			PickNewDirection ();
		}

		// pick a random vector to move
		// move there with some random selected but contanst speed
		// pause when you arrive
		// pick a new direction

	
	}
}
