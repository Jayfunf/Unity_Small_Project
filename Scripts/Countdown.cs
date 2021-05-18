using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject SettingBT;

    void Start()
    {
        StartCoroutine("StartDelay");
    }

    void Update()
    {
        
    }

    void Delayfalse()
    {
        StartCoroutine("StartDelay");
    }

    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3f;
        SettingBT.SetActive(false);
        while (Time.realtimeSinceStartup < pauseTime)
            yield return 0;
        CountDown.gameObject.SetActive(false);
        Time.timeScale = 1;
            SettingBT.SetActive(true);
    }

}
