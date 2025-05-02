using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public GameObject effect;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string keyColor = collision.gameObject.name.Replace("Key", "");
        string lockColor = gameObject.name.Replace("Lock", "");

        if(keyColor == lockColor)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
