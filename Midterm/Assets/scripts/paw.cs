using UnityEditor;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class paw : MonoBehaviour
{
    public float moveTimer = 0f;
 
    float moveSpeed = 40f;

    float dist;
    Vector3 hand;

    // Start is called before the first frame update
    void Start()
    {
        Turn();

    }

    // Update is called once per frame
    void Update()
    {
        moveTimer -= Time.deltaTime;




    }
    
    public void Turn()
    {

        //transform.LookAt(GameObject.Find("playArea").GetComponent<Play>().coffee.transform);
        hand = GameObject.Find("playArea").GetComponent<Play>().coffee.transform.position;
        hand.y = transform.position.y;
        transform.LookAt(hand);
       // dist = Vector3.Distance(hand, transform.position);
        
    }

    public void Attack()
    {

        transform.position = transform.position + transform.forward * moveSpeed * Time.deltaTime;

      //  float upSpeed = moveSpeed * (float) Math.Cos(Math.PI * Vector3.Distance(hand, transform.position) / dist);
     //   transform.position = transform.position + transform.up * upSpeed * Time.deltaTime;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Area")
        {
            moveSpeed = Random.Range(150f, 40f);
            moveTimer = Random.Range(1f, 0.05f);
            Turn();

        }
    }
}
