using UnityEngine;

public class Door : MonoBehaviour
{
    public string requiredKeyID; // ID ключа, который открывает эту дверь

    private bool isOpen = false;

    void OnTriggerStay2D(Collider2D other)
    {
        if (isOpen) return;

        if (other.CompareTag("Player"))
        {
            KeyInventory inventory = other.GetComponent<KeyInventory>();
            if (inventory != null && inventory.HasKey(requiredKeyID))
            {
                OpenDoor();
            }
        }
    }

    void OpenDoor()
    {
        isOpen = true;
        Debug.Log("Дверь открыта ключом: " + requiredKeyID);
        // Можно проиграть анимацию, звук и т.п.
        gameObject.SetActive(false); // Просто отключаем дверь
    }
}
