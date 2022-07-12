using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour //특정키를 누르면 현제 스킬의 스프라이트가 바뀌는 스크립트입니다. 현제 키는 F입니다.
{
    [SerializeField] private GameObject _thisGun;
    [SerializeField] private GameObject _thisJump;
    [SerializeField] private GameObject _thisShield;
    [SerializeField] private GameObject _nextGun;
    [SerializeField] private GameObject _nextJump;
    [SerializeField] private GameObject _nextShield;

    public int thisSkillNum = 1;

    private void Start()
    {
        #region 시작할때 모두를 끈다.
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
        if (Input.GetKeyDown(KeyCode.F))
            thisSkillNum++;
        if (thisSkillNum == 4)
            thisSkillNum = 1;

        ThisSkill();
        NextSkill();
    }

    private void ThisSkill() //지금의 사용할 수 있는 스킬이 어떤건지
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

    private void NextSkill() //다음 사용 가능한 스킬이 어떤건지
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

    #region 스프라이트 친구들이 켜지고 꺼지는거 모아뒀어용
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
