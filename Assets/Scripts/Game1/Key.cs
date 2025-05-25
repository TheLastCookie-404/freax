using UnityEngine;

public class Key : MonoBehaviour
{
    public string keyID; // ”никальный ID ключа, например "Red", "Blue"

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            KeyInventory inventory = other.GetComponent<KeyInventory>();
            if (inventory != null)
            {
                inventory.AddKey(keyID);
                Destroy(gameObject);
            }
        }
    }
}