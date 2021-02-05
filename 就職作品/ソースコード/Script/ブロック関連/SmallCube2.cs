using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//青の小サイズの四角ブロックスクリプト
public class SmallCube2 : MonoBehaviour
{
    //	private bool pushmode2 = false;
    private GameObject Pusher;

    private PushFlag push;

    void Start()
	{
        Pusher = GameObject.Find("PushManager");
        push = Pusher.GetComponent<PushFlag>();
    }


	void Update()
	{

		GetComponent<Rigidbody>().constraints =RigidbodyConstraints.FreezeRotation;

		if (!push.push)
		{
			// 回転、位置ともに固定
			GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		}
	}
		void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "SmallCube1")
		{
	
			Destroy(other.gameObject);
			
		}
	}
}
