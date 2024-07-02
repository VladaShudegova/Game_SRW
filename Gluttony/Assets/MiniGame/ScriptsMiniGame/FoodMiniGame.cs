using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMiniGame : MonoBehaviour
{
    Rigidbody2D rb;
    CircleCollider2D collider;
    [SerializeField] float speed = 50;
    [SerializeField] float speedMax = 10, speedMin = -10; 
    float speedX, speedY = 5; 
    int countTouched = 2;
    void Awake(){
        collider = gameObject.GetComponent<CircleCollider2D>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        if(gameObject.transform.position.x > 9f)
        {
            speedX = Random.Range(speedMin, speedMin / 2);
        }
        else
        {
            speedX = Random.Range(speedMax / 2, speedMax);
        }
        rb.velocity = new Vector2(speedX, speedY); 
            
    }


    void Start(){
        
       
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Ground"))
        {
            countTouched--;
            if(countTouched <= 0){
                collider.isTrigger = true;
            }
            gameObject.transform.Rotate(new Vector3(0, 0, 70));
        }
        
    }
    
    

}
