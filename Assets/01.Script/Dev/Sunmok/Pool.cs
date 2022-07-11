using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public Stack<Poolable> pool = new Stack<Poolable>();

    public void Create(Poolable obj)
    {
        for(int i = 0; i< 5; i++)
        {
            Poolable obk = Instantiate(obj);
            obk.name = obj.name;
            pool.Push(obk);
            obk.gameObject.SetActive(false);
            
        }
    }
    public Poolable push(Poolable obj)
    {
        pool.Push(obj);
        obj.gameObject.SetActive(false);
        return obj;
    }
    public Poolable pop()
    {
        Poolable obj = pool.Pop();
        obj.gameObject.SetActive(true);
        return obj;
    }
}
