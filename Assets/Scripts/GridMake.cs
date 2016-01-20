using UnityEngine;
using System.Collections;

public class GridMake : MonoBehaviour {

    private Vector3 startPos;
    public Vector3 space;

    private Vector3 scurrent;
    private Vector3 snext;

    private Vector3 current;
    private Vector3 next;

    public GameObject clone;

    public int n;

	void Awake () {
        startPos = new Vector3(0, 0, 0);
        current = startPos;
	}
	
	void Start () {
        for (int i = 0; i < n; i++)//Y axis
        {
            snext.z = scurrent.z + space.x;
            Instantiate(clone, scurrent, new Quaternion());

            current = scurrent + space;
            for(int t = 0; t < n - 1; t++)
            {
                next = current + space;
                Instantiate(clone, current, new Quaternion());
                current = next;
            }

            scurrent = snext;   
        }

	} 
}
