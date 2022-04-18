using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;

  

    public float attackRange = 0.5f;
    public int attackDamage = 40;
    public int currentAttack = 0;
    public float timeSinceAttack = 0.0f;


    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1)) 
        {
            Block();
        }
    }

    void Attack() 
    {


        currentAttack++;
        //loop back to one after third attack
        if (currentAttack > 3)
            currentAttack = 1;

        // Reset attack combo if time since last attack is too large
        if (timeSinceAttack > 1.0f)
            currentAttack = 1;





        //play attack animation
        animator.SetTrigger("Attack" + currentAttack);

        //reset timer
        timeSinceAttack = 0.0f;
        //detect enemies in range
        Collider2D [] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        //apply damage to enemies
        foreach(Collider2D enemy in hitEnemies) 
        {
            if (enemy.GetComponent<HealthKnockback>().rb.transform.position.x < attackPoint.transform.position.x)
            {
                Debug.Log("Attack from the right");
                enemy.GetComponent<HealthKnockback>().RightHandleKnockBack();
            }
            else
            {
                Debug.Log("Attack from the left");
                enemy.GetComponent<HealthKnockback>().LeftHandleKnockBack();
            }
                
            enemy.GetComponent<HealthKnockback>().TakeDamage(attackDamage);
            
        }
        
    }

    /*
     * rb.AddForce(Vector2.up*verticalKnockbackForce* currentHealth);

        if(transform.position.x < enemy.transform.position.x) 
        {
            rb.AddForce(Vector2.left * horizontalKnockbackForce* currentHealth);
        }
        else
        {
            rb.AddForce(Vector2.right * horizontalKnockbackForce* currentHealth);
        }

     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */


    void Block()
    {
        //play block animation
        animator.SetTrigger("Block");
    }

    void OnDrawGizmosSelected() 
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }
}
