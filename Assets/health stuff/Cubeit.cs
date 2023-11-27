using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubeit : MonoBehaviour
{
    public Vector3 rotateit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateit * Time.deltaTime);
    }
}

