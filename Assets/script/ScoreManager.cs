
using TMPro;

using UnityEngine;

public class ScoreManager : MonoBehaviour
{



    private string nameBasketball = "Basketball";
    private TextMeshProUGUI textScore;
    public static int addScore = 2;
    private int totalScore;

    private void Awake()
    {
        textScore = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains(nameBasketball)) {
            AddScore();
        }

    }
    private void AddScore() {
        totalScore += addScore;
        textScore.text = "SCORE " + totalScore;
    
    }
    private void ChangeScore(int scoreToChange) {
        addScore = scoreToChange;
    }

}
