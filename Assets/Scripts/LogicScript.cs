

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject goldrewardImage; // assign in Inspector
    private bool goldShown = false; // make sure it shows only once
    public GameObject silverrewardImage; // assign in Inspector
    private bool silverShown = false; // make sure it shows only once
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public int pipesToFinish = 10;
    public GameObject finishScreen;
    public float timeToWin = 30f; 
    private float timer;
    public BirdScript bird;

    public Text finalScoreText;
    public Text finalCoinsText;


    void Start()
    {
        timer = 0f;
    }

    void Update()
    {
      
        if (bird.birdIsAlive)
        {
            timer += Time.deltaTime;

            if (timer >= timeToWin)
            {
                FinishLevel();
            }
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore()
    {

        playerScore += 1;
        scoreText.text = playerScore.ToString();

        if (!goldShown && playerScore >= 4)
        {
            goldrewardImage.SetActive(true); //  Show gold the image
            goldShown = true;
        }

            if (!silverShown && playerScore >= 2)
            {
                silverrewardImage.SetActive(true); // Show silver the image
                silverShown = true;
            }

            if (playerScore >= pipesToFinish)
            {
                FinishLevel();
            }
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void FinishLevel()
    {
        Time.timeScale = 0f;
        finishScreen.SetActive(true);

        finalScoreText.text = "Score: " + playerScore.ToString();
        finalCoinsText.text = "Coins: " + PlayerPrefs.GetInt("Coins", 0).ToString();
    }


    public void BackToSelectLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
















}
  
