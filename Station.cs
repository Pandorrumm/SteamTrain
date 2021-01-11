using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class Station : MonoBehaviour
{
    public bool isAtStation;
    public UnityEvent ActivateButtonEvent;
    public UnityEvent DeActivateButtonEvent;

    private void OnTriggerEnter(Collider other)
    {  
        if (other.tag == "Player")
        {
            isAtStation = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && other.GetComponent<MovementSteamTrain>().speed < 0.2)
        {
            ActivateButtonEvent.Invoke();
            isAtStation = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            DeActivateButtonEvent.Invoke();
            isAtStation = false;
        }
    }
}
