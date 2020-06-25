using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public static StatsManager instance;

    public int lives;

    public int score;
    public int maxScore;

    public string rewardTipe;

    private void Awake() {
        if (instance != null) {
            Destroy(this.gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void Start() {
        lives = 3;
        score = 100;
        maxScore = 300;
    }

    public void giveReward() {
        if (rewardTipe == "Lives") {
            lives += 1;
        }

        if (rewardTipe == "Score") {
            score += Mathf.RoundToInt(score * 0.25f);
        }
    }
}
