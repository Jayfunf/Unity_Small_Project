using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public GameObject Skin1;
    public GameObject Skin2;
    public GameObject Skin3;
    public GameObject Skin4;
    public GameObject Skin5;
    public GameObject Skin6;
    public GameObject Skin7;
    public GameObject Skin8;
    public GameObject Skin9;
    public GameObject Skin10;
    public GameObject Skin11;
    public GameObject Skin12;
    Player player;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("skincheck1") == 1)
        {
            Destroy(Skin1);
        }
        if (PlayerPrefs.GetInt("skincheck2") == 1)
        {
            Destroy(Skin2);
        }
        if (PlayerPrefs.GetInt("skincheck3") == 1)
        {
            Destroy(Skin3);
        }
        if (PlayerPrefs.GetInt("skincheck4") == 1)
        {
            Destroy(Skin4);
        }
        if (PlayerPrefs.GetInt("skincheck5") == 1)
        {
            Destroy(Skin5);
        }
        if (PlayerPrefs.GetInt("skincheck6") == 1)
        {
            Destroy(Skin6);
        }
        if (PlayerPrefs.GetInt("skincheck7") == 1)
        {
            Destroy(Skin7);
        }
        if (PlayerPrefs.GetInt("skincheck8") == 1)
        {
            Destroy(Skin8);
        }
        if (PlayerPrefs.GetInt("skincheck9") == 1)
        {
            Destroy(Skin9);
        }
        if (PlayerPrefs.GetInt("skincheck10") == 1)
        {
            Destroy(Skin10);
        }
        if (PlayerPrefs.GetInt("skincheck11") == 1)
        {
            Destroy(Skin11);
        }
        if (PlayerPrefs.GetInt("skincheck12") == 1)
        {
            Destroy(Skin12);
        }
    }

    public void dele1()
    {
        if(Player.credit > 100)
        {
            PlayerPrefs.SetInt("skincheck1", 1);
            Player.credit -= 100;
            Destroy(this.gameObject);
        }
    }
    public void dele2()
    {
        if (Player.credit > 100)
        {
            PlayerPrefs.SetInt("skincheck2", 1);
            Player.credit -= 100;
            Destroy(this.gameObject);
        }
    }
    public void dele3()
    {
        if (Player.credit > 100)
        {
            PlayerPrefs.SetInt("skincheck3", 1);
            Player.credit -= 100;
            Destroy(this.gameObject);
        }
    }
    public void dele4()
    {
        if (Player.credit > 100)
        {
            PlayerPrefs.SetInt("skincheck4", 1);
            Player.credit -= 100;
            Destroy(this.gameObject);
        }
    }
    public void dele5()
    {
        if (Player.credit > 200)
        {
            PlayerPrefs.SetInt("skincheck5", 1);
            Player.credit -= 200;
            Destroy(this.gameObject);
        }
    }
    public void dele6()
    {
        if (Player.credit > 200)
        {
            PlayerPrefs.SetInt("skincheck6", 1);
            Player.credit -= 200;
            Destroy(this.gameObject);
        }
    }
    public void dele7()
    {
        if (Player.credit > 200)
        {
            PlayerPrefs.SetInt("skincheck7", 1);
            Player.credit -= 200;
            Destroy(this.gameObject);
        }
    }
    public void dele8()
    {
        if (Player.credit > 200)
        {
            PlayerPrefs.SetInt("skincheck8", 1);
            Player.credit -= 200;
            Destroy(this.gameObject);
        }
    }
    public void dele9()
    {
        if (Player.credit > 300)
        {
            PlayerPrefs.SetInt("skincheck9", 1);
            Player.credit -= 300;
            Destroy(this.gameObject);
        }
    }
    public void dele10()
    {
        if (Player.credit > 300)
        {
            PlayerPrefs.SetInt("skincheck10", 1);
            Player.credit -= 300;
            Destroy(this.gameObject);
        }
    }
    public void dele11()
    {
        if (Player.credit > 300)
        {
            PlayerPrefs.SetInt("skincheck11", 1);
            Player.credit -= 300;
            Destroy(this.gameObject);
        }
    }
    public void dele12()
    {
        if (Player.credit > 300)
        {
            PlayerPrefs.SetInt("skincheck12", 1);
            Player.credit -= 300;
            Destroy(this.gameObject);
        }
    }

}
