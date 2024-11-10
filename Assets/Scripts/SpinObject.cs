using UnityEngine;

public class SpinInPlace : MonoBehaviour
{
    public float spinSpeed = 100f;

    void Update()
    {
        // Use Space.Self for local rotation or Space.World for world axis
        transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f, Space.Self);
    }
}
