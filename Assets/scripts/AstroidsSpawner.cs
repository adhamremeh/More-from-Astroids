using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidsSpawner : MonoBehaviour
{
    public GameObject[] obs;
    public float timebtwspawn;
    public float starttimebtwspawn;
    public float decreasetime;
    public float mintime = 0.65f;

    void start()
    {
        float startrand = Random.Range(3f, 4f);
        starttimebtwspawn = startrand;
    }

    void Update()
    {
        if (timebtwspawn <= 0)
        {
            int rand = Random.Range(0, obs.Length);
            Instantiate(obs[rand], transform.position, Quaternion.identity);
            timebtwspawn = starttimebtwspawn;
            if (starttimebtwspawn > mintime)
            {
                starttimebtwspawn -= decreasetime;
            }
        }
        else if (timebtwspawn <= 10)
        {
            timebtwspawn -= Time.deltaTime;
        }

    }
}
