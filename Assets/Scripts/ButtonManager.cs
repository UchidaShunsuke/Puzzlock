using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void HomeScene()
    {
        SceneManager.LoadScene("HomeScene");
    }
    public void Restart()
    {
        //���V�[�������X�^�[�g
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
