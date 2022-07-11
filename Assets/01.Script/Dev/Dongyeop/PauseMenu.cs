using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

    private bool _pauseBool = false;

    public bool pauseState = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _pauseBool == false)
            PauseOn();
        else if (Input.GetKeyDown(KeyCode.Escape) && _pauseBool == true)
            PauseOff();
    }

    #region PauseMenu On/Off
    private void PauseOn()
    {
        _pauseMenu.SetActive(true);
        _pauseBool = true;
        pauseState = true;
        Time.timeScale = 0;
    }
    public void PauseOff()
    {
        Time.timeScale = 1;
        _pauseMenu.SetActive(false);
        _pauseBool = false;
        pauseState = false;
    }
    #endregion
}
