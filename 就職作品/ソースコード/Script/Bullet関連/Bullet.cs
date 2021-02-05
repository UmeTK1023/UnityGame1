using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//赤弾スクリプト
public class Bullet : MonoBehaviour
{
    public GameObject Rtarget1;//赤四角小ブロック
    public GameObject Rtarget2;//赤四角小ブロック
    private int count;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WCube")
        {
            // transformを取得
            Transform myTransform = this.transform;

            // 座標を取得
            Vector3 pos = myTransform.position;



            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Instantiate(Rtarget1, new Vector3(pos.x, 0.0f, pos.z), Quaternion.identity);
        }
        if (other.gameObject.tag == "WSankaku")
        {
            // transformを取得
            Transform myTransform = this.transform;

            // 座標を取得
            Vector3 pos = myTransform.position;



            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Instantiate(Rtarget2, new Vector3(pos.x, 0.0f, pos.z), Quaternion.identity);
        }
    }
}
