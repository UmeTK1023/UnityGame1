using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//落ちている小インクにアタッチするスクリプト
public class BulletFlag : MonoBehaviour
{
    private GameObject bFlag;
    private BulletManager bflag;
    // Start is called before the first frame update
    void Start()
    {
        bFlag = GameObject.Find("BulletManager");
        bflag = bFlag.GetComponent<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            bflag.Bulletflag = true;
            bflag.RedB += 1;
            Destroy(this.gameObject);

        }

    }
}
