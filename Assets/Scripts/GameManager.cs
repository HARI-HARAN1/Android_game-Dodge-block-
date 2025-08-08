using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;
    bool gameStarted = false;
    public GameObject taptext;
    public TextMeshProUGUI scoreText;
    int score = 0;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawning();
            gameStarted = true;
            taptext.SetActive(false);
           
        }
    }
    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
        
    }
    private void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX, maxX);
        Instantiate(block, spawnPos, Quaternion.identity);
        score++;
        scoreText.text = score.ToString();
    }
    
}
