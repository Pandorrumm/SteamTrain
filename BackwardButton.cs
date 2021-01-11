using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackwardButton : MonoBehaviour
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
            movementSteamTrain.speed -= 2f * movementSteamTrain.speed * Time.deltaTime;
            if (movementSteamTrain.speed == 0)
            {
                movementSteamTrain.speed = 0.1f;
            }
        }
    }
}

