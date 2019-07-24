using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_controll : MonoBehaviour
{
    public float Speed = 0.1f;
    public float stage_x = 10f;
    public float stage_y = 10f;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //float sin = Mathf.Sin(tmp.y);
        //float cos = Mathf.Cos(tmp.y);

  
        transform.position += transform.forward * Time.deltaTime * Speed;
        /*
        if(transform.position.x<-stage_x/2)
        {
            Speed = -Speed;
        }
        else if(transform.position.x> stage_x/2)
        {
            Speed = -Speed;
        }
        else if(transform.position.z > stage_y/2)
        {
            Speed = -Speed;
        }
        else if(transform.position.z<-stage_y/2)
        {
            Speed = -Speed;
        }*/
        //GameObject.Find("Cube").transform.position = new Vector3(tmp.x + 0.1f, tmp.y, tmp.z);
    }
}
