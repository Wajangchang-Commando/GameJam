using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public Stack<Poolable> pool;

    /*public Poolable push(Poolable obj)
    {
        pool.Push(obj);
        obj.gameObject.SetActive(false);
    }
    public Poolable pop()
    {
        Poolable obj = pool.Pop;
    }*/
}
