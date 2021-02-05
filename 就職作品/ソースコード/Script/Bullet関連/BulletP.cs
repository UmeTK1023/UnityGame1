using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//プレイヤーにアタッチする弾発射スクリプト
public class BulletP : MonoBehaviour
{

    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform muzzlePoint;
    [SerializeField]
    private float shotSpeed;

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
        if (Input.GetKey(KeyCode.F1))
        {
            if (bflag.Bulletflag && bflag.RedB >= 1)
            {
                bflag.RedB -= 1;
                Shot();
            }
         
        }
    }
    public void Shot()
    {
        GameObject bullet = GameObject.Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * shotSpeed);
    }
}
