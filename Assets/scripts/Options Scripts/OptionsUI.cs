using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsUI : MonoBehaviour
{
    public GameObject BACK;
    public GameObject Save;
    public GameObject Float;
    public GameObject Fixed;

    public Sprite newSpriteB;
    public Sprite oldSpriteB;

    public Sprite newSpriteS;
    public Sprite oldSpriteS;

    public Sprite newSpriteF;
    public Sprite oldSpriteF;

    public Sprite newSpriteFI;
    public Sprite oldSpriteFI;

    private int F_or_FI;

    public GameObject Fjoy;
    public GameObject FIjoy;

    private float posx;
    private float posy;

    public Sprite newSpriteFjoy;
    public Sprite oldSpriteFjoy;

    void Awake()
    {
        F_or_FI = PlayerPrefs.GetInt("F_OR_FI");
        FIjoy.GetComponent<RectTransform>().anchoredPosition = new Vector2(329, 276.8f);
    }
    // Start is called before the first frame update
    void Start()
    {

        if (Menu.Language == 1)
        {
            BACK.GetComponent<Image>().sprite = newSpriteB;
            Save.GetComponent<Image>().sprite = newSpriteS;
            Float.GetComponent<Image>().sprite = newSpriteF;
            Fixed.GetComponent<Image>().sprite = newSpriteFI;
            Fjoy.GetComponent<SpriteRenderer>().sprite = newSpriteFjoy;
        }
        else if (Menu.Language == 0)
        {
            BACK.GetComponent<Image>().sprite = oldSpriteB;
            Save.GetComponent<Image>().sprite = oldSpriteS;
            Float.GetComponent<Image>().sprite = oldSpriteF;
            Fixed.GetComponent<Image>().sprite = oldSpriteFI;
            Fjoy.GetComponent<SpriteRenderer>().sprite = oldSpriteFjoy;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (F_or_FI == 0)
        {
            Fjoy.SetActive(true);
            FIjoy.SetActive(false);
        }
        else
        {
            Fjoy.SetActive(false);
            FIjoy.SetActive(true);
        }

        posx = FIjoy.GetComponent<RectTransform>().anchoredPosition.x;
        posy = FIjoy.GetComponent<RectTransform>().anchoredPosition.y;
    }

    public void Back()
    {
        SceneManager.LoadScene(1);
    }

    public void Floaat()
    {
        F_or_FI = 0;
    }
    public void Fixeed()
    {
        F_or_FI = 1;
    }

    public void SAVE()
    {
        PlayerPrefs.SetFloat("FIPOSX", posx);
        PlayerPrefs.SetFloat("FIPOSY", posy);
        PlayerPrefs.SetInt("F_OR_FI", F_or_FI);
    }

}
