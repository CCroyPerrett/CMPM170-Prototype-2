using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorID : MonoBehaviour
{
    [SerializeField] string IDNumber;
    public string getID(){
        return IDNumber;
    }
}
