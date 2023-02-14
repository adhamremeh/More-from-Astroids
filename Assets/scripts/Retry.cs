using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    public GameObject PAUSEING;

    public GameObject[] UII;

    public void Retry_v()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void Pause()
    {
        PAUSEING.SetActive(true);
        UII[0].SetActive(false);
        UII[1].SetActive(false);
        UII[2].SetActive(false);
        UII[3].SetActive(false);
        UII[4].SetActive(false);
        UII[5].SetActive(false);
        UII[6].SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        PAUSEING.SetActive(false);
        UII[0].SetActive(true);
        UII[1].SetActive(true);
        UII[2].SetActive(true);
        UII[3].SetActive(true);
        UII[4].SetActive(true);
        UII[5].SetActive(true);
        UII[6].SetActive(true);
    }

}
