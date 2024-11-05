using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    [SerializeField] string tutorialScene;
    [SerializeField] string firstLevel;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    //Declaring the events for the buttons
    public void EnterTutorial()
    {
        SceneManager.LoadScene(tutorialScene);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
}
