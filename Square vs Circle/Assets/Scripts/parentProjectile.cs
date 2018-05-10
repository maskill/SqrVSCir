using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentProjectile : MonoBehaviour {

	public GameObject[] childRef;
	//public GameObject playerSquare;
	//childRef[0] = m
	//childRef[1] = s

	void Start()
	{
		childRef[0].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
	}

	void Update()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			//Mobile is Active
			childRef [0].GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
			childRef [1].GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 0f);
		}
//		else if(childRef[0].transform.position == playerSquare.transform.position)
//		{
//			
//		}
	}
}

