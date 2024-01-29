using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void FollowingLevel()
    {
        int afterSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (afterSceneIndex >= 0)
        {
            SceneManager.LoadScene(afterSceneIndex);
        };
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}