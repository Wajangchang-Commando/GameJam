using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaBtn : MonoBehaviour // 버튼을 스프라이트 크기에 맞춰서 해줘요 좋아요 ㅎㅎ
{
    [SerializeField] private float AlphaThreshold = 0.1f;

    private void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
    }
}
