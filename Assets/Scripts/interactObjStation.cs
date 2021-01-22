using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactObjStation : MonoBehaviour
{
    private void OnCollisionEnter(Collision col){
        if (col.gameObject.tag == "OnionChest" && col.gameObject.tag == "PumpkinChest"){
            TasksController.onionTaskFinished = true;
        }


    }



}
