using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class СameraSelection : MonoBehaviour
{
    public GameObject cinemachineOne;
    public GameObject cinemachineTwo;
    private bool isSwetch = false;

    public void SwitchCamera()
    {
        if(isSwetch == false)
        {
            isSwetch = true;
            cinemachineTwo.SetActive(true);
            cinemachineOne.SetActive(false);
        }
        else
        {
            isSwetch = false;
            cinemachineTwo.SetActive(false);
            cinemachineOne.SetActive(true);
        }

    }
}
