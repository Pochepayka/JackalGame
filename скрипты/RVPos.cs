using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RVPos
{

    //FPos helper;

    public CField[,] RVField;
    public CPirate[,] RVPizza;
    public CCoin[] RVest;
    public int[][] RVCoQuan;
    public int[] RVCCondi;
    public int MQuan;

    bool can_die = false;
    bool swim_only_forward = false;
    bool hidden_field = false;
    bool unlimited_plane = false;
    bool steply_rotation = false;
    bool sequence = false;
    bool unlimited_moving = false;

    public void Create(CField[,] Fiel, CPirate[,] Pizz, CCoin[] Ches, int MovesQuan, int[][] CoQuan, int[] CoinCOndi)
    {
        RVField = Fiel;
        RVPizza = Pizz;
        RVest = Ches;
        MQuan = MovesQuan;
        RVCoQuan = CoQuan;
        RVCCondi = CoinCOndi;
    }

    /*
    public void Empty()
    {
        //Creates a random-made Fields
 

    }
    public void LoadOut()
    {
        //here file output
    }
    public void LoadIn()
    {
        //here file input
    }
    */
}

