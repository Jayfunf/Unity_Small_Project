using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditManager : MonoBehaviour
{

    public TextMeshProUGUI credit_Num;

    public GameObject CreditNor;
    public GameObject CreditSet;

    public float productionTime;

    private int credit = 0;


    void Start()
    {
        credit = PlayerPrefs.GetInt("Credit_Num", 0);
        StartCoroutine("ObstaclePro");
    }

    void Update()
    {
        credit_Num.text = "" + credit.ToString();
        PlayerPrefs.SetInt("Credit_Num", credit);

    }

    IEnumerator ObstaclePro()
    {
        Obstacle();
        yield return new WaitForSeconds(productionTime);
        StartCoroutine("ObstaclePro");
    }
    void Obstacle()
    {
        GameObject obstacle = Instantiate(CreditNor) as GameObject;
        obstacle.transform.parent = CreditSet.transform;
        obstacle.transform.position = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, 0);
    }

}
