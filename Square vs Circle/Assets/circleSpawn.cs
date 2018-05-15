using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleSpawn : MonoBehaviour
{
	public GameObject[] circleRef;
	public GameObject prefab; 

	void Update () 
	{
		if (circleRef[0] == null)
		{
			Debug.Log ("CIRCLE DELETED");
			circleRef[0] = Instantiate(prefab, gameObject.transform.position , Quaternion.identity);
		}
	}
}
