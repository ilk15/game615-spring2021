using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSnowballs : MonoBehaviour
{
    public GameObject snowballPrefab;
    private GameObject cameraObj;
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SpawnSnowball()
    {
        GameObject snowball = Instantiate(snowballPrefab, transform.position, transform.rotation);
        snowball.transform.LookAt(cameraObj.transform);
    }  
}
