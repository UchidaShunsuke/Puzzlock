using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    private int keyCount;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Key"))
        {
            keyCount++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Key"))
        {
            keyCount--;
            //if(keyCount <= 0)   //‰ü—Ç‘O
            if (keyCount <= 0 && player != null)
            {
                player.SendMessage("GameClear");
            }
        }
    }
}
