using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public TMP_Text textMesh;
    public TMP_Text gameOverTextMeshPoints;
    private float points = 0;
    public Button collectСargoButton;
    public CanvasGroup gameOverCanvas;
    public CanvasGroup gameCanvas;
    private Timer gameTimer;

    private void Start()
    {
        Utility.SetCanvasGroupEnabled(gameOverCanvas, false);
        gameTimer = gameObject.GetComponent<Timer>();
    }

    private void Update()
    {
        if (gameTimer.secondsToGameOver)
        {
            Utility.SetCanvasGroupEnabled(gameCanvas, false);
            Utility.SetCanvasGroupEnabled(gameOverCanvas, true);
            gameOverTextMeshPoints.text = $"{points}";
        }
    }

    public void СollectСargoButton()
    {
        points++;
        textMesh.text = $"{points}";
        collectСargoButton.interactable = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

}
