using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointText : MonoBehaviour
{
    public PointCharge point;
    public TextMeshProUGUI pointText;
    int localpoint;

    public static PointText instance;

    private void Start()
    {
        instance = this;
    }
    private void Update()
    {
        localpoint = (int)point.value;
        string pointStr = localpoint.ToString("000");
        pointText.text = "POINT:" + pointStr;

    }


    public void AddPoint(int amount)
    {
        point.value = point.value + amount;
    }
}
