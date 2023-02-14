using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject AR;
    public GameObject EN;
    public static int Language = 0;

    public GameObject PLAY_b;
    public GameObject Unlock_b;
    public GameObject Exit_b;
    public GameObject TitleAR;
    public GameObject TitleEN;

    public Sprite newPlay;
    public Sprite newUnlock;
    public Sprite newExit;

    public Sprite oldPlay;
    public Sprite oldUnlock;
    public Sprite oldExit;

    private void Update()
    {
        if(Language == 1)
        {
            PLAY_b.GetComponent<Image>().sprite = newPlay;
            Unlock_b.GetComponent<Image>().sprite = newUnlock;
            Exit_b.GetComponent<Image>().sprite = newExit;
            TitleAR.SetActive(true);
            TitleEN.SetActive(false);
        }
        else if(Language == 0)
        {
            PLAY_b.GetComponent<Image>().sprite = oldPlay;
            Unlock_b.GetComponent<Image>().sprite = oldUnlock;
            Exit_b.GetComponent<Image>().sprite = oldExit;
            TitleAR.SetActive(false);
            TitleEN.SetActive(true);
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(2);
    }
    public void Unlock()
    {
        SceneManager.LoadScene(3);
    }

    public void Options()
    {
        SceneManager.LoadScene(4);
    }
    public void more()
    {
        SceneManager.LoadScene(5);
    }


    public void Exit()
    {
        Application.Quit();
    }
    public void AR_v()
    {
        AR.SetActive(false);
        EN.SetActive(true);
        Language = 1;
    }
    public void EN_v()
    {
        AR.SetActive(true);
        EN.SetActive(false);
        Language = 0;
    }
    private void OnDisable()
    {
        PlayerPrefs.SetInt("Language", Language);
    }
}
