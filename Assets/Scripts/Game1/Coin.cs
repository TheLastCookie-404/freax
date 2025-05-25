using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;  // Сколько монет даёт эта монета

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinCollector collector = other.GetComponent<CoinCollector>();
            if (collector != null)
            {
                collector.AddCoins(coinValue);
            }
            Destroy(gameObject);  // Удаляем монету после сбора
        }
    }
}
