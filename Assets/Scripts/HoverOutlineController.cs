using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOutlineController : MonoBehaviour
{
    Outline outlineScript;

    // Start is called before the first frame update
    void Start()
    {
        outlineScript.enabled = false;
    }

    public void OutlineOn()
    {
        outlineScript.enabled = true;
    }

    public void OutlineOff()
    {
        outlineScript.enabled = false;
    }
}
