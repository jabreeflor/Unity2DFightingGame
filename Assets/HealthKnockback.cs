using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthKnockback : MonoBehaviour
{

    public Animator animator;
    public int maxHealth = 100;

    public int currentHealth;
    public float verticalKnockbackForce;
    public float horizontalKnockbackForce;

    public Rigidbody2D rb;

    public Text txt;



   

    

    // Start is called before the first frame update

    void Start()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();

        


    }

    public void TakeDamage(int damage) 
    {
        currentHealth += damage;
           //play hurt animation
        Debug.Log("Enemy took damage!");
        txt.GetComponent<UnityEngine.UI.Text>().text = currentHealth.ToString();
        
        
        
        if (currentHealth <= 0) 
        {
            Die();
        }
    
    }

    public void LeftHandleKnockBack()
    {
        animator.SetTrigger("Hurt");
        rb.AddForce(Vector2.up * verticalKnockbackForce * currentHealth);
        rb.AddForce(Vector2.right * horizontalKnockbackForce * currentHealth);

    }
    public void RightHandleKnockBack()
    {
        animator.SetTrigger("Hurt");
        rb.AddForce(Vector2.up * verticalKnockbackForce * currentHealth);
        rb.AddForce(Vector2.left * horizontalKnockbackForce * currentHealth);


    }
    public void ResetHealth()
    {
        currentHealth = maxHealth;
    }

    void Die() 
    {

        Debug.Log("Enemy died!");
        //die animation


        //disable the enemy

    }
   
}
