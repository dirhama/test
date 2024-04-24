using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 10f; // Скорость движения машины
    public float rotationSpeed = 100f; // Скорость поворота машины
    private Rigidbody rb; // Ссылка на Rigidbody машины

    void Start()
    {
        // Получаем ссылку на Rigidbody машины
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Получаем ввод от игрока
        float moveInput = Input.GetAxis("Vertical");
        float rotationInput = Input.GetAxis("Horizontal");

        // Вычисляем вектор движения машины
        Vector3 moveDirection = transform.forward * moveInput;

        // Передвигаем машину с помощью Rigidbody
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);

        // Вычисляем угол поворота машины
        Quaternion rotation = Quaternion.Euler(0f, rotationInput * rotationSpeed * Time.fixedDeltaTime, 0f);

        // Поворачиваем машину с помощью Rigidbody
        rb.MoveRotation(rb.rotation * rotation);
    }
}

