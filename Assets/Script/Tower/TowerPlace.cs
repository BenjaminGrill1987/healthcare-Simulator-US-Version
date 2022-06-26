using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    private Color startColor;
    private Renderer renderer;
    private bool isClicked = false;
    private bool isFree = true;

    private void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        startColor = renderer.material.color;
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        renderer.material.color = startColor;
    }

    private void OnMouseDown()
    {
        renderer.material.color = Color.red;
    }

    public void TowerIsBuild()
    {
        isFree = false;
        renderer.material.color = startColor;
    }
}