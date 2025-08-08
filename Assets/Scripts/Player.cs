
using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed;
    public GameObject tapUI;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (touchPos.x < 0)
            {
                rb.AddForce(Vector2.left * moveSpeed);
            }
            else
            {
                rb.AddForce(Vector2.right * moveSpeed);
            }
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            // If the player collides with a block, destroy the block
           SceneManager.LoadScene("SampleScene");
        }
    }
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Block"))
    //     {
    //         // Stop music
    //         MusicManager.Instance.StopMusic();

    //         // Show "Tap to Start" button again
    //         tapUI.SetActive(true);

    //         // Hide player
    //         gameObject.SetActive(false);

    //         // Pause game
    //         Time.timeScale = 0f;
    //     }
    // }
}
