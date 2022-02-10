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

    // Start is called before the first frame update
    void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if(Time.time > 1f && Time.time < 21f)
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

        if(Time.time > 22f)
        {
            text4.SetActive(true);
        }

        if (blocks.active)
        {
            text4.SetActive(false);
        }
    }
}
