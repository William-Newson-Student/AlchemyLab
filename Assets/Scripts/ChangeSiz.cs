using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSiz : MonoBehaviour
{
    private float modifiedScale = 2f;
    private float changeRate = 50f;
    private Vector3 initialScale;
    private bool isSacled = false;

    void Start()
    {
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, GetTargetScale(), changeRate * Time.deltaTime);
    }
    private Vector3 GetTargetScale()
    {
        return isSacled ? Vector3.one * modifiedScale : initialScale;
    }

    public void toggleScale()
    {
        isSacled = !isSacled;
    }
}
