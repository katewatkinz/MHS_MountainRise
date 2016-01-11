using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class MountainRisingScript : MonoBehaviour
{
    /*public float height = 0.0f;
    public Terrain mountain;
    public Plane planes;
    public Slider sliders;*/
    public SphereCollider s;
    // Use this for initialization
    public float objScale = 1;
    

    void OnGUI()
    {
        objScale = GUI.VerticalSlider(new Rect(1100, 220, 500, 150), objScale, 100f, 1);
  
        if (GUI.changed)
        {
            transform.localScale = new Vector3(4, objScale, 1);
        }
    }
	/*void Start ()
    {
        height = 0.0f;
        s = s.GetComponent<SphereCollider>();
        s.radius = 0;
    }
   
    public void OnPressing( float newHeight)
    {
        //height++;
        s.radius = 10;
        height = s.radius;
        newHeight = height;
        //planes.distance = height;

    }
    public void NoPressing(float newHeight)
    {
        height = newHeight;
        //planes.distance = height;
    }*/
	
	// Update is called once per frame
	
}
