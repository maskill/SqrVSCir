using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCirs : MonoBehaviour {
		public GameObject cir;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void spawnCir(){
		Debug.Log("spwned a cir");
		Instantiate(cir, GameObject.Find("Circles").transform.position , Quaternion.identity );
		//Instantiate(cir, new Vector3(2.8F, -4.55F, 0F) , Quaternion.identity);
	}
}
