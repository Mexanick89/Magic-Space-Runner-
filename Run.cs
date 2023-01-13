using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float speed = 3;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
