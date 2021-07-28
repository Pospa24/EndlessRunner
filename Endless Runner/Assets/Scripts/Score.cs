using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour{
    public Transform player;
    public Text score;
    public 
    
    void Update()
    {
        score.text = Time.timeSinceLevelLoad.ToString("0");
    }
}
