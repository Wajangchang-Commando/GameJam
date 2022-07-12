using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    //»¡°£´« ÀûÀÇ ¿òÁ÷ÀÓ/ ÃÑ¾Ë»ç
    [SerializeField]
    GameObject Enemy_bullet;
    float currenttime;
    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-2.4f,3.5f), transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        currenttime +=Time.deltaTime;
        if(currenttime > 1.5f)
        {
            GameObject Bullet = Instantiate(Enemy_bullet);
            Bullet.transform.position = transform.position;
            currenttime = 0;
        }
    }
}
