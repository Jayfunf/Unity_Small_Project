using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;

public class ADAD : MonoBehaviour
{
    private readonly string unitID= "ca-app-pub-5257672669103134/2842995737";
    private readonly string test_unitID = "ca-app-pub-5257672669103134/2842995737";

    private readonly string test_deviceID = "33BE2250B43518CCDA7DE426D04EE232";

    private BannerView bannerView;

    public AdSize size;
    public AdPosition position;

    private void Start()
    {
        InitAd();
    }

    private void InitAd()
    {
        string id = Debug.isDebugBuild ? test_unitID : unitID;

        bannerView = new BannerView(id, AdSize.SmartBanner, AdPosition.Top);

        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }

    public void ToggleAd(bool active)
    {
        if(active)
        {
            bannerView.Show();
        }
        else
        {
            bannerView.Hide();
        }
    }
}
