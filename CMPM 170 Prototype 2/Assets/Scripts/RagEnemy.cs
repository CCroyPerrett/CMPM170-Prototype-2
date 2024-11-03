using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagEnemy : MonoBehaviour
{
    GameObject player;
    Rigidbody rb;

    bool frozen;
    public float turnspeed = 2;
    public float movespeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rb = gameObject.GetComponent<Rigidbody>();
        frozen = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (Glasses.glasses_on)
        {
            if(frozen == true)
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    GameObject child = transform.GetChild(i).gameObject;
                    child.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                }
                //rb.constraints = RigidbodyConstraints.u;
                rb.useGravity = true;


                frozen = false;
            }
            

            var turnpos = player.transform.position - transform.position;
            turnpos.y = 0;
            var rotation = Quaternion.LookRotation(turnpos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * turnspeed);


            rb.AddForce(transform.forward * Time.deltaTime * movespeed);
        }
        else
        {
            rb.angularVelocity = new Vector3(0, 0, 0); rb.velocity = new Vector3(0, 0, 0);

            if (frozen == false)
            {


                for (int i = 0; i < transform.childCount; i++)
                {
                    GameObject child = transform.GetChild(i).gameObject;
                    //child.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
                    child.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                }
                rb.angularVelocity = new Vector3(0, 0, 0); rb.velocity = new Vector3(0, 0, 0);  //rb.constraints = RigidbodyConstraints.FreezePosition;
                frozen = true; rb.useGravity = false;
            }
        }
    }
}