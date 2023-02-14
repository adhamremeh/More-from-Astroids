using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesItSelf : MonoBehaviour
{

    public GameObject AbilityExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destroy()
    {
        Destroy(gameObject);
        Instantiate(AbilityExplosion, transform.position, Quaternion.identity);
    }
}