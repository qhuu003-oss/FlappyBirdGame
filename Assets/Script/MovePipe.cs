using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float deadZone = -20f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}