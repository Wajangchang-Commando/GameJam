using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AndroidButton : MonoBehaviour
{
    [SerializeField] private int _thissceneNum;
    [SerializeField] private int _scenenumber;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
                Application.Quit();
            if (SceneManager.GetActiveScene().buildIndex == _thissceneNum)
                SceneManager.LoadScene(_scenenumber);
        }
    }
}
