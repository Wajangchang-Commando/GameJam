using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    //하트눈을가진 몹의 움직임
    Vector3 dir;
    float speed=5;
    void Start()
    {
        GameObject target = GameObject.Find("Player");
        dir = target.transform.position - transform.position;
        dir.Normalize();
    }
    void Update()
    {
        GameObject target = GameObject.Find("Player");
        dir = target.transform.position - transform.position; 
        dir.x -= 5;
        dir.Normalize();
        transform.position += dir * speed* Time.deltaTime;
    }
}
