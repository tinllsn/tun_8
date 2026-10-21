using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [Header("Cài đặt tốc độ")]
    public float forwardSpeed = -15f;  // Tốc độ tiến về phía trước
    public float takeOffSpeed = 5f;  // Tốc độ bay hướng lên trên (cất cánh)

    void Update()
    {
        // 1. Di chuyển tiến về phía trước theo trục Z
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // 2. Di chuyển hướng lên trên theo trục Y (để mô phỏng cất cánh)
        transform.Translate(Vector3.up * takeOffSpeed * Time.deltaTime);
    }
}
