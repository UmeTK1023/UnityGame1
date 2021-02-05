using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//白いブロックスクリプト　主に固定化・非固定化用
public class WBlock : MonoBehaviour
{
    private GameObject Pusher;

    private PushFlag push;

    void Start()
    {
        Pusher = GameObject.Find("PushManager");
        push = Pusher.GetComponent<PushFlag>();
    }


    void Update()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        if (!push.push)
        {
            // 回転、位置ともに固定
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }

    }

}
