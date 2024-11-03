using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    Rigidbody rb;
    public float turnspeed = 2;
    public float movespeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rb = gameObject.GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Glasses.glasses_on)
        {
            var turnpos = player.transform.position - transform.position;
            turnpos.y = 0;
            var rotation = Quaternion.LookRotation(turnpos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * turnspeed);

            rb.AddForce(transform.forward * Time.deltaTime * movespeed);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
