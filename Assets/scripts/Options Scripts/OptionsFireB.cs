using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsFireB : MonoBehaviour
{

    private float posx;
       private float posy;

    // Start is called before the first frame update
    void Awake()
    {
        posx = PlayerPrefs.GetFloat("FPOSX");
        posy = PlayerPrefs.GetFloat("FPOSY");
        GetComponent<RectTransform>().anchoredPosition = new Vector2(posx, posy);
    }

    // Update is called once per frame
    void Update()
    {
        posx = GetComponent<RectTransform>().anchoredPosition.x;
        posy = GetComponent<RectTransform>().anchoredPosition.y;
    }

    public void SaveData()
    {
        PlayerPrefs.SetFloat("FPOSX", posx);
        PlayerPrefs.SetFloat("FPOSY", posy);
    }
}
