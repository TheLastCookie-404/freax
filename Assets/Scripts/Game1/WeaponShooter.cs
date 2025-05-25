using UnityEngine;

public class WeaponShooter : MonoBehaviour
{
    public GameObject bulletPrefab;  // Префаб пули
    public float bulletSpeed = 10f;  // Скорость пули

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Левая кнопка мыши
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Получаем позицию мыши в мире
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePos - transform.position).normalized;

        // Вычисляем угол поворота пули
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(0f, 0f, angle);

        // Создаём пулю с нужным поворотом
        GameObject bullet = Instantiate(bulletPrefab, transform.position, rotation);

        // Задаём пуле скорость
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction * bulletSpeed;
    }
}
