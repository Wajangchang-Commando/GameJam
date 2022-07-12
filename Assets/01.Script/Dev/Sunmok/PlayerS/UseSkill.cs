using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSkill : MonoBehaviour
{
    [SerializeField] private Gun gun;
    [SerializeField] private Jump jump;
    [SerializeField] private Shielding shielding;

    [SerializeField] private SkillManager Skill;
    
    private void Update()
    {
        switch (Skill.thisSkillNum)
        {
            case 1:
                gun.gameObject.SetActive(true);
                jump.enabled = false;
                shielding.enabled = (false);
                break;
            case 2:
                gun.gameObject.SetActive(false);
                jump.enabled = true;
                shielding.enabled = (false);
                break;
            case 3:
                gun.gameObject.SetActive(false);
                jump.enabled = false;
                shielding.enabled = true;
                break;

        }
    }

    public void OnClick()
    {
        Debug.Log("asdf");
        switch (Skill.thisSkillNum)
        {
            case 1:
                gun.Shoot();
                break;
            case 2:
                jump.jump();
                break;
            case 3:
                shielding.shield();
                break;
        }
    }
}
