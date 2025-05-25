using UnityEngine;

public class Door : MonoBehaviour
{
    public string requiredKey = "red";

    private void OnTriggerEnter2D(Collider2D other)
    {
        KeyInventory inventory = other.GetComponent<KeyInventory>();
        if (inventory != null && inventory.HasKey(requiredKey))
        {
            Debug.Log("Дверь открыта!");
            Destroy(gameObject); // или Destroy(GetComponent<Collider2D>()) если хочешь оставить визуально
        }
    }
}