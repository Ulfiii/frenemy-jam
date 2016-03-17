using UnityEngine;
using System.Collections;

public class ScentReceptor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


  	void OnParticleCollision(GameObject gameObject)
 	{
      	Debug.Log("collision: " + gameObject.name);

		ParticleSystem part = gameObject.GetComponent<ParticleSystem> ();

		ParticleCollisionEvent[] events = new ParticleCollisionEvent[part.GetSafeCollisionEventSize()];
		int eventCount = part.GetCollisionEvents(this.gameObject, events);

		Debug.Log("event count: " + eventCount);
			

 	}
}
