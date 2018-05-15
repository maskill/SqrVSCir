using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionTrigger : MonoBehaviour
{
	public float min;
	public float max;
	void Start()
	{
		min = transform.position.x;
		max = transform.position.x + 2;
	}

	void Update()
	{
		transform.position = new Vector3(Mathf.PingPong(Time.time * 5, max - min)+ min, transform.position.y, transform.position.z);
	}

	public void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "projectileSquare")
		{
			Destroy(gameObject);
		}
	}
}
