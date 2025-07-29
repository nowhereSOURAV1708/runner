using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject Obstacle;
    public Transform spawnPoint;
    int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void GameStart()
    {
        player.SetActive(true);
        playButton.SetActive(false);
        StartCoroutine("SpawnObstacles");
        InvokeRepeating("ScoreUp",2f,1f);
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            float waitTime = Random.Range(0.9f, 2f);
            yield return new WaitForSeconds(waitTime);

            Instantiate(Obstacle, spawnPoint.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Optional: Add game logic like score updates here
    }

    void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }
}