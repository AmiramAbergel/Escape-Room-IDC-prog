using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress2 : MonoBehaviour
{
    public Transform downTransform;
    public Transform buttonMesh;

    public GameObject lockpad;
    public string key;

    private void OnTriggerEnter(Collider other){
        if(other.tag == "player"){
            lockpad.SendMessage("KeyEntry", key);
            buttonMesh.position = downTransform.position;

        }
    }

    private void OnTriggerExit(Collider other){
        if(other.tag == "Player"){
            buttonMesh.localPosition = Vector3.zero;
        }
    }

}
