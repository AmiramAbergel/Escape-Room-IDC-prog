using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMugController : MonoBehaviour {

    public GameObject PlaceRedMugButton;
    public static bool PlacedRedMugCorrectly;
    // Start is called before the first frame update
    void Start()
    {
        PlacedRedMugCorrectly = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RedPlatform")
        {
            PlacedRedMugCorrectly = true;
            PlaceRedMugButton.SetActive(false);
        }
    }
}
