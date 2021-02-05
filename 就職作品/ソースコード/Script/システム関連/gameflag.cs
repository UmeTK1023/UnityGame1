using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ゲームのクリアフラグを管理　trueなら次ステージのボタンが押せるように
public class gameflag : MonoBehaviour
{
    private GameObject ClearFlag;

    private gameflag clear;

    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;
    public GameObject Stage5;
    public GameObject Stage6;

    public bool[] clearflag = new bool[7];
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
         ClearFlag = GameObject.Find("ClearFlag");
        clear = ClearFlag.GetComponent<gameflag>();

        Stage1.SetActive(true);
        Stage2.SetActive(false);
        Stage3.SetActive(false);
        Stage4.SetActive(false);
        Stage5.SetActive(false);
        Stage6.SetActive(false);

        for (int i=0;i<6;i++)
            {
                clearflag[i] = false;
            }

        clearflag[0] = true;//1ステージ目はtrueにしておく

      
    }

    // Update is called once per frame
    void Update()
    {
           if (clear.clearflag[0])//最初からtrueだが作っておく
        {
          
            Stage1.SetActive(true);
        }
        if (clear.clearflag[1])
        {
        
            Stage2.SetActive(true);
        }
        if (clear.clearflag[2])
        {
        
            Stage3.SetActive(true);
        }
        if (clear.clearflag[3])
        {
         
            Stage4.SetActive(true);
        }
        if (clear.clearflag[4])
        {
         
            Stage5.SetActive(true);
        }
        if (clear.clearflag[5])
        {
           
            Stage6.SetActive(true);
        }


    }
    public void ClearFlag0()//1ステージ目はtrueだが一応作っておく
    {
        clearflag[0] = true;
    }
    public void ClearFlag1()
    {
        clearflag[1] = true;
    }
    public void ClearFlag2()
    {
        clearflag[2] = true;
    }
    public void ClearFlag3()
    {
        clearflag[3] = true;
    }
    public void ClearFlag4()
    {
        clearflag[4] = true;
    }
    public void ClearFlag5()
    {
        clearflag[5] = true;
    }
    public void ClearFlag6()
    {
        clearflag[6] = true;
    }
}
