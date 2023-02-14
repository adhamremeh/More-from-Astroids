using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class More : MonoBehaviour
{
    public void ClickHere()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.RedBread.ClickHere");
    }
    public void DodgeRoll()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.RedBread.DodgeRoll");
    }
    public void MoreFromDino()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.RedBread.MoreFromDinasour");
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
}
