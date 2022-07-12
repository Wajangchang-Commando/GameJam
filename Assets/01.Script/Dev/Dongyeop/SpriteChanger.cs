using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour // playerHP가 깍이면 스프라이트가 하나씩 변경
{
    [SerializeField] private Sprite _onImage;
    [SerializeField] private Sprite _offImage;

    [SerializeField] private Image _playerHP1;
    [SerializeField] private Image _playerHP2;
    [SerializeField] private Image _playerHP3;
    [SerializeField] private Image _playerHP4;
    [SerializeField] private Image _playerHP5;

    public int playerHP = 5;



    private void Update()
    {
        PlayerHP();
    }

    private void PlayerHP()
    {
        playerHP--;
        switch (playerHP)
        {
            case 5:
                _playerHP1.GetComponent<Image>().sprite = _onImage;
                break;
            case 4:
                SpriteChange(_playerHP2, _playerHP1);
                break;
            case 3:
                SpriteChange(_playerHP3, _playerHP2);
                break;
            case 2:
                SpriteChange(_playerHP4, _playerHP3);
                break;
            case 1:
                SpriteChange(_playerHP5, _playerHP4);
                break;
            case 0:
                _playerHP5.GetComponent<Image>().sprite = _offImage;
                break;
            default:
                break;
        }
    }

    private void SpriteChange(Image on, Image off)
    {
        on.GetComponent<Image>().sprite = _onImage;
        off.GetComponent<Image>().sprite = _offImage;
    }
}
