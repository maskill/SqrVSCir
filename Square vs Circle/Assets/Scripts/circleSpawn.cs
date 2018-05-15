using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleSpawn : MonoBehaviour
{
	public GameObject[] circleRef;
	public GameObject prefab;
	public float timer = 0.0f;

	void Update () 
	{
		if (circleRef[0] == null)
		{
			spawnCircle ();
		}
	}

	void spawnCircle()
	{
		timer += Time.deltaTime * 1;
		if (timer >= 1f)
		{
			circleRef [0] = Instantiate (prefab, gameObject.transform.position, Quaternion.identity);
			timer = 0.0f;
		}
	}
}
