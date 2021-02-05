using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test14 : MonoBehaviour
{

    [SerializeField] private GameObject Wtarget;//赤ワープブロック
    




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
        if (other.gameObject.tag == "bWall")
        {


            // 座標を取得
            Vector3 pos = other.transform.position;

            Vector3 rot = other.transform.localEulerAngles;

            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Instantiate(Wtarget, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(rot.x, rot.y, rot.z));

        }
        if (other.gameObject.tag == "cWall")
        {
            // 座標を取得
            Vector3 pos = other.transform.position;

            Vector3 rot = other.transform.localEulerAngles;

            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Instantiate(Wtarget, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(rot.x, rot.y, rot.z));

        }


    }
}
