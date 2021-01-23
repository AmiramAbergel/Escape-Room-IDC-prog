using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactObjStation : MonoBehaviour
{
    private bool onionInBasket = false;
    private bool pumpkinInBasket = false;
    /*private void OnCollisionEnter(Collision col){
        if (col.gameObject.tag == "OnionChest" && col.gameObject.tag == "PumpkinChest"){
            TasksController.onionTaskFinished = true;
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("OnionChest"))
        {
            onionInBasket = true;
            checkIfBothFruitsAreInChest();
        }

        if (other.gameObject.CompareTag("PumpkinChest"))
        {
            pumpkinInBasket = true;
            checkIfBothFruitsAreInChest();
        }
    }

    void checkIfBothFruitsAreInChest()
    {
        if (pumpkinInBasket && onionInBasket)
        {
            TasksController.onionTaskFinished = true;
        }
    }




}
