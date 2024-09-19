using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    int score = 0;

    int health = 3;
    bool isGameOver = false;

    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] GameObject gameOverText;

    public static GameManager instance;

    private void Awake(){

        // Ensures one instance of the static Game Manager
        instance = this;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") && isGameOver) {
            // Restarts game post player loss
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            isGameOver = false;
        }

        if (health == 0) {
            InitiateGameOver();
        }
    }

    public void IncreaseScore(int amount){
        score += amount;
        scoreText.text = "Score: " + score.ToString();
    }

    public void IncreaseHealth(int amount){
        if (health < 3) {
            health += amount;
            healthText.text = "Health: " + health.ToString();
        }
    }

    public void DecreaseHealth(int amount){
        
            health -= amount;
            healthText.text = "Health: " + health.ToString();
        
    }

    public void InitiateGameOver(){
        isGameOver = true;
        gameOverText.SetActive(true);
    }
}
