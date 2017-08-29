using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public GameObject bullet;
	public GameObject bulletSpawn;

	float countdown = -1;
	
	// Update is called once per frame
	void Update () {
		countdown = countdown - Time.deltaTime;
		if (countdown < 0)
		{
			countdown = 0.5f;
			GameObject obj = (GameObject)Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
			obj.GetComponent<Rigidbody>().velocity = Vector3.back * 20;
			Destroy(obj, 5.0f);
		}
	}
}
