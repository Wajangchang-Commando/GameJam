using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaBtn : MonoBehaviour // ��ư�� ��������Ʈ ũ�⿡ ���缭 ����� ���ƿ� ����
{
    [SerializeField] private float AlphaThreshold = 0.1f;

    private void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
    }
}
