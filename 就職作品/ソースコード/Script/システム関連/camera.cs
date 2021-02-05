using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//カメラスクリプト
public class camera : MonoBehaviour
{
    private GameObject mainCamera;      //メインカメラ格納用
    private GameObject subCamera;       //サブカメラ格納用 

    // Start is called before the first frame update
    void Start()
    {
        //メインカメラとサブカメラをそれぞれ取得
        mainCamera = GameObject.Find("MainCamera");
        subCamera = GameObject.Find("SubCamera");

        subCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		// transformを取得
		Transform myTransform = this.transform;

		// 座標を取得
		Vector3 pos = myTransform.position;
		Vector3 rot = myTransform.localEulerAngles;
		if (Input.GetKeyDown(KeyCode.I)) {
			pos.x = 0.0f;    
			pos.y = 9.0f;    
			pos.z = 5.01f;    
			rot.y = 180.0f;
		}
		if (Input.GetKeyDown(KeyCode.L))
		{
			pos.x = -5.0f;  
			pos.y = 9.0f;   
			pos.z = 0.01f;    
			rot.y = 90.0f;
		}
		if (Input.GetKeyDown(KeyCode.K))
		{
			pos.x = 0.0f;    
			pos.y = 9.0f;   
			pos.z = -5.01f;    
			rot.y = 0.0f;
		}
		if (Input.GetKeyDown(KeyCode.J))
		{
			pos.x = 5.0f;   
			pos.y = 9.0f;    
			pos.z = 0.01f;  
			rot.y = -90.0f;
		}
		myTransform.position = pos;  // 座標を設定
		myTransform.localEulerAngles = rot; // 回転角度を設定

        //スペースキーが押されている間、サブカメラをアクティブにする
        if (Input.GetKey("left alt"))
        {
            //サブカメラをアクティブに設定
            mainCamera.SetActive(false);
            subCamera.SetActive(true);
        }
        else
        {
            //メインカメラをアクティブに設定
            subCamera.SetActive(false);
            mainCamera.SetActive(true);
        }
    }
}
