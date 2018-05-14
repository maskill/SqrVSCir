using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentProjectile : MonoBehaviour {

	public GameObject[] childRef;
	//public GameObject playerSquare;
	//childRef[0] = m
	//childRef[1] = s
	public GameObject sqr;
	public GameObject cir;
	public GameObject spawnPoints;
	public int spCount;
	public int circleCount = 12;

	void Start()
	{
		//Debug.Log(childRef);
		childRef[0].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
		spawnPoints = GameObject.Find("spawnPoints");
		spCount = spawnPoints.transform.childCount; 
	}

	void Update()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			childRef[0] = Instantiate(sqr, new Vector3(2.8F, -4.55F, 0F) , Quaternion.identity);
			//triggers the newly spawned square to move.
			Debug.Log(Input.mousePosition);
			childRef[0].GetComponent<projectile>().mvSqr(Input.mousePosition);
			
			//Mobile is Active
			childRef [0].GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
			childRef [1].GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 0f);
		}
//		else if(childRef[0].transform.position == playerSquare.transform.position)
//		{
//			
//		}
		/*if (childRef[0] == null){
			Debug.Log("childRef[0] was null.");
			childRef[0] = Instantiate(sqr, new Vector3(2.8F, -4.55F, 0F) , Quaternion.identity );
			childRef [0].GetComponent<SpriteRenderer> ().color = new Color (1f, 1f, 1f, 1f);
			
		}*/
		
	}
	
	public void spawnCirs(){
		Vector3 pos = spawnPoints.transform.GetChild(Random.Range(0, spCount)).transform.position;
		float offset = Random.Range(-4.5F, 4.5F);
		
		Instantiate(cir,  new Vector3( (pos.x + offset), (pos.y + offset), pos.z), Quaternion.identity );
		Debug.Log("spawned a circle.");
	}
}

