using System;
using UnityEngine;

public class CellEditUI : MonoBehaviour
{
    private static Canvas canvas;

    private void Awake()
    {
        canvas = this.gameObject.GetComponent<Canvas>();
    }
}