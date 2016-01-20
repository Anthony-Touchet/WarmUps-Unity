using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {

    public Transform[] patrolPoints;
    private int currentPoint = 0;

    public float speed;	
	
	void Update () {
        if (transform.position == patrolPoints[currentPoint].position)
        {
            currentPoint++;
        }

        if(currentPoint >= patrolPoints.Length)
        {
            currentPoint = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, speed * Time.deltaTime);
    }
}
