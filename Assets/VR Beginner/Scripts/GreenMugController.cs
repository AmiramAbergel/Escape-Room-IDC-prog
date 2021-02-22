using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMugController : MonoBehaviour
{
    public static bool PlacedGreenMugCorrectly;
    public GameObject PlaceGreenMugButton;
    // Start is called before the first frame update
    void Start()
    {
        PlacedGreenMugCorrectly = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "GreenPlatform")
        {
            PlacedGreenMugCorrectly = true;
            PlaceGreenMugButton.SetActive(false);
        }
    }
}
