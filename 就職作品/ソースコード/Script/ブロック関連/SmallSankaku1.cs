using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//赤の三角ブロックスクリプト
public class SmallSankaku1 : MonoBehaviour
{
    public GameObject Starget;
   
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

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallSankaku2")
        {
            // transformを取得
            Transform myTransform = this.transform;

            // 座標を取得
            Vector3 pos = myTransform.position;

            Destroy(other.gameObject);
            Instantiate(Starget, new Vector3(pos.x, 0.0f, pos.z), Quaternion.identity);
        }
    }
}
