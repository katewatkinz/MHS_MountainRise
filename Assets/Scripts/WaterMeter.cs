using UnityEngine;
using System.Collections;

public class WaterMeter : MonoBehaviour {

    // Use this for initialization
    public float objScale = 1;


    void OnGUI()
    {
        objScale = GUI.VerticalSlider(new Rect(100, 100, 100, 90), objScale, 100f, 1);

        if (GUI.changed)
        {
            transform.localScale = new Vector3(4, objScale, 1);
        }
    }
    // Update is called once per frame
    void Update () {
	
	}
}
