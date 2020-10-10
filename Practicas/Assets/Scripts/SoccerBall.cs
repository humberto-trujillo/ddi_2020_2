using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : Interactable
{
    Rigidbody rb;
    public Vector3 kickDirection;
    public float kickForce = 30f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Pateando pelota...");
        if (rb != null)
        {
            rb.AddForce(kickDirection * kickForce, ForceMode.Force);
        }
    }
}
