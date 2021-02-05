using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//赤の小サイズの四角ブロックスクリプト
public class SmallCube : MonoBehaviour
{
	public GameObject target;
    public GameObject target2;
    //private bool pushmode1 = false;


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
		if (other.gameObject.tag == "SmallCube2")
		{
			// transformを取得
		Transform myTransform = this.transform;

		// 座標を取得
		Vector3 pos = myTransform.position;
	
			Destroy(other.gameObject);
			Instantiate(target, new Vector3(pos.x, 1.0f, pos.z), Quaternion.identity);
		}
        if (other.gameObject.tag == "SmallSankaku2")
        {
            // transformを取得
            Transform myTransform = this.transform;

            // 座標を取得
            Vector3 pos = myTransform.position;

            Destroy(other.gameObject);
            Instantiate(target2, new Vector3(pos.x, 0.5f, pos.z), Quaternion.identity);
        }
    }
}
