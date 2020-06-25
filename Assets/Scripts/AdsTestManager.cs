using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsTestManager : MonoBehaviour, IUnityAdsListener
{
    public static AdsTestManager instance;

    string gameID = "3676087";
    string placement = "rewardedVideo";

    public string rewardTipe;

    private void Awake() {
        if (instance != null) {
            Destroy(this.gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameID, true);
    }

    public void showAd(string rewardtipe) {
        rewardTipe = rewardtipe;
        Advertisement.Show(placement);
    }

    public void OnUnityAdsDidError(string message) {
        print("ad error");
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult) {
        StatsManager.instance.giveReward();
        print("finished");
    }

    public void OnUnityAdsDidStart(string placementId) {
        StatsManager.instance.rewardTipe = rewardTipe;
        print("ad start");
    }

    public void OnUnityAdsReady(string placementId) {
        print("ad is ready");
    }
}
