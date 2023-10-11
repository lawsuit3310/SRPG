using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClickableObjectBase : MonoBehaviour
{
    // Update is called once per frame
    public abstract void Action();

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            // do something
            Action();
        }
    }
}
