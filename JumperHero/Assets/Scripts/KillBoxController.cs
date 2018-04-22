using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBoxController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {        
        if (other.tag != "KillBox" && other.tag != "Jimmy")
            //other.gameObject.transform.
            Destroy(other.gameObject);
        else if (other.tag != "KillBox" && other.tag == "Jimmy")
        {
            other.GetComponent<SimpleCharacterControl>().StartDeathSequence(1);
        }





    }

}
