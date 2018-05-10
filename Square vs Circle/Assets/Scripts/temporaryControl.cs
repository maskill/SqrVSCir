using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temporaryControl: MonoBehaviour
{
	public Rigidbody2D rigidBody;
	public GameObject projectile;
	public float y_movement = 0f;
	public float x_movement = 0f;
	public float Attraction_Strength = 5f;

	public float speed = 1f;

	void Start()
	{
		rigidBody = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		//VERTICAL MOVEMENT
		y_movement = Input.GetAxis("Vertical");
		if (y_movement > 0f)
		{
			rigidBody.velocity = new Vector3(y_movement * speed, rigidBody.velocity.y);
		}
		else if (y_movement < 0f)
		{
			rigidBody.velocity = new Vector3(y_movement * speed, rigidBody.velocity.y);
		}
		else
		{
			rigidBody.velocity = new Vector3(0, rigidBody.velocity.y);
		}

		//HORIZONTAL MOVEMENT
		x_movement = Input.GetAxis("Horizontal");
		if (x_movement > 0f)
		{
			rigidBody.velocity = new Vector3(x_movement * speed, rigidBody.velocity.x);
		}
		else if (x_movement < 0f)
		{
			rigidBody.velocity = new Vector3(x_movement * speed, rigidBody.velocity.x);
		}
		else
		{
			rigidBody.velocity = new Vector3(0, rigidBody.velocity.x);
		}
	}

	void FixedUpdate()
	{
		rigidBody.AddForce((projectile.transform.position - transform.position).normalized * rigidBody.mass * Attraction_Strength / (projectile.transform.position - transform.position).sqrMagnitude);
	}

	public void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "projectileSquare")
		{
			Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), this.gameObject.GetComponent<Collider2D>());
		}
	}
}
