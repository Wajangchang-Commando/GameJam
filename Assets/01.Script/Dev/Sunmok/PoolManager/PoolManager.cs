using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    Dictionary<string, Pool> pools = new Dictionary<string, Pool>();
    //poolable��� �߰��� ��
    public Poolable obj1;
    public Poolable obj2;
    public Poolable obj3;
    public static PoolManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            make(obj1); ;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Summon(obj1.name);
        }
    }
    public void make(Poolable pol)
    {
        Pool pool = new Pool();
        pool.Create(pol);
        pools.Add(pol.name, pool);
    }
    public Poolable Summon(string name)
    {
        Poolable obj = pools[name].pop();
        return obj;
    }
    public void Returner(Poolable obj)
    {
        pools[obj.name].push(obj);
    }
}
