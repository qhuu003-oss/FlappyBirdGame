using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float flapStrength = 5f;

    private Rigidbody2D rb;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * flapStrength;

            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}