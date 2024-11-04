using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Glasses : MonoBehaviour
{
    public static bool glasses_on;
    public Light whitelight;
    public Light pinklight;
    public GameObject glassesPrefab;
    [SerializeField] private Image glassesImg;
    [SerializeField] private Sprite defaultGlasses;
    [SerializeField] private Sprite enabledGlasses;
    AudioSource equip;

    // Start is called before the first frame update
    void Start()
    {
        glasses_on = false;
        whitelight.enabled = true;
        pinklight.enabled = false;
        glassesPrefab.SetActive(false);
        equip = GameObject.Find("Equip").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            equip.Play();
            if (glasses_on == false)
            {
                glasses_on = true;
                whitelight.enabled = false;
                pinklight.enabled = true;
                glassesPrefab.SetActive(true);
                glassesImg.sprite = enabledGlasses;
            }
            else
            {
                glasses_on = false;
                whitelight.enabled = true;
                pinklight.enabled = false;
                glassesPrefab.SetActive(false);
                glassesImg.sprite = defaultGlasses;
            }
        }
    }
}
