using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour // PauseMenu¿¡¿ä ¤¾¤¾ 
{
    [SerializeField] private GameObject _pauseMenu;

    public bool pauseState = false;

    #region PauseMenu On/Off
    public void PauseOn()
    {
        _pauseMenu.SetActive(true);
        pauseState = true;
        Time.timeScale = 0;
    }
    public void PauseOff()
    {
        Time.timeScale = 1;
        _pauseMenu.SetActive(false);
        pauseState = false;
    }
    #endregion
}
