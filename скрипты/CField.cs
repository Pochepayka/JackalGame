using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CField
{
    public bool first = false;
    public int type = -1;
    public bool first_tap = true;
    public int continuing = 0;
    public bool is_arrow = false;
    public bool prot = false;
    //public bool hasupper = false;
    public bool working = true;
    public bool condition = false;
    public int orintation = 0;
    public int RemainingCoins;
    public int coins = 0;
    public int x, z;
    public bool tapped = false;
    public bool tappedu = false;
    public bool opened = false;
    public int repeatedmoves = 0;
    public GameObject obj;
    //public GameObject obj = new GameObject();
    public GameObject upper;
    public CField(GameObject obj0)
    {
        obj = obj0;
    }
    public void tap()
    {
        tapped = true;
    }
    public void tapu()
    {
        tappedu = true;
    }

    public void open()
    {
        if (first)
        {
            opened = true;
            condition = true;
            RemainingCoins = coins;
        }
        first = false;
        switch (type)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                is_arrow = true;
                break;
            case 6:
                is_arrow = true;
                break;
            case 7:
                is_arrow = true;
                break;
            case 8:
                is_arrow = true;
                break;
            case 9:
                is_arrow = true;
                break;
            case 10:
                is_arrow = true;
                break;
            case 11:
                is_arrow = true;
                break;
            case 12:
                is_arrow = true;
                break;
            case 13:
                continuing = -2;
                break;
            case 14:
                continuing = 1;
                break;
            case 15:
                continuing = 2;
                break;
            case 16:
                continuing = 3;
                break;
            case 17:
                continuing = 4;
                break;
            case 18:
                continuing = 10; //rum
                break;
            case 19:
                is_arrow = true;
                break;
            case 20:
                is_arrow = true;
                break;
            case 21:
                is_arrow = true;
                break;
            case 22:
                coins = 1;
                break;
            case 23:
                coins = 2;
                break;
            case 24:
                coins = 3;
                break;
            case 25:
                coins = 4;
                break;
            case 26:
                coins = 5;
                break;
            case 27:
                prot = true;
                break;
            case 28:
                prot = true;
                break;
            case 29:
                //is_arrow = true;
                break;
            case 30:
                continuing = -1;
                break;
            case 31:
                is_arrow = true;
                break;
        }

    }
    public void open1()
    {
        if (first)
        {
            //opened = true;
            condition = true;
            RemainingCoins = coins;
        }
        first = true;
        switch (type)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                is_arrow = true;
                break;
            case 6:
                is_arrow = true;
                break;
            case 7:
                is_arrow = true;
                break;
            case 8:
                is_arrow = true;
                break;
            case 9:
                is_arrow = true;
                break;
            case 10:
                is_arrow = true;
                break;
            case 11:
                is_arrow = true;
                break;
            case 12:
                is_arrow = true;
                break;
            case 13:
                continuing = -2;
                break;
            case 14:
                continuing = 1;
                break;
            case 15:
                continuing = 2;
                break;
            case 16:
                continuing = 3;
                break;
            case 17:
                continuing = 4;
                break;
            case 18:
                continuing = 10; //rum
                break;
            case 19:
                is_arrow = true;
                break;
            case 20:
                is_arrow = true;
                break;
            case 21:
                is_arrow = true;
                break;
            case 22:
                coins = 1;
                break;
            case 23:
                coins = 2;
                break;
            case 24:
                coins = 3;
                break;
            case 25:
                coins = 4;
                break;
            case 26:
                coins = 5;
                break;
            case 27:
                prot = true;
                break;
            case 28:
                prot = true;
                break;
            case 29:
                //is_arrow = true;
                break;
            case 30:
                continuing = -1;
                break;
            case 31:
                is_arrow = true;
                break;
        }
        //RemainingCoins = coins;
    }
    /*public void open1()
    {
        if (first)
        {
            opened = true;
            condition = true;
        }
        first = false;
        switch (type)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                is_arrow = true;
                break;
            case 6:
                is_arrow = true;
                break;
            case 7:
                is_arrow = true;
                break;
            case 8:
                is_arrow = true;
                break;
            case 9:
                is_arrow = true;
                break;
            case 10:
                is_arrow = true;
                break;
            case 11:
                is_arrow = true;
                break;
            case 12:
                is_arrow = true;
                break;
            case 13:
                continuing = -2;
                break;
            case 14:
                continuing = 1;
                break;
            case 15:
                continuing = 2;
                break;
            case 16:
                continuing = 3;
                break;
            case 17:
                continuing = 4;
                break;
            case 18:
                continuing = 10; //rum
                break;
            case 19:
                is_arrow = true;
                break;
            case 20:
                is_arrow = true;
                break;
            case 21:
                is_arrow = true;
                break;
            case 22:
                coins = 1;
                break;
            case 23:
                coins = 2;
                break;
            case 24:
                coins = 3;
                break;
            case 25:
                coins = 4;
                break;
            case 26:
                coins = 5;
                break;
            case 27:
                prot = true;
                break;
            case 28:
                prot = true;
                break;
            case 29:
                is_arrow = true;
                break;
            case 30:
                continuing = -1;
                break;
            case 31:
                is_arrow = true;
                break;
        }
        RemainingCoins = coins;
    }*/
    public void work()
    {
        working = false;
    }
    public void Type(int t)
    {
        type = t;
    }
    public void Orintation(int o)
    {
        orintation = o;
    }

    public void defineC()  //not ended
    {
        if (type == 0)
        {
            continuing = 0;
        }
    }

    public void fault()
    {

        first = false;
        type = -1;
        first_tap = true;
        continuing = 0;
        is_arrow = false;
        prot = false;
        //public bool hasupper = false;
        working = true;
        condition = false;
        orintation = 0;
        coins = 0;
        tapped = false;
        tappedu = false;
        opened = false;
        repeatedmoves = 0;
    }
}