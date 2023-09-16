using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeScarecrow : MonoBehaviour
{

    public Transform scarecrowTransform;
    private float crowSpeed = 0f;

    private void OnTriggerEnter2D()
    {
        crowSpeed = -0.005f;
    }

    void Update()
    {
        scarecrowTransform.Translate(crowSpeed * Time.deltaTime, 0f, 0f);
    }
}
