using UnityEngine;
using UnityEngine.SceneManagement;

/*References:
Title:  5 minute MAIN MENU Unity Tutorial
Author: BMo
Date: 2020a, January 19
Code version: 6000.0.51f1
Availability: https://www.youtube.com/watch?v=-GWjA6dixV4
*/

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
