using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	public GameObject background;
	public float backgroundHeight;
	public float speed;

	private float movedAmount = 0;
	private GameObject topTile;
	private GameObject bottomTile;

	// Use this for initialization
	void Start () {

		bottomTile = background.transform.GetChild(0).gameObject;

		topTile = Instantiate (bottomTile);
		topTile.transform.SetParent (background.transform);
		topTile.transform.rotation = new Quaternion ();
		topTile.transform.position = new Vector3 (bottomTile.transform.position.x, bottomTile.transform.position.y, bottomTile.transform.position.z);
	//	topTile.transform.Translate (new Vector3 (0, 0, backgroundHeight));
		topTile.transform.Translate (new Vector3 (0, backgroundHeight));
	}

	// Update is called once per frame
	void Update () {

		movedAmount += speed;

		if (movedAmount >= backgroundHeight) {

			bottomTile.transform.Translate (new Vector3 (0, backgroundHeight * 2, 0));

			GameObject tmp = topTile;
			topTile = bottomTile;
			bottomTile = tmp;

			movedAmount = 0;
		}

		foreach (Transform child in background.transform) {
			child.Translate (new Vector3 (0, -speed, 0));
		}
	}
}
