using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // 맵하고 장승이 왼쪽으로 가게끔 만드는거
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime*5; 
    }
}
