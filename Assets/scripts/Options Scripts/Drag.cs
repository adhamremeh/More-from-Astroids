using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

    private bool selected;

    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            Vector2 tPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(tPos.x, tPos.y);
        }

        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
        }
    }
}
