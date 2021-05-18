using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject Normal_Score;
    public GameObject Best_Score;
    public GameObject NormalScoreText;
    public GameObject BestScoreText;
    public GameObject Result_Panel;
    public GameObject Setting;
    AdMobScreen adad;
    public AudioClip MainBGM1;

    float score;
    float pointIncreasePerSecond;

    Player Playerscripts;
    void Start()
    {
        //score = 0f;
        //pointIncreasePerSecond = 12f;
        GetComponent<AudioSource>().clip = MainBGM1;
        GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        //score += pointIncreasePerSecond * Time.deltaTime;
    }


    public void CallGameOver()
    {
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.5f);
        GameOverPanel.SetActive(true);
        Normal_Score.SetActive(false);
        Best_Score.SetActive(false);
        NormalScoreText.SetActive(false);
        BestScoreText.SetActive(false);
        Result_Panel.SetActive(true);
        Setting.SetActive(false);
        adad.ShowScreenAd();
        adad.GameOver();
        yield break;
    }

}
