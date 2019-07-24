using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public Transform player;
    public GameObject spawner;
    public GameObject dageme;
    public int utimatgage = 1;
    public float movementSpeed = 10.0f ;

    public AudioClip clip;

    //hp
    public float startingHealth;
    protected float health;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        spawner = GameObject.FindGameObjectWithTag("Spawn");

        health = startingHealth;
    }
    //Call every frame
    void Update()
    {
        //Look at the player
        transform.LookAt(player);
        //Calculate distance between player
        float distance = Vector3.Distance(transform.position, player.position);
        //If the distance is smaller than the walkingDistance
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            TakeHit(1);
        }
    }


    public void TakeHit(float damage)
    {
        dageme.GetComponent<DamageEffect>().ShowEffect();
        health -= damage;

        if (health <= 0)
        {
            spawner.GetComponent<Spawner>().OnEnemyDeath();
            Die();
        }
    }

    public void Die()
    {
        GameObject.Find("spawn").GetComponent<Spawner>().OnEnemyDeath();
        Bullet.instance.AdjustChargePoints(utimatgage);
        PointText.instance.AddPoint(5);
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
        Destroy(gameObject);
    }

}
