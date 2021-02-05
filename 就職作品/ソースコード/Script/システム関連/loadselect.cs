using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ロードボタンスクリプト　押すボタンによって移動先シーンを変える
public class loadselect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnloadClick()
    {
        SceneManager.LoadScene("load1-2");
    }
    public void OnloadClick1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void OnloadClick2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void OnloadClick3()
    {
        SceneManager.LoadScene("Stage3");
    }
}
