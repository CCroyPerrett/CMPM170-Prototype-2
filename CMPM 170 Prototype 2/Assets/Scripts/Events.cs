using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    [SerializeField] GameObject[] doors;
    public void KeyCollected(string keyID){
        foreach (GameObject door in doors){
            if (door.GetComponent<DoorID>().getID() == keyID){
                door.transform.Find("Door").gameObject.SetActive(false);
                //Debug.Log("door opened");
            }
        }
    }
}
