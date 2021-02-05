using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//クリア画面でステージ選択画面に戻るスクリプト
public class ReturnSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickReturn()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
