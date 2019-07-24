using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEffect : MonoBehaviour
{
    public bool trigger;
    public int repeat = 1;
    public float speed = 5;

    Renderer rend;
    float value;
    int curRepeat;


    public void ShowEffect()
    {
        trigger = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        trigger = false;
        value = 1.0f;
        curRepeat = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            rend.material.SetFloat("_Damage", value);
            value -= speed * Time.deltaTime;

            if(value < 0 || value > 1)
            {
                speed *= -1;

                curRepeat++;
                if(curRepeat >= repeat * 2)
                {
                    trigger = false;
                    value = 1.0f;
                    curRepeat = 0;
                }
            }

        }
    }
}
