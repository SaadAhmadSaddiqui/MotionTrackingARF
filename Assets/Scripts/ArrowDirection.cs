using UnityEngine;
using System.Collections;
using System;
// Attach this script to the camera that you want to follow the target
public class ArrowDirection : MonoBehaviour
{
    public Quaternion targetRot;
    public Transform arrow;
    private readonly float rotationSmoothingSpeed = 2.0f;

    void LateUpdate()
    {
        Vector3 targetEulerAngles = targetRot.eulerAngles;
        float rotationToApplyAroundY = targetEulerAngles.y ;
        float newCamRotAngleY = Mathf.LerpAngle(transform.eulerAngles.y,
        rotationToApplyAroundY, rotationSmoothingSpeed * Time.deltaTime);
        arrow.LookAt(arrow);
        
    }
}