using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; // Player movement speed
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //transform.position=new Vector3(PlayerPrefs.GetFloat("x"),3,PlayerPrefs.GetFloat("z"));
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.velocity = movement * speed;
    }

    }
    //private void LateUpdate()
    // {
    //   PlayerPrefs.SetFloat("x",transform.position.x);
    //    PlayerPrefs.SetFloat("z",transform.position.z);
    //  }
}