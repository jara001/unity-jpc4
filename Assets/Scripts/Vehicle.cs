using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Speed
    float _speed;
    public float Speed
    {
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("Vehicle speed cannot be negative.");
            } else
            {
                _speed = value;
            }
        }
    }
}
