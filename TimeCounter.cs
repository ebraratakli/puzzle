using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class timeCounter : MonoBehaviour
{
    public static timeCounter Instance;
    public float currentTime = 0f, startingTime;
    public Text countDownText;
    public int sceneID = 5;

    void Start()
    {
        currentTime = startingTime;

    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = "Remaining Time: " + currentTime.ToString("0");
        Debug.Log("Current Time: " + currentTime);

        if (currentTime <= 0)
        {
            currentTime = 0;
            Time.timeScale = 0f;
            PlayerPrefs.SetString("PreviousScene", SceneManager.GetActiveScene().name);
            StartCoroutine(LoadSceneAsync(5));

        }
    }

    IEnumerator LoadSceneAsync(int sceneId)
    {
        currentTime = startingTime;
        Time.timeScale = 1f;
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            yield return null;
        }


    }
}