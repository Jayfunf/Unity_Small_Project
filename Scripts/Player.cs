using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour
{
    public GameObject deadEffect;

    GameManager gameManager;
    AdMobScreen adad;

    public float speed;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestscoreText;
    public TextMeshProUGUI credit_Num;
    public TextMeshProUGUI RscoreText;
    public TextMeshProUGUI RbestscoreText;
    float score = 0f;
    float highscore = 0f;
    float Rscore = 0f;
    float Rhighscore = 0f;

    public AudioClip CreditSound1;
    public AudioClip OBSSound1;
    public AudioClip CircleSound1;

    public static int credit = 0;

    public static int skin =0;
    public Sprite Mainskin;
    public Sprite skin1;
    public Sprite skin2;
    public Sprite skin3;
    public Sprite skin4;
    public Sprite skin5;
    public Sprite skin6;
    public Sprite skin7;
    public Sprite skin8;
    public Sprite skin9;
    public Sprite skin10;
    public Sprite skin11;
    public Sprite skin12;

    public GameObject adbt;

    private SpriteRenderer spriteRenderer;

    bool isDead = false;

    void Start()
    {
        bestscoreText.text = PlayerPrefs.GetFloat("BestScore",0f).ToString();
        RbestscoreText.text = PlayerPrefs.GetFloat("RBestScore", 0f).ToString();
        credit = PlayerPrefs.GetInt("Credit_Num", 0);

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Mainskin;
    }
    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (isDead == true) return;
        //credit = PlayerPrefs.GetInt("Credit_Num", 0);
        score += Time.deltaTime;
        scoreText.text = "" + (Mathf.Floor(score * 1) / 1).ToString();
        Rscore = score;
        Rhighscore = highscore;
        credit_Num.text = ""+ credit.ToString();
        RscoreText.text = "" + (Mathf.Floor(score * 1) / 1).ToString();

        PlayerPrefs.SetInt("Credit_Num", credit);

        if (score > PlayerPrefs.GetFloat("BestScore", 0f))
        {
            PlayerPrefs.SetFloat("BestScore", Mathf.Floor(score * 1) / 1);
            bestscoreText.text = "" + (Mathf.Floor(score * 1) / 1).ToString();
        }
        if (score > PlayerPrefs.GetFloat("RBestScore", 0f))
        {
            PlayerPrefs.SetFloat("RBestScore", Mathf.Floor(score * 1) / 1);
            RbestscoreText.text = "" + (Mathf.Floor(score * 1) / 1).ToString();
        }

        if (skin == 1)
        {
            spriteRenderer.sprite = skin1;
        }
        if (skin == 2)
        {
            spriteRenderer.sprite = skin2;
        }
        if (skin == 3)
        {
            spriteRenderer.sprite = skin3;
        }
        if (skin == 4)
        {
            spriteRenderer.sprite = skin4;
        }
        if (skin == 5)
        {
            spriteRenderer.sprite = skin5;
        }
        if (skin == 6)
        {
            spriteRenderer.sprite = skin6;
        }
        if (skin == 7)
        {
            spriteRenderer.sprite = skin7;
        }
        if (skin == 8)
        {
            spriteRenderer.sprite = skin8;
        }
        if (skin == 9)
        {
            spriteRenderer.sprite = skin9;
        }
        if (skin == 10)
        {
            spriteRenderer.sprite = skin10;
        }
        if (skin == 11)
        {
            spriteRenderer.sprite = skin11;
        }
        if (skin == 12)
        {
            spriteRenderer.sprite = skin12;
        }

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Circle")
        {
            transform.localScale += new Vector3(0.01F, 0.01f, 0);

            Destroy(other.gameObject);
            GetComponent<AudioSource>().clip = CircleSound1;
            GetComponent<AudioSource>().Play();
        }
        if(other.gameObject.tag == "Wall")
        {
            Dead();
            GetComponent<AudioSource>().clip = OBSSound1;
            GetComponent<AudioSource>().Play();
        }

        if (other.gameObject.tag == "Credit")
        {
            Destroy(other.gameObject);
            credit+=1;
            GetComponent<AudioSource>().clip = CreditSound1;
            GetComponent<AudioSource>().Play();
        }
    }

    void Dead()
    {
        isDead = true;

        Destroy(Instantiate(deadEffect, transform.position, Quaternion.identity), 0.5f);

        gameManager.CallGameOver();

        Rscore = score;

        if(Rscore % 2 < 1)
        {
            adbt.SetActive(true);
        }
        Debug.Log("score" + Rscore%2);

    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }

}
