// CoinCollector.cs
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int coins = 0;

    public void AddCoin(int amount)
    {
        coins += amount;
    }
}
