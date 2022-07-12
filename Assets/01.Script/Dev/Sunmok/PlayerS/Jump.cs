using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D Rigid;
    [SerializeField] private float JumpForce;
    [SerializeField] private bool Jumping1;
    [SerializeField] private bool Jumping2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jumping();
    }

    private void Jumping()
    {
        //���ǹ��� �߰� ���� �� ��
        //1������
        if (Input.GetKeyDown(KeyCode.J) && Jumping1 == false)
        {
            Rigid.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            Jumping1 = true;
        }
        //2��«��
        else if (Input.GetKeyDown(KeyCode.J) && Jumping2 == false)
        {
            Rigid.AddForce(Vector2.up * JumpForce *1.5f, ForceMode2D.Impulse);
            Jumping2 = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //���� ������ �ٽ� «�� ����
        Jumping1 = false;
        Jumping2 = false;
    }
}
