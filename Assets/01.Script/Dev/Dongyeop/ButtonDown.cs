using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonDown : MonoBehaviour // ��ư �������� ���Ǵ� ��ũ��Ʈ���� ����
{
    [SerializeField] private int _sceneScore1;

    public void ExitButtonDown()
    {
        Time.timeScale = 1;
        Application.Quit();
    }

    public void SceneChanger1()
    {
        SceneManager.LoadScene(_sceneScore1);
    }
}
