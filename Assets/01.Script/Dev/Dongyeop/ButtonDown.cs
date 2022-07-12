using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDown : MonoBehaviour // 버튼 눌렀을때 사용되는 스크립트에용 ㅎㅎ
{
    public void ExitButtonDown()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
}
