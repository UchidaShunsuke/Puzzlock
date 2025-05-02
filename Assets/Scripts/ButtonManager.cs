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
        //現シーンをリスタート
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
