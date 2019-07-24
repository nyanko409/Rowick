using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupcontroller : MonoBehaviour
{
    public GameObject powerup;
    public float stagesize_tate;
    public float stagesize_yoko;
    public float powerup_sec;
    int frame=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        if (frame / 60 > powerup_sec)
        {
            Instantiate(powerup, new Vector3(Random.Range(-stagesize_tate / 2, stagesize_tate / 2), transform.position.y+40.0f, Random.Range(-stagesize_yoko / 2, stagesize_yoko / 2)), transform.rotation);
            frame = 0;
        }
    }
}
