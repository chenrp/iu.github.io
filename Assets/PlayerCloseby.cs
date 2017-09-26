using UnityEngine;
using System.Collections;

public class PlayerCloseby : MonoBehaviour
{
	public Getkey playerGetKey;
	public GameObject player;

	// Update is called once per frame
	void Update()
	{
		if (Vector3.Distance(player.transform.position, gameObject.transform.position) < 0.3f)
		{
			playerGetKey.KeyGot();
		}
	}
}