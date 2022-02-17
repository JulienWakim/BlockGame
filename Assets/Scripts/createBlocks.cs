using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBlocks : MonoBehaviour
{

    public Camera camera;

    public GameObject cubeBlock;
    public GameObject cycBlock;
    public GameObject rectBlock;
    public GameObject basket;

    public int numCubeBlocks = 10;
    public int numCycBlocks = 10;
    public int numRectBlocks = 10;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    IEnumerator Example()
    {
        // Pause for a second.
        yield return new WaitForSeconds(10f);
    }

    public void createBlocksSpeech()
    {
        /*
                Time.timeScale = 0.0f;


                Vector3 playerPos = camera.transform.position;
                Vector3 playerDirection = camera.transform.forward;
                Quaternion playerRotation = camera.transform.rotation;




                for (int ii = 0; ii < numCubeBlocks; ++ii)
                {
                    var position = new Vector3(Random.Range(-1.0f, 1.0f), 0f, Random.Range(1.0f, 2.0f));
                    Instantiate(cubeBlock, position + spawnPos, Quaternion.identity, GameObject.Find("Blocks").transform);
                }

                for (int ii = 0; ii < numCycBlocks; ++ii)
                {
                    var position = new Vector3(Random.Range(-1.0f, 1.0f), 0f, Random.Range(1.0f, 2.0f));
                    Instantiate(cycBlock, position + spawnPos, Quaternion.identity, GameObject.Find("Blocks").transform);
                }

                for (int ii = 0; ii < numRectBlocks; ++ii)
                {
                    var position = new Vector3(Random.Range(-1.0f, 1.0f), 0f, Random.Range(1.0f, 2.0f));
                    Instantiate(rectBlock, position + spawnPos, Quaternion.identity, GameObject.Find("Blocks").transform);
                }

                StartCoroutine(Example());
                Time.timeScale = 1.0f;

                */
        Vector3 basketPos = basket.transform.position;
        Vector3 spawnPos = basketPos + basket.transform.up;
        Instantiate(cubeBlock, spawnPos + basket.transform.up * .5f, Quaternion.identity, GameObject.Find("Blocks").transform);
        Instantiate(rectBlock, spawnPos + basket.transform.up * 1f, Quaternion.identity, GameObject.Find("Blocks").transform);
        Instantiate(cycBlock, spawnPos + basket.transform.up * 1.5f, Quaternion.identity, GameObject.Find("Blocks").transform);
    }
    
   // public void CollisionDectection
  //  {
    //    if (objectCollider.IsTouching(objectCollider2)){
      //      Debug.Log("LOL");
      //  }
   // }
}


