using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // ���ϰ� ����� �������� ���Բ� ����°�
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime*5; 
        if(transform.position.x < -17.5)
        {
            transform.position = new Vector3(17.5f, 0);
        }
    }
}
