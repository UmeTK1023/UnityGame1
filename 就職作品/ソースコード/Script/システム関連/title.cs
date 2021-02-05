using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//タイトル画面スクリプト　ステージ選択画面に遷移
public class title : MonoBehaviour
{

	public void OnClickStartButton()
	{
		SceneManager.LoadScene("StageSelect");
	}
}
