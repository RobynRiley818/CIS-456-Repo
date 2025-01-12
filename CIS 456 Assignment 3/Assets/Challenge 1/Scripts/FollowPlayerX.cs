﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Robyn Riley
* FollowPlayerX.cs
* Assignment 3
* This script is what keeps the plane moving.
*/

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(30, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
