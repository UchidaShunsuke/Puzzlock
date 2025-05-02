using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    private Button button;  //�{�^���I�u�W�F�N�g
    private Text buttonText;//�{�^���̃e�L�X�g

    void Start()
    {
        button = GetComponent<Button>();
        buttonText = GetComponentInChildren<Text>();

        //�I�u�W�F�N�g�����{�^���̃e�L�X�g�ɂ���
        buttonText.text = gameObject.name;
        //�{�^���̃N���b�N��()�Ɏ��s����֐����w��
        button.onClick.AddListener(OnStageButton);
    }

    void OnStageButton()
    {
        //�N���b�N���ꂽ�I�u�W�F�N�g���Ɠ����V�[����ǂݍ���
        SceneManager.LoadScene(gameObject.name);
    }

}
