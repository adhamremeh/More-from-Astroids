using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Animator CameraAnim;
    private Animator PlayerAnim;
    private Animator Hearts;

    public Joystick movejoystick;
    public Joystick movejoystickFI;

    public GameObject bullet;
    public GameObject bulletpos;
    public GameObject bulletposR;
    public GameObject bulletposL;
    public GameObject muzzlepos;
    public GameObject muzzleposR;
    public GameObject muzzleposL;
    public GameObject explosion;
    public GameObject MuzzleFlash;
    public GameObject deathPanle;
    public GameObject LOSER;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject HeartOB;

    private float nextfire = 0.0f;
    private float horizontalmove = 0f;
    private float verticalmove = 0f;
    public float speed;
    public float firerate = 0.5f;

    private readonly int rotation = 0;
    public int health = 3;
    public int rotationscalar;

    private bool left;
    private bool right;
    private bool firing;
    private bool Triple;
    private bool shield;
    public static bool star;

    private Rigidbody2D rb;
    private SpriteRenderer SPR;

    public Sprite P1;
    public Sprite P2;
    public Sprite P3;
    public Sprite P4;

    private int deathtime;

    public GameObject Vid;

    public GameObject shielddd;

    public static  int ad_normal;

    void Start()
    {
        star = false;

        Hearts = HeartOB.GetComponent<Animator>();
        PlayerAnim = GetComponent<Animator>();
        CameraAnim = GameObject.Find("Camera").GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        SPR = GetComponent<SpriteRenderer>();

        if (deathtime > 0)
        {
            deathtime = 0;
            Vid.SetActive(true);
        }

        #region player selection

        if (Shop.Player == 0)
        {
            SPR.sprite = P1;
        }
        else if (Shop.Player == 2)
        {
            SPR.sprite = P2;
        }
        else if (Shop.Player == 3)
        {
            SPR.sprite = P3;
        }
        else if (Shop.Player == 4)
        {
            SPR.sprite = P4;
        }

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        if (ad_normal >= 15)
        {
            //ADmanager.normal();
            ad_normal = 0;
        }
        if (deathtime > 0)
        {
            Vid.SetActive(false);
        }

        if (CustomBpos.F_OR_FI == 0)
        {
            horizontalmove = movejoystick.Horizontal * speed;
            verticalmove = movejoystick.Vertical * speed;
        }
        else
        {
            horizontalmove = movejoystickFI.Horizontal * speed;
            verticalmove = movejoystickFI.Vertical * speed;
        }
        rb.velocity = new Vector2(horizontalmove, verticalmove);

        if (health == 2)
        {
            Destroy(heart1);
        }
        else if (health == 1)
        {
            Destroy(heart2);
        }

        if (left)
        {
            transform.Rotate(0, 0, rotation + rotationscalar);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }
        if (right)
        {
            transform.Rotate(0, 0, rotation - rotationscalar);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }
        if (firing && Time.time > nextfire && Triple == false)
        {
            FindObjectOfType<AudioManager>().playsound("Fire");
            nextfire = Time.time + firerate;
            Instantiate(bullet, bulletpos.transform.position, bulletpos.transform.rotation);
            Instantiate(MuzzleFlash, muzzlepos.transform.position, muzzlepos.transform.rotation); ;
        }
        else if (firing && Time.time > nextfire && Triple == true)
        {
            FindObjectOfType<AudioManager>().playsound("Fire");
            nextfire = Time.time + firerate;
            Instantiate(bullet, bulletpos.transform.position, bulletpos.transform.rotation);
            Instantiate(bullet, bulletpos.transform.position, bulletposR.transform.rotation);
            Instantiate(bullet, bulletpos.transform.position, bulletposL.transform.rotation);
            Instantiate(MuzzleFlash, muzzlepos.transform.position, muzzlepos.transform.rotation);
            Instantiate(MuzzleFlash, muzzlepos.transform.position, muzzleposR.transform.rotation);
            Instantiate(MuzzleFlash, muzzlepos.transform.position, muzzleposL.transform.rotation);
        }

        if (health <= 0)
        {
            FindObjectOfType<AudioManager>().playsound("PlayerExplosion");
            heart3.SetActive(false);
            gameObject.SetActive(false);
            deathtime++;
            LOSER.SetActive(true); 
            Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            deathPanle.SetActive(true);
        }

        if (!shield)
        {
            shielddd.SetActive(false);
        }

        if (star)
        {
            gameObject.tag = "staritself";
        }
        else
        {
            gameObject.tag = "Player";
        }

    }

    #region controls
    public void lefttorque()
    {
        left = true;
    }

    public void Nolefttorque()
    {
        left = false;
    }

    public void righttorque()
    {
        right = true;
    }

    public void Norighttorque()
    {
        right = false;
    }

    public void fire()
    {
        firing = true;
    }

    public void Nofire()
    {
        firing = false;
    }
    #endregion

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("astroids"))
        {
            StartCoroutine(Shaking());
            StartCoroutine(Fading());
            StartCoroutine(Heartsss());
        }
        if (collision.gameObject.tag == "edgeplayer")
        {
            StartCoroutine(Shaking());
            StartCoroutine(Fading());
            StartCoroutine(Heartsss());
            health -= 1;
        }
        if (collision.gameObject.tag == "TripleBullets")
        {
            StartCoroutine(TripleAbility());
            GameObject Ability = collision.gameObject;
            Ability.GetComponent<AbilitiesItSelf>().Destroy();
        }
        if (collision.gameObject.tag == "Shield")
        {
            StartCoroutine(Shieldd());
            shielddd.SetActive(true);
            GameObject Ability = collision.gameObject;
            Ability.GetComponent<AbilitiesItSelf>().Destroy();
        }
        if (collision.gameObject.tag == "Star")
        {
            StartCoroutine(Star());
            GameObject Ability = collision.gameObject;
            Ability.GetComponent<AbilitiesItSelf>().Destroy();
        }
    }

    public void Star_ad()
    {
        StartCoroutine(Star());
    }

    IEnumerator Shaking()
    {
        CameraAnim.SetBool("CameraShake", true);
        yield return new WaitForSeconds(0.35f);
        CameraAnim.SetBool("CameraShake", false);
    }
    IEnumerator Fading()
    {
        PlayerAnim.SetBool("Fading", true);
        yield return new WaitForSeconds(1);
        PlayerAnim.SetBool("Fading", false);
    }
    IEnumerator Heartsss()
    {
        Hearts.SetBool("Fading", true);
        yield return new WaitForSeconds(1);
        Hearts.SetBool("Fading", false);
    }

    IEnumerator TripleAbility()
    {
        Triple = true;
        yield return new WaitForSeconds(10);
        Triple = false;
    }
    IEnumerator Shieldd()
    {
        shield = true;
        yield return new WaitForSeconds(10);
        shield = false;
    }
    IEnumerator Star()
    {
        star = true;
        yield return new WaitForSeconds(10);
        star = false;
    }

}