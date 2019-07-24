using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class get_score : MonoBehaviour
{
    public PointCharge point;
    int localPoint;

    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();

        localPoint = (int)point.value;
        string pointStr = localPoint.ToString("000");
        text.text = pointStr;

    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("SplashScreen");
        }
    }

}
