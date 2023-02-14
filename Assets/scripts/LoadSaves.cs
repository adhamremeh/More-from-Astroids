using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSaves : MonoBehaviour
{

    private int FirstTime;

    // Start is called before the first frame update
    void Start()
    {
        FirstTime = PlayerPrefs.GetInt("FirstT");
        if (FirstTime == 0)
        {
            PlayerPrefs.SetFloat("FPOSX", -212.4f);
            PlayerPrefs.SetFloat("FPOSY", 443f);
            PlayerPrefs.SetFloat("LPOSX", -421f);
            PlayerPrefs.SetFloat("LPOSY", 268.1f);
            PlayerPrefs.SetFloat("RPOSX", -174f);
            PlayerPrefs.SetFloat("RPOSY", 181f);
            PlayerPrefs.SetFloat("FIPOSX", 329f);
            PlayerPrefs.SetFloat("FIPOSY", 276.8f);
            PlayerPrefs.SetInt("FirstT", 1);
        }
        Menu.Language = PlayerPrefs.GetInt("Langauge");
        Score.HI_int = PlayerPrefs.GetInt("HI");
        Shop.Player = PlayerPrefs.GetInt("Player");
        SceneManager.LoadScene(1);
    }

}
