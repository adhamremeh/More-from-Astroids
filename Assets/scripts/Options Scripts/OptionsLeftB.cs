using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsLeftB : MonoBehaviour
{

    private float posx;
    private float posy;

    // Start is called before the first frame update
    void Awake()
    {
        posx = PlayerPrefs.GetFloat("LPOSX");
        posy = PlayerPrefs.GetFloat("LPOSY");
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
        PlayerPrefs.SetFloat("LPOSX", posx);
        PlayerPrefs.SetFloat("LPOSY", posy);
    }
}
