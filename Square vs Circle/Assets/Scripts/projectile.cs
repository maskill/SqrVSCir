using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {
	//Variables for movements and spirals
	public float speed = 1.5f;
	public Vector3 currentPosition;
	public Vector3 lastPosition;
	public Vector3 displacement;
	private Vector3 target;
	private Collider2D hitBox2d;

	//Static Position Replacement
	public GameObject static_projectile;

	//Variable for attraction
	public GameObject playerSquare;
	public Rigidbody2D rigidBody;
	public float str_Attraction = 1.0f;

	public void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "projectileSquare")
		{
			Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), this.gameObject.GetComponent<Collider2D>());
		}

		if (col.gameObject.tag == "Circles")
		{
			hitBox2d.enabled = false;
		}
	}

	void Start()
	{
		rigidBody = GetComponent<Rigidbody2D>();
		transform.position = static_projectile.transform.position;
		target = static_projectile.transform.position;
		hitBox2d = gameObject.GetComponent<Collider2D>();
	}

	void Update()
	{
		//Movement - For Next Time, Try to Implement the movement as a force rather than a change in position
		currentPosition = transform.position;
		if (Input.GetButtonDown ("Fire1"))
		{
			transform.position = static_projectile.transform.position;
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//target.z = transform.position.z;
			hitBox2d.enabled = true;
		}
		transform.position = Vector3.MoveTowards (transform.position, target, speed * Time.deltaTime);
		lastPosition = transform.position;

		//Spiral
		if (currentPosition != lastPosition)
		{
			transform.Rotate (0f, 0f, 100f);
		}
	}
}