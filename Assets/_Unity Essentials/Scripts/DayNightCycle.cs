using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Cycle Settings")]
    public float dayLengthInSeconds = 120f; // 2-minute day

    void Update()
    {
        // Degrees to rotate this frame
        float rotationSpeed = 360f / dayLengthInSeconds;

        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}