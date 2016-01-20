using UnityEngine;
using System.Collections;

public class MovingPathNew : MonoBehaviour {

    private bool move = false;
    private bool side = false;
    public int speed;

	void Lerp (float a, float b, float c) {//Lerp: moving by position
        gameObject.transform.position = new Vector3(transform.position.x + a, transform.position.y + b, transform.position.z + c);
	}
	

	void Update () {
        if(Input.GetKey(KeyCode.Space))//When space is hit, change bool
        {
            move = true;
        }

        if(move == true && side == false)//If bool is true, Move box. bool controls moving
        {
            Lerp(1 * Time.deltaTime * speed, 0, 0);
        }

        if (move == true && side == true)//If bool is true, Move box. bool controls moving
        {
            Lerp(-(1 * Time.deltaTime * speed), 0, 0);
        }

        if (gameObject.transform.position.x >= 4.5f)//If bool position extends certain point, stop
        {
            move = false;
            side = true;
        }

        if (gameObject.transform.position.x <= -3.5f)//If bool position extends certain point, stop
        {
            move = false;
            side = false;
        }

    }
}
