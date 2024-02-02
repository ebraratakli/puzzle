using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    private string previousScene;

    private void Start()
    {
        // �nceki sahneyi kaydet
        previousScene = PlayerPrefs.GetString("PreviousScene");
    }

    public void PlayAgain()
    {
        // �nceki sahneye geri d�n
        SceneManager.LoadScene(previousScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}