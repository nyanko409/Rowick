using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup_move : MonoBehaviour
{
    public float downspeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = GameObject.Find("Plane").transform.position;
        //transformを取得
        Transform mytransform = this.transform;
        //座標を取得
        Vector3 pos = mytransform.position;
        if (pos.y > tmp.y)
        {
            pos.y -= downspeed;
        }
        //座標変更結果を反映
        transform.position = pos;
    }
}
