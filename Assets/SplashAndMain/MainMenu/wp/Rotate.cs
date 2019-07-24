using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int speed = 10;
    public bool inverse = false;

    // Start is called before the first frame update
    void Start()
    {
        if (inverse) speed *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
    }
}
