using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScenesManager : MonoBehaviour {

    public static ScenesManager Instance;
    public AudioClip winClip;
    public AudioClip loseClip;
    AudioSource audioSource;

    public static bool isPause = false;
    public GameObject pauseMenu;

    public Slider loadingBar;
    public GameObject homeMenu;
    public GameObject loadingScreen;

    public GameObject winScreen;
    public GameObject win;
    public GameObject lose;

    AsyncOperation async;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Gameplay()
    {
       StartCoroutine(GoToGame());
    }

    IEnumerator GoToGame()
    {
        loadingScreen.SetActive(true);
        homeMenu.SetActive(false);
        async = SceneManager.LoadSceneAsync(1);
        async.allowSceneActivation = false;

        gameObject.GetComponent<AudioSource>().Pause();

        while (async.isDone == false)
        {
            loadingBar.value = async.progress;
            if(async.progress == 0.9f)
            {
                loadingBar.value = 1f;
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gameObject.GetComponent<AudioSource>().Play();
        isPause = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gameObject.GetComponent<AudioSource>().Pause();
        isPause = true;
    }

    public void WinScene()
    {
        winScreen.SetActive(true);
        audioSource.PlayOneShot(winClip);
        win.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }

    public void LoseScene()
    {
        winScreen.SetActive(true);
        audioSource.PlayOneShot(loseClip);
        lose.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }
}
