using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDown : MonoBehaviour // ��ư �������� ���Ǵ� ��ũ��Ʈ���� ����
{
    public void ExitButtonDown()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
}
