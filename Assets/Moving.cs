using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public static int movespeed = 1;
	public Vector3 userDirection = Vector3.right;

	// Update is called once per frame
	void Update () {
		transform.Translate(userDirection * movespeed * Time.deltaTime);
	}
}
