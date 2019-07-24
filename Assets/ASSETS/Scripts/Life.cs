using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public int health;
    public int numOfLife;

    public Image[] lifes;
    public Sprite fullLife;
    public Sprite deadLife;

    public static Life instance;


    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        if (health > numOfLife)
        {
            health = numOfLife;
        }

        for (int i = 0; i < lifes.Length; i++)
        {
            if (i < health)
            {
                lifes[i].sprite = fullLife;
            }
            else
            {
                lifes[i].sprite = deadLife;
            }
            if (i < numOfLife)
            {
                lifes[i].enabled = true;
            }
            else
            {
                lifes[i].enabled = false;
            }
        }
    }


}
