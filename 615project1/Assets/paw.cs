using UnityEditor;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class paw : MonoBehaviour
{

    //This is how long the ring will move in each direction
   // float moveRate = 2;
    //We will use this variable to store how much time there is left until
    //we change directions
    public float moveTimer = 0f;
    //This will be how fast we move the ring each Update
    float moveSpeed = 40f;
    //float moveH;
    // float moveV;
    float dist;
    Vector3 hand;
    // Start is called before the first frame update
    void Start()
    {
        Turn();
       // moveH = 0.05f;
       // moveV = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        moveTimer -= Time.deltaTime;
     //   Debug.Log(moveTimer);
        //Debug.Log(Time.deltaTime);
        //if (moveTimer < 0)
        //{
        //    Attack();
        //}
        



    }
    
    public void Turn()
    {

        //transform.LookAt(GameObject.Find("playArea").GetComponent<Play>().coffee.transform);
        hand = GameObject.Find("playArea").GetComponent<Play>().coffee.transform.position;
        hand.y = transform.position.y;
        transform.LookAt(hand);
        dist = Vector3.Distance(hand, transform.position);
        
    }

    public void Attack()
    {
        //Turn();
        transform.position = transform.position + transform.forward * moveSpeed * Time.deltaTime;

        float upSpeed = moveSpeed * (float) Math.Cos(Math.PI * Vector3.Distance(hand, transform.position) / dist);
        transform.position = transform.position + transform.up * upSpeed * Time.deltaTime;
    }

    //IEnumerator Pause()
    //{
    //    //float t = Random.Range(0.1f, 0.05f);
    //    yield return new WaitForSeconds(1);
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Area")
        {
            moveSpeed = Random.Range(150f, 40f);
            moveTimer = Random.Range(1f, 0.05f);
            //moveTimer = 1f;
            Turn();
           
           //StartCoroutine(Pause());

        }
    }
}
