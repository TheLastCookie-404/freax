using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 3f;

    void Start()
    {
        Destroy(gameObject, lifetime); // Удалить пулю через N секунд
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Здесь можно прописать урон
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Попадание по врагу!");
            Destroy(gameObject);
        }
    }
}
