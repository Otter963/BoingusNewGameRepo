using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

/*References:
Title: 6 minute PAUSE MENU Unity Tutorial
Author: BMo
Date: 2020, May 18
Code version: 6000.0.51f1
Availability: https://www.youtube.com/watch?v=9dYDBomQpBQ
*/

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject playerUI;
    [SerializeField] private InputActionAsset playerInput;

    public static bool isPaused;

    //input stuff
    private InputAction pauseMenuAction;

    private void Awake()
    {
        pauseMenuAction = playerInput.FindActionMap("Player").FindAction("PauseGame");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseMenuAction.WasPressedThisFrame())
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        playerUI.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        playerUI.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
