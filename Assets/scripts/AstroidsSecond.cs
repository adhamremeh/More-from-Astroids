using UnityEngine;

public class AstroidsSecond : MonoBehaviour
{

    public GameObject explosion;

    private Rigidbody2D rb;
    private int randomy;
    private int randomx;
    private int randomrotator;

    private int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        randomy = Random.Range(-3, 3);
        randomx = Random.Range(-3, 3);
        randomrotator = Random.Range(-3, 3);
        rb.velocity = new Vector2(randomx, randomy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, randomrotator);

        if (health <= 0)
        {
            FindObjectOfType<AudioManager>().playsound("AstroidExplosion");
            FindObjectOfType<Score>().IncScore_small();
            Destroy(gameObject);
            Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullets"))
        {
            GameObject bulleet = collision.gameObject;
            bulleet.GetComponent<bullet>().Destroy();
            health -= 1;
        }
        if (collision.CompareTag("edges"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player") && !player.star)
        {
            player.ad_normal++;
            FindObjectOfType<AudioManager>().playsound("AstroidExplosion");
            Destroy(gameObject);
            Instantiate(explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            FindObjectOfType<player>().health -= 1;
        }
        if (collision.CompareTag("shielditself"))
        {
            FindObjectOfType<AudioManager>().playsound("AstroidExplosion");
            Destroy(gameObject);
            GameObject shielditself = GameObject.FindGameObjectWithTag("shielditself");
            shielditself.SetActive(false);
        }
        if (collision.CompareTag("staritself"))
        {
            FindObjectOfType<AudioManager>().playsound("AstroidExplosion");
            Destroy(gameObject);
        }
    }
}
