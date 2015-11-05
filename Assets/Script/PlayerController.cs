using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		
        if(moveHorizontal >= 0.01f || moveHorizontal <= 0.01f)
        {
            gameObject.transform.Translate(new Vector3(moveHorizontal, 0.0f, 0.0f));
        }        		
	}
}