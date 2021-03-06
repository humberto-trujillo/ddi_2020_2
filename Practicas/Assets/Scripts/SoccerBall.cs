﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : VoiceInteractable
{
    Rigidbody rb;
    public Vector3 kickDirection;
    public float kickForce = 30f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public override void VoiceInteract(string action)
    {
        base.VoiceInteract(action);
        Debug.Log("Pateando pelota...");
        if (action == "kick" && rb != null)
        {
            rb.AddForce(kickDirection * kickForce, ForceMode.Force);
        }
    }
}
