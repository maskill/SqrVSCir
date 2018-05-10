using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreProjectile : MonoBehaviour
{
	public void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "projectileSquare")
		{
			Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), this.gameObject.GetComponent<Collider2D>());
		}
	}
}