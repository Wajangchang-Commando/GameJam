using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // ���ϰ� ����� �������� ���Բ� ����°�
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime*5; 
    }
}
