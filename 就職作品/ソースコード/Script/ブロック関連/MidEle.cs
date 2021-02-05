using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//中サイズのエレベーターブロックスクリプト　上下運動
public class MidEle : MonoBehaviour
{
    private Rigidbody rigid;
    private int count;
    private int y;
    private GameObject Pusher;
    private PushFlag push;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        count = 0;
        y = 1;
        Pusher = GameObject.Find("PushManager");
        push = Pusher.GetComponent<PushFlag>();
    }

    // Update is called once per frame
    void Update()
    {
        count += 1;
        
        rigid.velocity = (new Vector3(0, y, 0));
        if (count >= 1000 && this.transform.position.y >= 2.0f)
        {
            count = 0;
            y *= -1;
        }
        else if (count >= 1000 && this.transform.position.y < 1.0f)
        {
            count = 0;
            y *= -1;
        }
       
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        if (!push.push)
        {
            // 回転、位置ともに固定
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
