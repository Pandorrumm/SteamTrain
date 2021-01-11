using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeStart = 5f;
    public TMP_Text textMesh;
    private float timer = 0f;
    public bool secondsToGameOver;
    private float minutes;
    private float seconds;

    private void Start()
    {
        timer = timeStart;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        minutes = (int)(timer / 60);
        seconds = (int)(timer % 60);

        if (minutes <= 0 && seconds <= 0)
        {
            secondsToGameOver = true;
        }

        textMesh.text = minutes.ToString()+"m" + ":" + seconds.ToString()+"s";
    }
}
