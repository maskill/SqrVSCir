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

	//Static Position Replacement
	public GameObject static_projectile;

	//Variable for attraction
	public GameObject playerSquare;
	public Rigidbody2D rigidBody;
	public float str_Attraction = 1.0f;

	public void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Obstacles")
		{
			GameObject.Find("projectileParent").GetComponent<parentProjectile>().spawnCirs();
			Destroy(gameObject);
		}

		if(col.gameObject.tag == "projectileSquare")
		{
			Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), this.gameObject.GetComponent<Collider2D>());
		}
	}

	void Start()
	{
		rigidBody = GetComponent<Rigidbody2D>();
		static_projectile = GameObject.Find("projectileSquare_S");
		transform.position = static_projectile.transform.position;
		target = static_projectile.transform.position;
		
		Debug.Log("[start]static_projectile:" + static_projectile);
	}

	void Update()
	{
		//Movement - For Next Time, Try to Implement the movement as a force rather than a change in position
		currentPosition = transform.position;
		/*if (Input.GetButtonUp ("Fire1"))
		{
			transform.position = static_projectile.transform.position;
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.z = transform.position.z;
		}*/
		transform.position = Vector3.MoveTowards (transform.position, target, speed * Time.deltaTime);
		lastPosition = transform.position;

		//Spiral
		if (currentPosition != lastPosition)
		{
			transform.Rotate (0f, 0f, 100f);
		}

		//Attraction
//		Vector3 direction = playerSquare.transform.position - transform.position;
//		rigidBody.AddForce(str_Attraction * direction);
	}

	public void mvSqr(Vector3 msPos){
		//This function may run before 'start' function can finish processing the "Find" function so im calling "Find" here too.
		static_projectile = GameObject.Find("projectileSquare_S");
		Debug.Log("[mvSqr]static_projectile:" + static_projectile);
		
		transform.position = static_projectile.transform.position;
		target = Camera.main.ScreenToWorldPoint(msPos);
		target.z = transform.position.z;
	}
}
