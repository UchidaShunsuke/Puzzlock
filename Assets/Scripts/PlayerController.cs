using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer sp;
    public GameObject telop;

    public float speed = 5;
    private float xVel;
    private float yVel;


    void Start()
    {
        
    }

    void Update()
    {
        xVel = Input.GetAxis("Horizontal") * speed; //左右移動
        yVel = Input.GetAxis("Vertical") * speed;   //上下移動

        //キャラのアニメーション
        if(xVel != 0 || yVel != 0)
        {
            animator.SetBool("isWalk", true);
        }
        else
        {
            animator.SetBool("isWalk", false);
        }

        //キャラの向きの反転
        if(xVel > 0)
        {
            sp.flipX = false;
        }
        if(xVel < 0)
        {
            sp.flipX = true;
        }

            rb.velocity = new Vector2(xVel, yVel);
    }

    void GameClear()
    {
        if (telop != null)  //追加
        {
            animator.SetTrigger("cheer");
            telop.SetActive(true);
        }
    }
}
