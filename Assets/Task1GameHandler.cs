using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1GameHandler : MonoBehaviour
{
    public GameObject RedMug;
    public GameObject GreenMug;
    public GameObject BlueMug;
    public GameObject PlaceRedMugButton;
    public GameObject PlaceGreenMugButton;
    public GameObject PlaceBlueMugButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceRedMug()
    {
        RedMug.transform.position = new Vector3(-5.716f, 1.02f, 4.5f);
    }

    public void PlaceBlueMug()
    {
        BlueMug.transform.position = new Vector3(-4.635f, 1.02f, 4.5f);
    }

    public void PlaceGreenMug()
    {
        GreenMug.transform.position = new Vector3(-6.839f, 1.02f, 4.5f);
    }
}
