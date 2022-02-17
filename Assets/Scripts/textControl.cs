using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textControl : MonoBehaviour
{

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject blocks;
    public GameObject basket;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        basket.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
  
        if(Time.time > 1f && Time.time < timer-1)
        {
            text1.SetActive(true);
            text2.SetActive(true);
            text3.SetActive(true);
        }
        else
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
        }

        if(Time.time > timer)
        {
            text4.SetActive(true);
            basket.SetActive(true);
        }

        if (blocks.active)
        {
            text4.SetActive(false);
        }
    }
}
