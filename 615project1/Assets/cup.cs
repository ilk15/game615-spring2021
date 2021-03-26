using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cup : MonoBehaviour
{
    
    public bool hold = true;
    Vector3 startPosition;
	Quaternion startRotation;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
		startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
      
       if (hold)
       {

          Vector3 temp = Input.mousePosition;
          temp.z = 35f; // Set this to be the distance you want the object to be placed in front of the camera.
          this.transform.position = Camera.main.ScreenToWorldPoint(temp);
          transform.rotation = startRotation;
        }
    }

    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "paw") {
        hold = false;
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.useGravity = true;
        }
    }
}
