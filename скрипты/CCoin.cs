using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCoin
{
    public Vector3 CoinStartPosition = new Vector3(0, 0, 0);
    public float startposx;
    public float startposz;
    public int Startci;
    public int Startcj;
    public int ci;
    public int cj;
    public bool chosen = false;
    public CPirate owner;
    public GameObject coin;
    public float level;
    public float thick = 0.3f;
    public bool used = false;
    public bool opened = false;
    public int on_the_field = 1;
    public int cointimespent = 0;
    public CCoin(GameObject ccoinn, float levvel)
    {
        coin = ccoinn;
        level = levvel;
    }


    public void DefineM(int cci, int ccj)
    {
        ci = cci;
        cj = ccj;
    }

    public void Chose(CPirate pie)
    {
        owner = pie;
        chosen = true;
    }

    public void UpPos()
    {
        coin.transform.position =
            owner.Pirate.transform.position;
    }

    public void Reveal(CField field)
    {
        coin.SetActive(true);
    }

    public void fault()
    {


        chosen = false;
        thick = 0.3f;
        used = false;
        opened = false;
        on_the_field = 1;

    }
}