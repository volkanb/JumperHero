using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 360f, 0), Time.deltaTime * 45, Space.World);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Jimmy")
            StartCoroutine(DestructionRoutine());
    }


    private IEnumerator DestructionRoutine ()
    {
        transform.Find("Radish Model").transform.gameObject.SetActive(false);
        transform.Find("TinyFire3_Strong").transform.gameObject.SetActive(false);
        transform.Find("TinyFire3_Strong_Burst").transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        Destroy(this.gameObject);
    }
}
