using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 10f; // �������� �������� ������
    public float rotationSpeed = 100f; // �������� �������� ������
    private Rigidbody rb; // ������ �� Rigidbody ������

    void Start()
    {
        // �������� ������ �� Rigidbody ������
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // �������� ���� �� ������
        float moveInput = Input.GetAxis("Vertical");
        float rotationInput = Input.GetAxis("Horizontal");

        // ��������� ������ �������� ������
        Vector3 moveDirection = transform.forward * moveInput;

        // ����������� ������ � ������� Rigidbody
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);

        // ��������� ���� �������� ������
        Quaternion rotation = Quaternion.Euler(0f, rotationInput * rotationSpeed * Time.fixedDeltaTime, 0f);

        // ������������ ������ � ������� Rigidbody
        rb.MoveRotation(rb.rotation * rotation);
    }
}

