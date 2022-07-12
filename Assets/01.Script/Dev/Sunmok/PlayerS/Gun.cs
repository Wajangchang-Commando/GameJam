using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public void Shoot()
    {
        Poolable obj = PoolManager.Instance.Summon("Bullet");
            obj.transform.position = transform.position;

    }
}
