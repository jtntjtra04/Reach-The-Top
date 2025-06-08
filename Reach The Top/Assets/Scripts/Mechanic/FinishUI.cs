using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishUI : MonoBehaviour
{
    public GameObject finish_ui;
    public TextMeshProUGUI timer_text;
    public Button retry_button;
    public Button quit_button;
    public Transform player;
    public Transform start_point;
    //public Transform ui_anchor;

    private void Start()
    {
        finish_ui.SetActive(false);
    }
    public void ShowFinishUI(float final_time)
    {
        timer_text.text = "Time: " + final_time.ToString("F2") + "s";

        finish_ui.SetActive(true);
    }
    public void RetryGame()
    {
        finish_ui.SetActive(false);
        player.position = start_point.position;
        player.rotation = start_point.rotation;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
