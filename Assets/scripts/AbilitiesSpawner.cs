using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesSpawner : MonoBehaviour
{

    public GameObject Ability;
    public float timebtwspawn;

    private float randx;
    private float randy;

    private bool trigged;

    void Awake()
    {
        int first = Random.Range(30, 41);
        timebtwspawn = first;
    }

    void Update()
    {
        randx = Random.Range(-15, 15);
        randy = Random.Range(-6, 4.5f);
        transform.position = new Vector3(randx, randy, 1);

        float rand = Random.Range(30, 36);

        if (timebtwspawn <= 0 && trigged)
        {
            Instantiate(Ability, transform.position, Quaternion.identity);
            timebtwspawn = rand;
        }
        else if (timebtwspawn <= 40 )
        {
            timebtwspawn -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        trigged = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        trigged = false;
    }
}
