using UnityEngine;
using System.Collections;

public class MovingPlatformController : MonoBehaviour
{
    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Slerp(startMarker.position, endMarker.position, fracJourney);




        if ( fracJourney >= 0.99f )
        {
            Vector3 temp = endMarker.position;             
            endMarker.transform.position = startMarker.transform.position;
            startMarker.transform.position = temp;
            fracJourney = 0.0f;
            distCovered = 0.0f;
            startTime = Time.time;
        }
    }
}