using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManger : MonoBehaviour //Ư��Ű�� ������ ���� ��ų�� ��������Ʈ�� �ٲ�� ��ũ��Ʈ�Դϴ�. ���� Ű�� F�Դϴ�.
{
    [SerializeField] private GameObject _thisGun;
    [SerializeField] private GameObject _thisJump;
    [SerializeField] private GameObject _thisShield;
    [SerializeField] private GameObject _nextGun;
    [SerializeField] private GameObject _nextJump;
    [SerializeField] private GameObject _nextShield;

    [SerializeField] private GameObject Pausemenu;

    public int thisSkillNum = 1;


    private void Start()
    {
        #region �����Ҷ� ��θ� ����.
        _thisGun.SetActive(false);
        _thisJump.SetActive(false);
        _thisShield.SetActive(false);
        _nextGun.SetActive(false);
        _nextJump.SetActive(false);
        _nextShield.SetActive(false);
        #endregion

        thisSkillNum = 1;
    }


    private void Update()
    {
        if(Pausemenu.GetComponent<PauseMenu>().pauseState == false)
            if (Input.GetKeyDown(KeyCode.F))
                thisSkillNum++;
        if (thisSkillNum == 4)
            thisSkillNum = 1;

        ThisSkill();
        NextSkill();
    }

    private void ThisSkill() //������ ����� �� �ִ� ��ų�� �����
    {
        switch (thisSkillNum)
        {
            case 1:
                FirstChange(_thisGun, _thisJump, _thisShield);
                break;
            case 2:
                SecondChange(_thisGun, _thisJump, _thisShield);
                break;
            case 3:
                ThirdChange(_thisGun, _thisJump, _thisShield);
                break;
            default:
                break;
        }
    }

    private void NextSkill() //���� ��� ������ ��ų�� �����
    {
        switch (thisSkillNum)
        {
            case 1:
                SecondChange(_nextGun, _nextJump, _nextShield);
                break;
            case 2:
                ThirdChange(_nextGun, _nextJump, _nextShield);
                break;
            case 3:
                FirstChange(_nextGun, _nextJump, _nextShield);
                break;
            default:
                break;
        }
    }

    #region ��������Ʈ ģ������ ������ �����°� ��Ƶ׾��
    private void FirstChange(GameObject first, GameObject second, GameObject third)
    {
        first.SetActive(true);
        second.SetActive(false);
        third.SetActive(false);
    }
    private void SecondChange(GameObject first, GameObject second, GameObject third)
    {
        first.SetActive(false);
        second.SetActive(true);
        third.SetActive(false);
    }
    private void ThirdChange(GameObject first, GameObject second, GameObject third)
    {
        first.SetActive(false);
        second.SetActive(false);
        third.SetActive(true);
    }
    #endregion

}
