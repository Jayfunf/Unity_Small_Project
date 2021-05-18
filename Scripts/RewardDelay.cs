using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RewardDelay : MonoBehaviour
{
    public float msToWait = 5000.0f;

    private Text rewardTimer;
    private Button RewaredBT;
    private ulong lastrewardOpen;

    private void Start()
    {
        RewaredBT = GetComponent<Button>();
        lastrewardOpen = ulong.Parse(PlayerPrefs.GetString("Lastrewarded"));
        rewardTimer = GetComponentInChildren<Text>();

        if (!IsrewardReady())
        {
            RewaredBT.interactable = false;
        }
    }
    private void Update()
    {
        if(!RewaredBT.IsInteractable())
        {
            if (IsrewardReady())
            {
                RewaredBT.interactable = true;
                return;
            }

            //Set the timer
            ulong diff = ((ulong)DateTime.Now.Ticks - lastrewardOpen);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
            float secondsLeft = (float)(msToWait - m) / 1000.0f;

            string r = "";
            //Hours
            r += ((int)secondsLeft / 3600).ToString() + "H ";
            secondsLeft -= ((int)secondsLeft / 3600) * 3600;
            //Minutes
            r+= ((int)secondsLeft / 60).ToString("00") + "M ";
            //Seconds
            r += (secondsLeft % 60).ToString("00") + "S "; ;
            rewardTimer.text = r;
        }
    }
    public void DelayClick()
    {
        PlayerPrefs.SetString("Lastrewarded", lastrewardOpen.ToString());
        lastrewardOpen = (ulong)DateTime.Now.Ticks;
        RewaredBT.interactable = false;
    }

    private bool IsrewardReady()
    {
        ulong diff = ((ulong)DateTime.Now.Ticks - lastrewardOpen);
        ulong m = diff / TimeSpan.TicksPerMillisecond;

        float secondsLeft = (float)(msToWait - m) / 1000.0f;

        if (secondsLeft < 0)
        {
            rewardTimer.text = "Ready!";
            return true;
        }
        return false;
    }
}
