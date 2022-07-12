using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shielding : MonoBehaviour
{
    [SerializeField] public GameObject Shield;

    public void shield()
    {
            StopAllCoroutines();
        StartCoroutine(guard());
    }
    IEnumerator guard()
    {
        Shield.SetActive(true);
        yield return new WaitForSeconds(2f);
        Shield.SetActive(false);
        yield return null;
    }
}
