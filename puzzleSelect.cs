using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class puzzleSelect : MonoBehaviour
{
    public void SetPuzzlesPhoto(Image Photo)
    {
        for (int i = 0;1 < 36; i++)
        {
            GameObject.Find("Piece (" + i + ")").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
    }

}

