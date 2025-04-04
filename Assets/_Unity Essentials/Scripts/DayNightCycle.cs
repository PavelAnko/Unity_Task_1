using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day cycle in seconds")]
    public float dayLengthInSeconds = 60f;

    void Update()
    {
        float rotationSpeed = 360f / dayLengthInSeconds * Time.deltaTime;
        transform.Rotate(Vector3.right, rotationSpeed);
    }
}
