using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text score;
    public int score_int;
    public static int FirstTime;

    public GameObject FirstButton;

    public Camera cam;
    public GameObject EDGE;

    public GameObject right1;
    public GameObject right2;
    public GameObject right3;

    public GameObject left1;
    public GameObject left2;
    public GameObject left3;

    public GameObject up1;
    public GameObject up2;
    public GameObject up3;

    public GameObject down1;
    public GameObject down2;
    public GameObject down3;

    public GameObject Triple;
    public GameObject Shield;
    public GameObject MarioStar;

    public GameObject ART;
    public GameObject ENT;

    public GameObject Paused;
    public Sprite oldP;
    public Sprite newP;

    public GameObject Retry;
    public Sprite oldR;
    public Sprite newR;

    public GameObject MenuB;
    public Sprite oldM;
    public Sprite newM;

    public GameObject Loser;
    public Sprite oldL;
    public Sprite newL;

    public Text HI;
    public static int HI_int;

    private void Awake()
    {        
        if (Menu.Language == 1)
        {
            Paused.GetComponent<Image>().sprite = newP;
            Retry.GetComponent<Image>().sprite = newR;
            MenuB.GetComponent<Image>().sprite = newM;
            Loser.GetComponent<Image>().sprite = newL;
            ART.SetActive(true);
            ENT.SetActive(false);
        }
        else if (Menu.Language == 0)
        {
            ART.SetActive(false);
            ENT.SetActive(true);
            Paused.GetComponent<Image>().sprite = oldP;
            Retry.GetComponent<Image>().sprite = oldR;
            MenuB.GetComponent<Image>().sprite = oldM;
            Loser.GetComponent<Image>().sprite = oldL;
        }

        #region Abilities
        if (HI_int >= 1000)
        {
            Triple.SetActive(true);
        }
        else if (HI_int >= 2000)
        {
            Shield.SetActive(true);
        }
        else if (HI_int >= 3000)
        {
            MarioStar.SetActive(true);
        }
        #endregion

        if (FirstTime == 1)
        {
            ART.SetActive(false);
            ENT.SetActive(false);
            FirstButton.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
        }
        HI.text = HI_int.ToString();
    }

    private void Update()
    {
        if (score_int >= 1000 && score_int < 2000)
        {
            right1.transform.position = new Vector3(right1.transform.position.x, right1.transform.position.y, right1.transform.position.z);
            right2.transform.position = new Vector3(right2.transform.position.x, right2.transform.position.y, right2.transform.position.z);
            right3.transform.position = new Vector3(right3.transform.position.x, right3.transform.position.y, right3.transform.position.z);

            left1.transform.position = new Vector3(left1.transform.position.x, left1.transform.position.y, left1.transform.position.z);
            left2.transform.position = new Vector3(left2.transform.position.x, left2.transform.position.y, left2.transform.position.z);
            left3.transform.position = new Vector3(left3.transform.position.x, left3.transform.position.y, left3.transform.position.z);

            up1.transform.position = new Vector3(up1.transform.position.x, up1.transform.position.y, up1.transform.position.z);
            up2.transform.position = new Vector3(up2.transform.position.x, up2.transform.position.y, up2.transform.position.z);
            up3.transform.position = new Vector3(up3.transform.position.x, up3.transform.position.y, up3.transform.position.z);

            down1.transform.position = new Vector3(down1.transform.position.x, down1.transform.position.y, down1.transform.position.z);
            down2.transform.position = new Vector3(down2.transform.position.x, down2.transform.position.y, down2.transform.position.z);
            down3.transform.position = new Vector3(down3.transform.position.x, down3.transform.position.y, down3.transform.position.z);

            cam.GetComponent<Camera>().orthographicSize -= 0.1f;
            if (cam.GetComponent<Camera>().orthographicSize <= 9)
            {
                cam.GetComponent<Camera>().orthographicSize = 9;
            }
        }
        if (score_int >= 2000 && score_int < 3000)
        {
            right1.transform.position = new Vector3(right1.transform.position.x, right1.transform.position.y, right1.transform.position.z);
            right2.transform.position = new Vector3(right2.transform.position.x, right2.transform.position.y, right2.transform.position.z);
            right3.transform.position = new Vector3(right3.transform.position.x, right3.transform.position.y, right3.transform.position.z);

            left1.transform.position = new Vector3(left1.transform.position.x, left1.transform.position.y, left1.transform.position.z);
            left2.transform.position = new Vector3(left2.transform.position.x, left2.transform.position.y, left2.transform.position.z);
            left3.transform.position = new Vector3(left3.transform.position.x, left3.transform.position.y, left3.transform.position.z);

            up1.transform.position = new Vector3(up1.transform.position.x, up1.transform.position.y, up1.transform.position.z);
            up2.transform.position = new Vector3(up2.transform.position.x, up2.transform.position.y, up2.transform.position.z);
            up3.transform.position = new Vector3(up3.transform.position.x, up3.transform.position.y, up3.transform.position.z);

            down1.transform.position = new Vector3(down1.transform.position.x, down1.transform.position.y, down1.transform.position.z);
            down2.transform.position = new Vector3(down2.transform.position.x, down2.transform.position.y, down2.transform.position.z);
            down3.transform.position = new Vector3(down3.transform.position.x, down3.transform.position.y, down3.transform.position.z);


            cam.GetComponent<Camera>().orthographicSize -= 0.1f;
            if (cam.GetComponent<Camera>().orthographicSize <= 7)
            {
                cam.GetComponent<Camera>().orthographicSize = 7;
            }
        }
        if (score_int >= 3000)
        {
            right1.transform.position = new Vector3(right1.transform.position.x, right1.transform.position.y, right1.transform.position.z);
            right2.transform.position = new Vector3(right2.transform.position.x, right2.transform.position.y, right2.transform.position.z);
            right3.transform.position = new Vector3(right3.transform.position.x, right3.transform.position.y, right3.transform.position.z);

            left1.transform.position = new Vector3(left1.transform.position.x, left1.transform.position.y, left1.transform.position.z);
            left2.transform.position = new Vector3(left2.transform.position.x, left2.transform.position.y, left2.transform.position.z);
            left3.transform.position = new Vector3(left3.transform.position.x, left3.transform.position.y, left3.transform.position.z);

            up1.transform.position = new Vector3(up1.transform.position.x, up1.transform.position.y, up1.transform.position.z);
            up2.transform.position = new Vector3(up2.transform.position.x, up2.transform.position.y, up2.transform.position.z);
            up3.transform.position = new Vector3(up3.transform.position.x, up3.transform.position.y, up3.transform.position.z);

            down1.transform.position = new Vector3(down1.transform.position.x, down1.transform.position.y, down1.transform.position.z);
            down2.transform.position = new Vector3(down2.transform.position.x, down2.transform.position.y, down2.transform.position.z);
            down3.transform.position = new Vector3(down3.transform.position.x, down3.transform.position.y, down3.transform.position.z);
    
            cam.GetComponent<Camera>().orthographicSize -= 0.1f;
            if (cam.GetComponent<Camera>().orthographicSize <= 5)
            {
                cam.GetComponent<Camera>().orthographicSize = 5;
            }
        }

    }

    public void IncScore_big()
    {
        score_int += 10;
        score.text = score_int.ToString();
        if (HI_int <= score_int)
        {
            HI_int = score_int;
            HI.text = HI_int.ToString();
        }
    }
    public void IncScore_small()
    {
        score_int += 5;
        score.text = score_int.ToString();
        if (HI_int <= score_int)
        {
            HI_int = score_int;
            HI.text = HI_int.ToString();
        }
    }

    public void FirstTime_v()
    {
        FirstTime = 0;
        Time.timeScale = 1;
        FirstButton.SetActive(false);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("HI", HI_int);
    }
}
