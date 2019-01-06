using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public AudioSource audioSource;

    private GameController gameController;
    private PlayerController1 playerController;


    //public GameObject pauseMenuUI;

    void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        audioSource = gameController.GetComponent<AudioSource>();
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController1>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && playerController != null)
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        //pauseMenuUI.SetActive(false);
        playerController.enabled = true;
        Time.timeScale = 1f;
        isPaused = false;
        audioSource.volume = 0.5f;
    }

    void Pause()
    {
        //pauseMenuUI.SetActive(true);
        playerController.enabled = false;
        Time.timeScale = 0f;
        isPaused = true;
        audioSource.volume = audioSource.volume/2;
    }
}
