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

    // Update is called once per frame
    public void jump()
    {
        Jumping();
    }

    private void Jumping()
    {
        Rigid.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
    }
}