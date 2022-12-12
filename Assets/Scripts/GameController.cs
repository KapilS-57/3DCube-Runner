using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject _gameOverPanel;
    public GameObject _tapToStart;
    public GameObject _scoreText;
    private void Start()
    {
        PauseGame();
        _gameOverPanel.SetActive(false);
        _tapToStart.SetActive(true);
        _scoreText.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }
    
    public void GameOver()
    {
        _gameOverPanel.SetActive(true);
        _scoreText.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        _tapToStart.SetActive(false);
        _scoreText.SetActive(true);
    }
}
