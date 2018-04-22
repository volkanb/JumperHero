// https://www.youtube.com/watch?v=T1hqJcHTVJI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyController : MonoBehaviour {

    public Transform target;
    public Transform myTransform;
    public int speed = 5;

    private bool isAttacking = false;

    private Transform lookingTarget;

    private void Start()
    {
        lookingTarget = target;
    }

    // Update is called once per frame
    void Update () {
        
        
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        if ((transform.position - target.position).magnitude > 0.7 && !isAttacking)
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        else
        {

            // START ENEMY ATTACKING
        }

	}

    void StartAttacking()
    {

    }
}
