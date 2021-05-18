using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using TMPro;

public class ADMgr : MonoBehaviour
{
    public TextMeshProUGUI creditText;
    
    const string m_AOS_GameID = "3592058";

    void Start()
    {
        Advertisement.Initialize(m_AOS_GameID); 
    }
    void Update()
    {

    }
    public void ShowAD()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
    public void ShowReward()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            ShowOptions options = new ShowOptions { resultCallback = ResultAds };
            Advertisement.Show("rewardedVideo", options);
        }
    }
    void ResultAds(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Failed:
                Debug.LogError("The ad Failed to be shown");
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end");
                break;
            case ShowResult.Finished:
                Player.credit += 100;
                Debug.Log("The as was successfully shown");
                break;


        }
    }
}
