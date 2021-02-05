    using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Mesageスクリプトを任意で呼び出せるようにするスクリプト　ActiveMessagePanelに適用
public class TutorialSubScene : MonoBehaviour
{   //　MessageUIに設定されているMessageスクリプトを設定
    [SerializeField]
    private Message messageScript;

    //　表示させるメッセージ
    private string message = "かかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかかか"
                             + "ききききききききききききききききききききききききききききききききききききききききききききききききききききききき\n"
                             + "くくくくく\n"
                             + "けけけけけけけけけけけけ";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            messageScript.SetMessagePanel(message);
        }
    }
}
