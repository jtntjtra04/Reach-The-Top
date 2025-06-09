using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class ClimbTimer : MonoBehaviour
{
    public TextMeshProUGUI countdown_text;
    private float climb_time = 0f;
    private bool is_climbing = false;

    // References
    public FinishUI ui_manager;
    public DynamicMoveProvider move_provider;
    private void Start()
    {
        countdown_text.gameObject.SetActive(false);
    }

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
        if (!is_climbing)
        {
            Debug.Log("timer starts");
            is_climbing = true;
            climb_time = 0f;
            countdown_text.gameObject.SetActive(true);
        }
    }
    public void StopClimbing()
    {
        StartCoroutine(ShowResultTimer(3f));
    }
    private IEnumerator ShowResultTimer(float time)
    {
        if (is_climbing)
        {
            is_climbing = false;
            countdown_text.gameObject.SetActive(false);
            // Lock Movement
            if (move_provider != null)
            {
                move_provider.enabled = false;
            }
        }
        yield return new WaitForSeconds(time);
        ui_manager.ShowFinishUI(climb_time);
    }
}
