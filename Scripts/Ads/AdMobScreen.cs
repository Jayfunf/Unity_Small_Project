using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class AdMobScreen : MonoBehaviour
{
    //0으로 이루어진 아이디는 직접 채우셔야 합니다.
    private readonly string unitID = "ca-app-pub-5257672669103134/7144378416";
    private readonly string test_unitID = "ca-app-pub-5257672669103134/7144378416"; //테스트
    //unitID는 애드몹에 앱 등록하고 광고 등록도 해서 발급 받은 광고 아이디를 넣으시면 됩니다.

    private InterstitialAd screenAd;
    public static bool ShowAd = false;

    public void Start()
    {
        MobileAds.Initialize("ca-app-pub-5257672669103134~4323598360");
        //애드몹에 앱을 등록하면 앱 전용 코드를 받습니다. 그걸 넣으시면 됩니다.
        string id = test_unitID;
        //테스트할 때는 test_unitID로 하고, 출시할 때는 unitID로 바꾸셔야 합니다.
        screenAd = new InterstitialAd(id);

        screenAd.OnAdLoaded += HandleOnAdLoaded;
        screenAd.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        screenAd.OnAdOpening += HandleOnAdOpening;
        screenAd.OnAdClosed += HandleOnAdClosed;
        screenAd.OnAdLeavingApplication += HandleOnAdLeavingApplication;

        Load();
    }

    private void Update()
    {
        if (ShowAd == true) //ShowAd : true (광고재생)
        {
            ShowAd = false;
            Show();
        }
    }

    private void Load()
    {
        AdRequest request = new AdRequest.Builder().Build();
        screenAd.LoadAd(request);
    }

    public void Show()
    {
        StartCoroutine("ShowScreenAd");
    }

    public IEnumerator ShowScreenAd()
    {
        while (!screenAd.IsLoaded())
        {
            yield return null;
        }
        screenAd.Show();
    }
    public void GameOver()
    {
        if (this.screenAd.IsLoaded())
        {
            this.screenAd.Show();
        }
    }
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {

    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {

    }

    public void HandleOnAdOpening(object sender, EventArgs args)
    {

    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        screenAd.Destroy();
        Load();
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {

    }
}
