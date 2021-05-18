using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChange : MonoBehaviour
{
    public Sprite MainSprite;
    public Sprite Pskin1;
    public Sprite Pskin2;
    public Sprite Pskin3;
    private SpriteRenderer spriteRenderer;

    Player playerScripts;

    int sprite = 0;


    private void Awake()
    {
        playerScripts = GameObject.Find("skin").GetComponent<Player>();
    }

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = MainSprite;
    }

    public void skin1()
    {
        Player.skin = 1;
    }
    public void skin2()
    {
        Player.skin = 2;
    }
    public void skin3()
    {
        Player.skin = 3;
    }
    public void skin4()
    {
        Player.skin = 4;
    }
    public void skin5()
    {
        Player.skin = 5;
    }
    public void skin6()
    {
        Player.skin = 6;
    }
    public void skin7()
    {
        Player.skin = 7;
    }
    public void skin8()
    {
        Player.skin = 8;
    }
    public void skin9()
    {
        Player.skin = 9;
    }
    public void skin10()
    {
        Player.skin = 10;
    }
    public void skin11()
    {
        Player.skin = 11;
    }
    public void skin12()
    {
        Player.skin = 12;
    }

}
