using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ブロックを押せるか押せないかのフラグ管理スクリプト
public class PushFlag : MonoBehaviour
{
    public bool push = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (!push)
            {

                push = true;
                Debug.Log("押せる");
            }
            else if (push)
            {
                push = false;
                Debug.Log("押せない");
            }
        }
    }
}
