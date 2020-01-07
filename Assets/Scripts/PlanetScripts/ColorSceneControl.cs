using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSceneControl : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer backGroundPicture;

    public void SetColor(Color newColor)
    {
        if (backGroundPicture)  backGroundPicture.color = newColor;
    }

    public void Add(SpriteRenderer bgRenderer)
    {
        backGroundPicture = bgRenderer;
    }
}
