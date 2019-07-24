using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryEverything : MonoBehaviour
{


    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            player.GetComponent<Life>().health++;
            PointText.instance.AddPoint(5);
            GameObject.Find("spawn").GetComponent<Spawner>().OnEnemyDeath();

        }
    }


}
