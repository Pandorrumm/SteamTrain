using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardButton : MonoBehaviour
{
    private MovementSteamTrain movementSteamTrain;
    bool isPressed = false;

    private void Start()
    {
        movementSteamTrain = FindObjectOfType<MovementSteamTrain>();
    }

    public void OnDown()
    {
        isPressed = true;
    }

    public void OnUp()
    {
        isPressed = false;
    }

    void Update()
    {
        if (isPressed)
        {
            movementSteamTrain.speed += 3f * movementSteamTrain.speed * Time.deltaTime;
            if(movementSteamTrain.speed > 20)
            {
                movementSteamTrain.speed = 20;
            }
        }   
    }
}
