using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses : MonoBehaviour
{
    public static bool glasses_on;
    public Light whitelight;
    public Light pinklight;
    public GameObject glassesPrefab;

    // Start is called before the first frame update
    void Start()
    {
        glasses_on = false;
        whitelight.enabled = true;
        pinklight.enabled = false;
        glassesPrefab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (glasses_on == false)
            {
                glasses_on = true;
                whitelight.enabled = false;
                pinklight.enabled = true;
                glassesPrefab.SetActive(true);
            }
            else
            {
                glasses_on = false;
                whitelight.enabled = true;
                pinklight.enabled = false;
                glassesPrefab.SetActive(false);
            }
        }
    }
}
