using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//goalオブジェクトに触れたときにクリア画面に遷移するスクリプト
public class GameClear : MonoBehaviour
{
    private GameObject ClearStage;

    private gameflag clearstage;

    public Camera m_Camera;

    // Start is called before the first frame update
    void Start()
    {
        ClearStage = GameObject.Find("ClearFlag");
        clearstage = ClearStage.GetComponent<gameflag>();
    }

    // Update is called once per frame
    void Update()
    {
        //以下でrotationを常にカメラ方向に向ける
        transform.LookAt(this.transform.position + m_Camera.transform.rotation * Vector3.back, m_Camera.transform.rotation * Vector3.up * 270);

        transform.Rotate(90, 0, 0);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage1")
        {
            clearstage.ClearFlag1();
            Destroy(other.gameObject);
            SceneManager.LoadScene("StageClear");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage2")
        {
            clearstage.ClearFlag2();
            Destroy(other.gameObject);
            SceneManager.LoadScene("StageClear");

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage1")
        {
            clearstage.ClearFlag1();
            Destroy(other.gameObject);
            SceneManager.LoadScene("StageClear");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage2")
        {
            clearstage.ClearFlag2();
            Destroy(other.gameObject);
            SceneManager.LoadScene("StageClear");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage3")
        {
            clearstage.ClearFlag3();
            Destroy(other.gameObject);
            SceneManager.LoadScene("StageClear");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage4")
        {
            clearstage.ClearFlag4();
            Destroy(other.gameObject);
            SceneManager.LoadScene("StageClear");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage5")
        {
            clearstage.ClearFlag5();
            Destroy(other.gameObject);
            SceneManager.LoadScene("StageClear");

        }
        if (other.gameObject.tag == "player" && this.gameObject.tag == "Stage6")
        {
            clearstage.ClearFlag6();
            Destroy(other.gameObject);
            SceneManager.LoadScene("StageClear");

        }

    }
    
}
