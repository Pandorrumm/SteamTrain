using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpeedController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private MovementSteamTrain movementSteamTrain;

    private bool isDown;

    public void OnPointerDown(PointerEventData eventData)
    {
        this.isDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.isDown = false;
    }

    public void Deceleration()
    {
        if (!this.isDown) return;
        movementSteamTrain.speed -= movementSteamTrain.speed * Time.deltaTime; 
    }

    public void Acceleration()
    {
        if (!this.isDown) return;
        movementSteamTrain.speed += movementSteamTrain.speed * Time.deltaTime;
    }

}
