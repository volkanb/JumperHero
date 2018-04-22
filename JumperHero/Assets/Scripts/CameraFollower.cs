// https://docs.unity3d.com/ScriptReference/Vector3.Slerp.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {
    /*
    public Transform target;
    public float smoothTime = 0.3f;
    public Vector3 offset;

    public bool lockY = false;

    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        Vector3 goalPos = target.position;
        //goalPos.y = transform.position.y;
        offset = transform.position - goalPos;
    }

    void Update()
    {
        Vector3 goalPos = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, goalPos, ref velocity, smoothTime);
    }

    */

    public Transform target;
    public float distance = 3.0f;
    public float height = 3.0f;
    public float damping = 5.0f;
    public bool smoothRotation = true;
    public float rotationDamping = 10.0f;

    public bool isTurning = false;
    public float heightOffset = 1.5f;

    void Update()
    {
        Vector3 wantedPosition = target.TransformPoint(0, height, -distance);

        Vector3 lookAtTarget = target.position;
        lookAtTarget.y += heightOffset;

        if (smoothRotation)
        {            
            Quaternion wantedRotation = Quaternion.LookRotation(lookAtTarget - transform.position, target.up);
            if (!isTurning)
                transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);           
        }
        else
            transform.LookAt(lookAtTarget, target.up);

        transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * damping);
        
    }
}
