using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
	public GameObject player;
	public OpenSesame pikadoor;

	public Getkey gk;
	public float distance;
	public Vector3 playerpos;
	public Vector3 triggerpos;



	// Use this for initialization
	void Start()
	{

	}
	void OnTriggerEnter(Collider other)
	{
		bool playerHasKey = gk.hasGoldKey;
		if (playerHasKey)
		{
			playerpos = player.transform.position;
			triggerpos = gameObject.transform.position;
			distance = Vector3.Distance(triggerpos, playerpos);
			pikadoor.moveUp();
		}
	}
	// Update is called once per frame
	void Update()
	{


	}
}