using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using Microsoft.MixedReality.Toolkit;


public class hideMesh : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    public void meshHide()
    {
        // Get the first Mesh Observer available, generally we have only one registered
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        // Set to not visible
        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;

    }
    
    // Update is called once per frame
    void Update()
    {
        if((int) (Time.time) == 20)
        {
            meshHide();
            Debug.Log("hide");
        }

    }
}
