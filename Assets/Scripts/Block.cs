using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6f)
        {
            // If the block falls below a certain height, destroy it
            Destroy(gameObject);
        }
    }
}
