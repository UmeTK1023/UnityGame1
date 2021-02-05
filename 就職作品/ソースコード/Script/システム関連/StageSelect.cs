using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ステージ選択ボタンスクリプト　押したボタンによって移動先を変える　フラグによってボタンのオンオフを変える
public class StageSelect : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick1()
    {
        // SceneManager.LoadScene("load1-1");
        SceneManager.LoadScene("Stage1");
    }

    public void OnClick2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void OnClick3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void OnClick4()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void OnClick5()
    {
        SceneManager.LoadScene("Stage5");
    }
    void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage1")
            {
               
                
                SceneManager.LoadScene("Stage1");

            }
            if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage2")
            {
             
                SceneManager.LoadScene("Stage2");

            }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage3")
        {

            SceneManager.LoadScene("Stage3");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage4")
        {

            SceneManager.LoadScene("Stage4");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage5")
        {

            SceneManager.LoadScene("Stage5");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage6")
        {

            SceneManager.LoadScene("Stage6");

        }
    }
}
