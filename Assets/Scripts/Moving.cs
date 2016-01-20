using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {

    private Rigidbody movingPlayer;
    public float speed;

    void Start() {
        movingPlayer = GetComponent<Rigidbody>();
    }
	
	void Update () {
        if(Input.GetKey("d"))
        {
            movingPlayer.velocity = new Vector3(speed, 0, 0);
        }

        else if(Input.GetKey("w"))
        {
            movingPlayer.velocity = new Vector3(0, 0, speed);
        }

        else if (Input.GetKey("a"))
        {
            movingPlayer.velocity = new Vector3(-(speed), 0, 0);
        }

        else if (Input.GetKey("s"))
        {
            movingPlayer.velocity = new Vector3(0, 0, -(speed));
        }

    }
}
