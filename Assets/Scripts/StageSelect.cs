using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    private Button button;  //ボタンオブジェクト
    private Text buttonText;//ボタンのテキスト

    void Start()
    {
        button = GetComponent<Button>();
        buttonText = GetComponentInChildren<Text>();

        //オブジェクト名をボタンのテキストにする
        buttonText.text = gameObject.name;
        //ボタンのクリック時()に実行する関数を指定
        button.onClick.AddListener(OnStageButton);
    }

    void OnStageButton()
    {
        //クリックされたオブジェクト名と同じシーンを読み込む
        SceneManager.LoadScene(gameObject.name);
    }

}
