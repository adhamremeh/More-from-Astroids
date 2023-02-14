using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBpos : MonoBehaviour
{

    public GameObject Fire;
    private float posxF;
    private float posyF;

    public GameObject Left;
    private float posxL;
    private float posyL;

    public GameObject Right;
    private float posxR;
    private float posyR;

    public GameObject Fjoy;

    public GameObject FIjoy;
    private float posxFi;
    private float posyFi;

    public static int F_OR_FI;

    // Start is called before the first frame update
    private void Awake()
    {
        F_OR_FI = PlayerPrefs.GetInt("F_OR_FI");
        if (F_OR_FI == 0)
        {
            Fjoy.SetActive(true);
            FIjoy.SetActive(false);
        }
        else
        {
            Fjoy.SetActive(false);
            FIjoy.SetActive(true);
            posxFi = PlayerPrefs.GetFloat("FIPOSX");
            posyFi = PlayerPrefs.GetFloat("FIPOSY");
            FIjoy.GetComponent<RectTransform>().anchoredPosition = new Vector2(posxFi, posyFi);
        }
        posxF = PlayerPrefs.GetFloat("FPOSX");
        posyF = PlayerPrefs.GetFloat("FPOSY");
        Fire.GetComponent<RectTransform>().anchoredPosition = new Vector2(posxF, posyF);

        posxL = PlayerPrefs.GetFloat("LPOSX");
        posyL = PlayerPrefs.GetFloat("LPOSY");
        Left.GetComponent<RectTransform>().anchoredPosition = new Vector2(posxL, posyL);

        posxR = PlayerPrefs.GetFloat("RPOSX");
        posyR = PlayerPrefs.GetFloat("RPOSY");
        Right.GetComponent<RectTransform>().anchoredPosition = new Vector2(posxR, posyR);
    }

}
