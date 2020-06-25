using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text score;
    public Text maxScore;

    public Text lives;

    public void ActUIValues() {
        lives.text = "Lives: " + StatsManager.instance.lives.ToString();
        score.text = "Score: " + StatsManager.instance.score.ToString();
        maxScore.text = "maxScore: " + StatsManager.instance.maxScore.ToString();
    }

    public void Update() {
        if (StatsManager.instance.maxScore < StatsManager.instance.score) {
            StatsManager.instance.maxScore = StatsManager.instance.score;
        }
        ActUIValues();
    }
}
