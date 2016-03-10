using System;
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
  public string playedId;

  public float speed = 1.0f;

  // Use this for initialization
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    var move = new Vector3(Input.GetAxis("Horizontal" + playedId), Input.GetAxis("Vertical" + playedId), 0);
    transform.position += move*speed*Time.deltaTime;
  }
}