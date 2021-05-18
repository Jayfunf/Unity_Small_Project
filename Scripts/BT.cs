using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BT : MonoBehaviour
{
    bool isPause = false;

    AdMobScreen adad;

    public GameObject Skin_Canvas;
    public GameObject SettingPanel;
    public GameObject Start_Canvas;
    public GameObject Main_Canvas;
    public GameObject Screenad;
    public GameObject playBT;
    public AudioClip ClickSound1;
    public GameObject CreditBT;
    public GameObject Playervis;

    void Awake()
    {
        Time.timeScale=0;
        GetComponent<AudioSource>().clip = ClickSound1;
    }
    public void pausegame()
    {
        
        Time.timeScale = 0;
        isPause = true;
        SettingPanel.SetActive(true);
    }

    public void Startgame()
    {
        Main_Canvas.SetActive(true);
        Start_Canvas.SetActive(false);
        //Playervis.SetActive(true);
        Time.timeScale = 1;
        GetComponent<AudioSource>().clip = ClickSound1;
        GetComponent<AudioSource>().Play();
    }

    public void Exitgame()
    {
        Application.Quit();
        GetComponent<AudioSource>().clip = ClickSound1;
        GetComponent<AudioSource>().Play();
    }

    public void MainLoad()
    {
        SceneManager.LoadScene("InGame");
        //Playervis.SetActive(false);

    }

    public void Skin()
    {
        Skin_Canvas.SetActive(true);
        Start_Canvas.SetActive(false);
        //Playervis.SetActive(true);
        GetComponent<AudioSource>().clip = ClickSound1;
        GetComponent<AudioSource>().Play();
    }

    public void Settingfalse()
    {
        SettingPanel.SetActive(false);
        Time.timeScale = 1;
        isPause = false;
    }

    public void SkinOut()
    {
        Skin_Canvas.SetActive(false);
        Start_Canvas.SetActive(true);
        //Playervis.SetActive(false);
    }
    public void AdScreen()
    {
        Screenad.SetActive(false);
        //playBT.SetActive(true);
    }
    public void AddAdScreen()
    {
        Screenad.SetActive(true);
    }
    public void CreditScene()
    {
        CreditBT.SetActive(true);
    }
    public void CreditOut()
    {
        CreditBT.SetActive(false);
    }
}
