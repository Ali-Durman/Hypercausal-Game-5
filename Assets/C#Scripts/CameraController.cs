using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Target;
    public Vector3 offset;
    public float CameraSpeed = 0.125f;
    void FixedUpdate()
    {
        Vector3 desiredPos = Target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, CameraSpeed);
        transform.position = smoothedPos;
    }
}
