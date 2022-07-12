using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Poolable obj = PoolManager.Instance.Summon("Bullet");
            obj.transform.position = transform.position;
        }
    }
}
