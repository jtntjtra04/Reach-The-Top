using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClimbTimer : MonoBehaviour
{
    public TextMeshProUGUI countdown_text;
    private float climb_time = 0f;
    private bool is_climbing = false;

    private void Update()
    {
        if (is_climbing)
        {
            climb_time += Time.deltaTime;
            countdown_text.text = "Time: " + climb_time.ToString("F2") + "s";
        }
    }
    public void StartClimbing()
    {
        is_climbing = true;
        climb_time = 0f;
        countdown_text.gameObject.SetActive(true);
    }
    public void StopClimbing()
    {
        is_climbing = false;
    }
}
