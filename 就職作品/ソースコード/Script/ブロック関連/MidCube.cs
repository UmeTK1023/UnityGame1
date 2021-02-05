using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//中サイズのブロックスクリプト
public class MidCube : MonoBehaviour
{
	//private bool Midpushmode = false;

    private GameObject Pusher;

    private PushFlag push;

	// Start is called before the first frame update
	void Start()
    {
        Pusher = GameObject.Find("PushManager");
        push = Pusher.GetComponent<PushFlag>();
        
    }

    // Update is called once per frame
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
