using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class PlayerMiniGame : MonoBehaviour
{
   
    [SerializeField] float speed = 10f;
    Rigidbody2D rb2d; 
    SpriteRenderer spriteRenderer;
    
    Animator anim; 

    private bool wasRunning;
    private bool grounded = true;

    BalanceScale balanceScale;



    void Awake(){
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent< Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        //balanceText.text = $"{balance}";
        
    }

    void Start(){
        balanceScale = FindObjectOfType<BalanceScale>();
    }
    void Update(){
      
       if( Input.GetAxis("Horizontal") != 0){
           Run();
        }
        else if(wasRunning){
            wasRunning = false;
            anim.SetBool("isRun", false);
        }
        
    }

    void Run(){

       wasRunning = true;
        balanceScale.DecreaseBalance();
        float deltaX = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        anim.SetBool("isRun", grounded);    //вкл аним, если на земле
        gameObject.transform.Translate(deltaX, 0, 0);

        Flip();
    }
    
    void Flip(){
        if(Input.GetAxis("Horizontal") < 0) 
        {
            spriteRenderer.flipX = false; 
            anim.SetTrigger("isRunMiniGame");
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            spriteRenderer.flipX = true; 
             anim.SetTrigger("isRunMiniGame");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("HealthyFood"))
    {
        Destroy(collision.gameObject); // Удаление объекта-еды при столкновении
        balanceScale.IncreaseBalance(true);
      
    }
    else if(collision.gameObject.CompareTag("FastFood"))
    {
        Destroy(collision.gameObject);
        balanceScale.IncreaseBalance(false);
     
    }
    
}

}
