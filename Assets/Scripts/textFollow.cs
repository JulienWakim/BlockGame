using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textFollow : MonoBehaviour
{
    public Camera CameraFacing;
    private Vector3 origScale;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        origScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        float distance;
        if (Physics.Raycast(new Ray(CameraFacing.transform.position, CameraFacing.transform.rotation * Vector3.forward), out hit))
        {
            distance = hit.distance;
        }
        else
        {
            distance = CameraFacing.farClipPlane * .01f; 
        }


        //Vector3 targetPosition = CameraFacing.transform.TransformPoint(new Vector3(0, 0, distance));

        //Vector3 velocity = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position, CameraFacing.transform.position + CameraFacing.transform.rotation * Vector3.forward * distance, ref velocity, speed);
        //var lookAtPos = new Vector3(CameraFacing.transform.position.x, transform.position.y, CameraFacing.transform.position.z);
        //transform.LookAt(lookAtPos);


        transform.position = Vector3.Lerp(transform.position, CameraFacing.transform.position + CameraFacing.transform.rotation * Vector3.forward * distance, 5f);
        transform.LookAt(CameraFacing.transform.position);

        transform.Rotate(0f, 180f, 0f);
        if (distance < 10.0f)
        {
            distance *= 1 + 5*Mathf.Exp(-distance);
        }
        transform.localScale = origScale * distance;
    }
}
