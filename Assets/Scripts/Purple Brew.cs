using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class PurpleBrew : MonoBehaviour
{
    public Material purple;
    public Material green;
    private Material CurrentColor;
    public void ChangeColor()
    {
        Color();
    }

    private void Color()
    {
        CurrentColor = GetComponent<Material>();

        if (CurrentColor == purple)
        {
            // set color to green
        }
        else 
        {
            // set color to purple
        }
    }
}
