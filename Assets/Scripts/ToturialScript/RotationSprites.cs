using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSprites : MonoBehaviour
{
    private void Update()
    {
        RotateObj();
    }

    private void RotateObj()
    {
        transform.Rotate(new Vector3(0, 0, 5));
    }
}
