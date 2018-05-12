using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentProjectile : MonoBehaviour {

	public GameObject[] childRef;
	//public GameObject playerSquare;
	//childRef[0] = m
	//childRef[1] = s
	public GameObject sqr;
	//public GameObject obj;

	void Start()
	{
		Debug.Log(childRef);
		childRef[0].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
	}

	void Update()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			//triggers the newly spawned square to move.
			childRef[0] = Instantiate(sqr, new Vector3(2.8F, -4.55F, 0F) , Quaternion.identity);
			childRef[0].GetComponent<projectile>().mvSqr(Input.mousePosition);
			
			//Mobile is Active
			//childRef [0].GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
			childRef [1].GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 0f);
		}
//		else if(childRef[0].transform.position == playerSquare.transform.position)
//		{
//			
//		}
		if (childRef[0] == null){
			Debug.Log("hit low lvl");
			
			childRef[0] = Instantiate(sqr, new Vector3(2.8F, -4.55F, 0F) , Quaternion.identity );
			//obj = Instantiate(sqr, new Vector3(2.8F, -4.55F, 0F), Quaternion.identity);
			
			//childRef[0] = obj;
			childRef [0].GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
			
		}
		
	}
}

