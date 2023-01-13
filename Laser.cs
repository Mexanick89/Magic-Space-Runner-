using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float life = 3;

    private void Awake()
    {
        Destroy(gameObject, life);
    }
      private void OnCollisionEnter(Collision collision)
      {
         Destroy(collision.gameObject);
         Destroy(gameObject);
      }



}
