using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueMugController : MonoBehaviour
{
    public static bool PlacedBlueMugCorrectly;
    public GameObject PlaceBlueMugButton;
    // Start is called before the first frame update
    void Start()
    {
        PlacedBlueMugCorrectly = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BluePlatform")
        {
            PlacedBlueMugCorrectly = true;
            PlaceBlueMugButton.SetActive(false);
        }
    }
}
