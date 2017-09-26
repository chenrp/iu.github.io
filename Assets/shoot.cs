using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public GameObject bullet;
	public GameObject bulletSpawn;
	public GameObject JackIsBest;

	// Use this for initialization
	void Start () {
	
	}

	float countdown = -1;
	
	// Update is called once per frame
	void Update () {
		countdown = countdown - Time.deltaTime;
		if (countdown < 0)
		{
			countdown = 0.5f;
			GameObject obj = (GameObject)Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
			obj.GetComponent<Rigidbody>().velocity = obj.transform.forward * 10;
			Destroy(obj, 5.0f);
		}
	}
}
