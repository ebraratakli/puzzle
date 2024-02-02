using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class PuzzleLogic : MonoBehaviour
{
    public GameObject[] pictures;
    public int picNum, i;
    public static bool youWin = false;
    public PlayableDirector timelineDirector;
    public GameObject time, counter, nextLevel;

    void Start()
    {
        youWin = false;

        for (i = 0; i < picNum; i++)
        {
            float randomRotation = Random.Range(0, 4) * 90f;
            pictures[i].transform.rotation = Quaternion.Euler(0, 0, randomRotation);
            pictures[i].AddComponent<BoxCollider2D>();
        }
    }

    void Update()
    {
        CheckWinCondition();
    }

    void CheckWinCondition()
    {
        bool allRotationsZero = true;

        for (int i = 0; i < picNum; i++)
        {
            if (pictures[i].transform.rotation.eulerAngles != Vector3.zero)
            {
                allRotationsZero = false;
                break;
            }
        }

        if (allRotationsZero)
        {
            youWin = true;
            timelineDirector.Play();
            nextLevel.SetActive(true);
            Destroy(time);
            Destroy(counter);

        }
    }
}