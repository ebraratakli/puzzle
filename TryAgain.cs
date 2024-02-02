using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    private string previousScene;

    private void Start()
    {
        // Önceki sahneyi kaydet
        previousScene = PlayerPrefs.GetString("PreviousScene");
    }

    public void PlayAgain()
    {
        // Önceki sahneye geri dön
        SceneManager.LoadScene(previousScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}