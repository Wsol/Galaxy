using UnityEngine;
using System.Collections;

public class Move_Shot : MonoBehaviour
{
    public float speed;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;        	
	}
}
