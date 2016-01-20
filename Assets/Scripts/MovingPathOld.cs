using UnityEngine;
using System.Collections;

public class MovingPathOld : MonoBehaviour {

    private Rigidbody playRB;
    private bool move = false;
    private bool side = false;
    public int speed;

	void Start () {
        playRB = GetComponent<Rigidbody>();
	}
	

	void Update () {

	    if(Input.GetKey(KeyCode.Space))
        {
            move = true;
        }
//Which way thing moves
        if (move == true && side == false)
        {
            playRB.velocity = new Vector3(speed, 0, 0);
        }

        if (move == true && side == true)
        {
            playRB.velocity = new Vector3(-(speed), 0, 0);
        }

        if (gameObject.transform.position.x < -3.5f && side == true)
        {
            move = false;
            side = false;
        }

        else if (gameObject.transform.position.x > 4.5f && side == false)
        {
            move = false;
            side = true;
        }
    }
}
