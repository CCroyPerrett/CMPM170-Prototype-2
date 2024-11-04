using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class KeyBehavior : MonoBehaviour
{
    [SerializeField] string keyID;
    public GameObject manager;
    private Events EventHandler;
    void Start()
    {
        if (manager){
            EventHandler = manager.GetComponent<Events>();
        }
    }


    private void OnTriggerEnter(Collider other){
        //Debug.Log("something collided with key");
        if (other.transform.tag == "Player"){
            //Debug.Log("player collided with key");
            EventHandler.KeyCollected(keyID);
            Destroy(gameObject);
        }
    }
}
