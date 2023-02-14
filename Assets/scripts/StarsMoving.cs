using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsMoving : MonoBehaviour
{
    public float speed;

    private float endx;
    private float startx;

    public float endrandx1;
    public float endrandx2;

    public float startrandx1;
    public float startrandx2;

    private float randy;
    private float randfirststart;

    private void Start()
    {
        randfirststart = Random.Range(-30, 30);
        endx = Random.Range(endrandx1, endrandx2);
        startx = Random.Range(startrandx1, startrandx2);
        randy = Random.Range(-21f, 21f);
        transform.position = new Vector2(randfirststart, randy);
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= endx)
        {
            Vector2 pos = new Vector2(startx, randy);
            transform.position = pos;
        }

    }
}
