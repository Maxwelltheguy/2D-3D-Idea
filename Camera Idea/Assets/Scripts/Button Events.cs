using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    [SerializeField] string tutorialScene;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void EnterTutorial()
    {
        SceneManager.LoadScene(tutorialScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
}
