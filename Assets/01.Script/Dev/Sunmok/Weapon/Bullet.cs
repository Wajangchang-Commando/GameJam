using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    private void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
