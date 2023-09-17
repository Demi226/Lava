using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeScarecrow : MonoBehaviour
{
    public Transform scarecrowTrigger, playerTransform;
    public Transform scarecrowTransform;
    private float crowSpeed = 0f;
    private float time = 100;


    void Update()
    {
        if( playerTransform.localPosition.x > scarecrowTrigger.localPosition.x)
        {
            crowSpeed = -0.05f;
            time--;
        }
        if(time < 0){
            Destroy(this.gameObject);
        }

        scarecrowTransform.Translate(crowSpeed, 0f, 0f);
    }
}
