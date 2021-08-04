using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour{
    public Transform player;
    public Text score;
    public Text highScore;
    int number = 0;

    public void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString("0");        
    }
    void Update()
    {
        score.text = Time.timeSinceLevelLoad.ToString("0");
        if (FindObjectOfType<GameManager>().getGameEnded().Equals(true))
        {
            number = (int) Time.timeSinceLevelLoad;
            
            if (number > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", number);
            }

            score.text = "GameOver!";
        }
    }
}
