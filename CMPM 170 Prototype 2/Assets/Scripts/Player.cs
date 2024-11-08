using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float turnspeed;
    public float movespeed;
    public float jumpheight;
    public float mouse_sensitivity;

    Rigidbody rb;
    AudioSource jump;
    Vector2 mouse;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        jump = GameObject.Find("Jump").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-1 * transform.right * Time.deltaTime * movespeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * Time.deltaTime * movespeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * Time.deltaTime * movespeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-1 * transform.forward * Time.deltaTime * movespeed);
        }

        //jump
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            jump.Play();
            rb.AddForce(new Vector3(0,1,0) * jumpheight);
        }

        //camera angle
        mouse.x += Input.GetAxis("Mouse X") * mouse_sensitivity;
        mouse.y += Input.GetAxis("Mouse Y") * mouse_sensitivity;
        if(mouse.y > 40) { mouse.y = 40; }if (mouse.y < -40) { mouse.y = -40; }
        transform.localRotation = Quaternion.Euler(-mouse.y, mouse.x, 0);


    }
}
