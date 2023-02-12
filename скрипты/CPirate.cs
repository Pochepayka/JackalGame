using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPirate
{
    public bool tapped = false;
    public bool dead = false;
    public bool drunk = false;
    public bool trapped = false;
    public bool frsttime = true;
    public int x, z, x1, z1;
    public int dx, dz;
    public bool moving = false;
    public int team;
    public int QuanToGo = 0;
    public int side = 10;
    public int timespent = 0;
    public int mq = 0;
    public int xbeg;
    public int zbeg;
    public int am = 0;
    public bool is_ship = false;
    public bool has_coin = false;
    public bool untrapped = false;
    public GameObject Pirate = new GameObject();
    public bool shadowpriest = false;
    public CPirate(int xx, int zz, int teamm, GameObject Pie)
    {
        x = xx;
        z = zz;
        team = teamm;
        Pirate = Pie;
    }
    public void ressurect()
    {
        Pirate.SetActive(true);
    }
    public void tap()
    {
        tapped = true;
    }
    public void Death()
    {
        Pirate.SetActive(false);
    }
    public void move(int x11, int z11)
    {
        x1 = x;
        z1 = z;
        x = x11;
        z = z11;
    }
    public void lastmove(int x11, int z11)
    {
        xbeg = x11;
        zbeg = z11;
    }
    public void Generalize()
    {
        Pirate.transform.Translate((dx) * side, 0, (dz) * side);
        //tapped = false;
    }

    public void fault()
    {

        tapped = false;
        dead = false;
        drunk = false;
        trapped = false;
        frsttime = true;
        moving = false;
        QuanToGo = 0;
        side = 10;
        timespent = 0;
        mq = 0;
        am = 0;
        is_ship = false;
        has_coin = false;
        untrapped = false;
        shadowpriest = false;

    }
}