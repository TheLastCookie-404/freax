using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    private Animator animator;
    private bool isDead = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        if (animator != null)
        {
            animator.SetTrigger("Die");
        }
        Destroy(gameObject);
    }
}