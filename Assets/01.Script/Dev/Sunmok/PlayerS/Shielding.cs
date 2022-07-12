using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shielding : MonoBehaviour
{
    [SerializeField]GameObject Shield;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Shield.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            Shield.SetActive(false);
        }
    }
}
