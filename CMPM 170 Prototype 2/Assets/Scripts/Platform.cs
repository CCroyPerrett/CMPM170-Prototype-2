using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Glasses.glasses_on == false)
        {
            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<Collider>().enabled = true;
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}
