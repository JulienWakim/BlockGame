using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketSpawner : MonoBehaviour
{
    public Camera camera;
    public GameObject basket;
    private bool initial;


    // Start is called before the first frame update
    void Start()
    {
       initial = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (initial && basket.active)
        {
            Vector3 playerPos = camera.transform.position;
            Vector3 playerDirection = camera.transform.forward;
            Vector3 spawnPos = playerPos + playerDirection + camera.transform.up * 3f;
            basket.transform.position = spawnPos;
            initial = false;
        }
    }
}
