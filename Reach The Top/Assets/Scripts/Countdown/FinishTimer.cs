using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTimer : MonoBehaviour
{
    public ClimbTimer climb_timer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            climb_timer.StopClimbing();
        }
    }
}
