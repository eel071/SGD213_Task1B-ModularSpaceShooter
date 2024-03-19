﻿using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float maxSpinSpeed = 200;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maxSpinSpeed, maxSpinSpeed);
    }
}
