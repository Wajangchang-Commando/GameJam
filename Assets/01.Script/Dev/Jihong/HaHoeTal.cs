using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaHoeTal : MonoBehaviour
{
    float speed=10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
    }
}
