using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ImageRot : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!PuzzleLogic.youWin)
        {
            transform.Rotate(0, 0, 90f);
        }
    }
}