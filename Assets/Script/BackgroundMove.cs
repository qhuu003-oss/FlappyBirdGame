using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float deadZone = -20f;
    public float startPos = 20f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            transform.position = new Vector3(startPos, transform.position.y, transform.position.z);
        }
    }
}