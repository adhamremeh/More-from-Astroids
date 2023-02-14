using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Text HI;

    private float speed = 80;
    private int turn;

    public static int Player;

    public GameObject BACK;

    public Sprite newSprite;
    public Sprite oldSprite;

    public GameObject Equip_P1;
    public GameObject Equip_P2;
    public GameObject Equip_P3;
    public GameObject Equip_P4;

    public GameObject Equiped_P1;
    public GameObject Equiped_A1;
    public GameObject Equiped_P2;
    public GameObject Equiped_A2;
    public GameObject Equiped_P3;
    public GameObject Equiped_A3;
    public GameObject Equiped_P4;

    public Sprite newSprite_P1_Equip;
    public Sprite oldSprite_P1_Equip;
    public Sprite newSprite_P1_Equiped;
    public Sprite oldSprite_P1_Equiped;

    public GameObject Lock2;
    public GameObject Lock3;
    public GameObject Lock4;
    public GameObject Lock5;
    public GameObject Lock6;
    public GameObject Lock7;

    private int Shop_HIscore;

    private void Awake()
    {
        #region start selection
        if (Player == 0 && Shop_HIscore >= 0)
        {
            Equip_P1.SetActive(false);
            Equip_P2.SetActive(true);
            Equip_P3.SetActive(true);
            Equip_P4.SetActive(true);

            Equiped_P1.SetActive(true);
            Equiped_A1.SetActive(false);
            Equiped_P2.SetActive(false);
            Equiped_A2.SetActive(false);
            Equiped_P3.SetActive(false);
            Equiped_A3.SetActive(false);
            Equiped_P4.SetActive(false);
        }
        else if (Player == 2 && Shop_HIscore >= 150)
        {
            Equip_P1.SetActive(true);
            Equip_P2.SetActive(false);
            Equip_P3.SetActive(true);
            Equip_P4.SetActive(true);

            Equiped_P1.SetActive(false);
            Equiped_A1.SetActive(false);
            Equiped_P2.SetActive(true);
            Equiped_A2.SetActive(false);
            Equiped_P3.SetActive(false);
            Equiped_A3.SetActive(false);
            Equiped_P4.SetActive(false);
        }
        else if (Player == 3 && Shop_HIscore >= 250)
        {
            Equip_P1.SetActive(true);
            Equip_P2.SetActive(true);
            Equip_P3.SetActive(false);
            Equip_P4.SetActive(true);

            Equiped_P1.SetActive(false);
            Equiped_A1.SetActive(false);
            Equiped_P2.SetActive(false);
            Equiped_A2.SetActive(false);
            Equiped_P3.SetActive(true);
            Equiped_A3.SetActive(false);
            Equiped_P4.SetActive(false);
        }
        else if (Player == 4 && Shop_HIscore >= 350)
        {
            Equip_P1.SetActive(true);
            Equip_P2.SetActive(true);
            Equip_P3.SetActive(true);
            Equip_P4.SetActive(false);

            Equiped_P1.SetActive(false);
            Equiped_A1.SetActive(false);
            Equiped_P2.SetActive(false);
            Equiped_A2.SetActive(false);
            Equiped_P3.SetActive(false);
            Equiped_A3.SetActive(false);
            Equiped_P4.SetActive(true);
        }
        #endregion

        if (Menu.Language == 1)
        {
            BACK.GetComponent<Image>().sprite = newSprite;
            Equip_P1.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equip;
            Equip_P2.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equip;
            Equip_P3.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equip;
            Equip_P4.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equip;

            Equiped_P1.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equiped;
            Equiped_A1.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equiped;
            Equiped_P2.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equiped;
            Equiped_A2.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equiped;
            Equiped_P3.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equiped;
            Equiped_A3.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equiped;
            Equiped_P4.GetComponent<SpriteRenderer>().sprite = newSprite_P1_Equiped;
        }
        else if (Menu.Language == 0)
        {
            BACK.GetComponent<Image>().sprite = oldSprite;

            Equip_P1.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equip;
            Equip_P2.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equip;
            Equip_P3.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equip;
            Equip_P4.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equip;

            Equiped_P1.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equiped;
            Equiped_A1.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equiped;
            Equiped_P2.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equiped;
            Equiped_A2.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equiped;
            Equiped_P3.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equiped;
            Equiped_A3.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equiped;
            Equiped_P4.GetComponent<SpriteRenderer>().sprite = oldSprite_P1_Equiped;
        }

        #region lock ifs
        if (Score.HI_int >= 1000)
        {
            Lock2.SetActive(false);
            Equiped_A1.SetActive(true);
        }
        if (Score.HI_int >= 1500)
        {
            Lock3.SetActive(false);
        }
        if (Score.HI_int >= 2000)
        {
            Lock4.SetActive(false);
            Equiped_A2.SetActive(true);
        }
        if (Score.HI_int >= 2500)
        {
            Lock5.SetActive(false);
        }
        if (Score.HI_int >= 3000)
        {
            Lock6.SetActive(false);
            Equiped_A3.SetActive(true);
        }
        if (Score.HI_int >= 3500)
        {
            Lock7.SetActive(false);
        }
        #endregion

        Shop_HIscore = Score.HI_int;

    }

    // Update is called once per frame
    void Update()
    {
        HI.text = Score.HI_int.ToString();

        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D coll_P1 = Equip_P1.GetComponent<Collider2D>();
        Collider2D coll_P2 = Equip_P2.GetComponent<Collider2D>();
        Collider2D coll_P3 = Equip_P3.GetComponent<Collider2D>();
        Collider2D coll_P4 = Equip_P4.GetComponent<Collider2D>();

        if (coll_P1.OverlapPoint(wp))
        {
            Equip_P1_v();
        }
        else if (coll_P2.OverlapPoint(wp))
        {
            Equip_P2_v();
        }
        else if (coll_P3.OverlapPoint(wp))
        { 
            Equip_P3_v();
        }
        else if (coll_P4.OverlapPoint(wp))
        {
            Equip_P4_v();
        }

        if (turn == 1)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            if (transform.position.x > -91 && transform.position.x < -89)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-90, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -76 && transform.position.x < -74)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-75, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -61 && transform.position.x < -59)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-60, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -46 && transform.position.x < -44)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-45, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -31 && transform.position.x < -29)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-30, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -16 && transform.position.x < -14)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-15, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x <= -91)
            {
                Vector2 pos = new Vector2(-90, transform.position.y);
                transform.position = pos;

            }

        }
        if (turn == -1)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            if (transform.position.x > -196 && transform.position.x < -194)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-195, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -181 && transform.position.x < -179)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-180, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -166 && transform.position.x < -164)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-165, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -151 && transform.position.x < -149)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-150, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -136 && transform.position.x < -134)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-135, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -121 && transform.position.x < -119)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-120, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -106 && transform.position.x < -104)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-105, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -91 && transform.position.x < -89)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-90, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -76 && transform.position.x < -74)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-75, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -61 && transform.position.x < -59)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-60, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -46 && transform.position.x < -44)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-45, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -31 && transform.position.x < -29)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-30, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x > -16 && transform.position.x < -14)
            {
                turn = 0;
                speed = 0;
                Vector2 pos = new Vector2(-15, transform.position.y);
                transform.position = pos;
            }
            if (transform.position.x >= 0)
            {
                Vector2 pos = new Vector2(0, transform.position.y);
                transform.position = pos;

            }


        }
    }

    public void right_b()
    {
        turn = 1;
        speed = 80;
    }
    public void left_b()
    {
        turn = -1;
        speed = 80;
    }
    public void Menu_v()
    {
        SceneManager.LoadScene(1);
    }

    public void Equip_P1_v()
    {
        if (Shop_HIscore >= 0)
        {
            Player = 0;
            Equip_P1.SetActive(false);
            Equip_P2.SetActive(true);
            Equip_P3.SetActive(true);
            Equip_P4.SetActive(true);

            Equiped_P1.SetActive(true);
            Equiped_P2.SetActive(false);
            Equiped_P3.SetActive(false);
            Equiped_P4.SetActive(false);
        }
    }
    public void Equip_P2_v()
    {
        if (Shop_HIscore >= 1500)
        {
            Player = 2;
            Equip_P1.SetActive(true);
            Equip_P2.SetActive(false);
            Equip_P3.SetActive(true);
            Equip_P4.SetActive(true);

            Equiped_P1.SetActive(false);
            Equiped_P2.SetActive(true);
            Equiped_P3.SetActive(false);
            Equiped_P4.SetActive(false);
        }
    }
    public void Equip_P3_v()
    {
        if (Shop_HIscore >= 2500)
        {
            Player = 3;
            Equip_P1.SetActive(true);
            Equip_P2.SetActive(true);
            Equip_P3.SetActive(false);
            Equip_P4.SetActive(true);

            Equiped_P1.SetActive(false);
            Equiped_P2.SetActive(false);
            Equiped_P3.SetActive(true);
            Equiped_P4.SetActive(false);
        }
    }
    public void Equip_P4_v()
    {
        if (Shop_HIscore >= 3500)
        {
            Player = 4;
            Equip_P1.SetActive(true);
            Equip_P2.SetActive(true);
            Equip_P3.SetActive(true);
            Equip_P4.SetActive(false);

            Equiped_P1.SetActive(false);
            Equiped_P2.SetActive(false);
            Equiped_P3.SetActive(false);
            Equiped_P4.SetActive(true);
        }
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("Player", Player);
    }

}
