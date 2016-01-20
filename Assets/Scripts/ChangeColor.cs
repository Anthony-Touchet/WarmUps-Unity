using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

    [SerializeField] Material col;

    float red;
    float blue;
    float green;
    float alpha;

    private Color colcol;

    void Start()
    {
        red = 1;
        blue = 0;
        green = 0;
        alpha = 1;
    }

	void Update () {

        if(red >= 1)//If red max red is zero
        {
            red = 0;
        }

        else
        {
            red += .005f;//Else, add red
        }

        if(blue >= 1)//If blue maxed, blue is zero
        {
            blue = 0;
        }

        else
        {
            blue += .05f;//else add red
        }

        if(green >= 1)//If green maxed, green is zero
        {
            green = 0;
        }

        else
        {
            green += .025f;//else add green
        }

        col.SetColor("_Color", new Color(red, green, blue, alpha)); 
	}
}
