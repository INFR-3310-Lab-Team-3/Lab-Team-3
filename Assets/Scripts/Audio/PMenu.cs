using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class PMenu : MonoBehaviour
{
    public GameObject pausePanel;
    bool paused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            Pause();
            Cursor.lockState = CursorLockMode.None;
            Debug.Log("Working");
            paused = true;
        } else if(Input.GetKeyDown(KeyCode.P) && paused == true)
        {
            Continue();
            Cursor.lockState = CursorLockMode.Locked;
            paused = false;
        }
    }
    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
