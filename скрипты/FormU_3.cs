using UnityEngine;
using System.Threading;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System;
using System.Collections.Specialized;

public class FormU_3 : MonoBehaviour
{

    public PUN pun;

    /*
    public int x = 0;
    public int y = 0;
    public int k = 0;
    public void Main(string[] args)
    {
         
        using (StreamWriter writer = new StreamWriter("D:/JFA/проекты/в работе/Jackal_0.3 (+ дизайн, + оффлайн)/Assets/Assetse/Input-Output/input.txt"))
        {
            string line1 = "1";
            writer.WriteLine(line1);
            string line2 = "4";
            writer.WriteLine(line2);
            string line3 = "2";
            writer.WriteLine(line3);

        }

        using (StreamReader reader = new StreamReader("D:/JFA/проекты/в работе/Jackal_0.3 (+ дизайн, + оффлайн)/Assets/Assetse/Input-Output/input.txt"))
        {
            
            x = Convert.ToInt32(reader.ReadLine());
            
            y = Convert.ToInt32(reader.ReadLine());
            
            k = Convert.ToInt32(reader.ReadLine());
            print("x=");
            print(x);
            print("y=");
            print(y);
            print("k=");
            print(k);
        }
    }//*/
    public bool whiteeliminated = false;
    public bool blackeliminated = false;
    public bool redeliminated = false;
    public bool yelloweliminated = false;
    public bool blok = false;
    public bool blok2 = false;
    public bool blok3 = false;
    public bool save = false;
    public bool obzor = false;
    public bool planeisused = false;
    public bool ArseniyIsALazyDumbStubbornBitch = true;
    public bool allwhitedied = false;
    public bool allreddied = false;
    public bool allblackdied = false;
    public bool allyellowdied = false;
    public bool iz2 = true;
    public bool a = false;
    public bool z = true;
    public bool can_die = true;
    public bool swim_only_forward = true;
    public bool hidden_field = true;
    public bool unlimited_plane = true;
    public bool steply_rotation = true;
    public bool sequence = true;
    public bool unlimited_moving = true;
    public bool russin = false;
    public bool english = true;
    public bool Win = false;
    bool z0 = true;
    public bool Indic = false;
    public float thickth = 0.3f;
    public float t = 0.0f;
    public float q1 = 0f;
    public float q2 = 0f;
    public float q3 = 0f;
    public float q4 = 0f;
    public float x1 = 0f;
    // public float y1 = 0f;
    public float z1 = -10f;
    public float x2 = 10f;
    // public float y2 = 0f;
    public float z2 = -10f;
    public float x3 = 10f;
    // public float y3 = 0f;
    public float z3 = 0f;
    public float x4 = 10f;
    // public float y4 = 0f;
    public float z4 = 10f;
    public float x5 = 0f;
    //public float y5 = 0f;
    public float z5 = 10f;
    public float x6 = -10f;
    //public float y6 = 0f;
    public float z6 = 10f;
    public float x7 = 0f;
    // public float y7 = 0f;
    public float z7 = -10f;
    public float x8 = -10f;
    //public float y8 = 0f;
    public float z8 = -10f;
    public float winer = 0f;
    public float sum = 37f;
    public float s1 = 0f;
    public float s2 = 0f;
    public float sumpole = 37f;
    public int trophy = 0;
    public int win_menu = 0;
    public int money = 0;
    public int win1 = 0;
    public int win2 = 0;
    public int n_win = 0;
    public int musss;
    public int souuu;
    public int lannn;
    public int MovesQuan;
    public int Mode = -1;
    public int[][] CoinsQuan;
    public int[] CoinCondi;
    public int Vobla;
    public int Arseniy = 0;
    public int p1 = 0;
    public int p2 = 0;
    public int p3 = 0;
    public int p4 = 0;
    public int m1 = 0;
    public int m2 = 0;
    public int m3 = 0;
    public int m4 = 0;
    public int m5 = 0;
    public int m6 = 0;
    public int m7 = 0;
    public int m8 = 0;
    public int m9 = 0;
    public int m10 = 0;
    public int a1 = 0;
    public int a2 = 0;
    public int a3 = 0;
    public int a4 = 0;
    public int[,] field;
    public int l = 1; //true- not the first enter    false- first enter
    float xx = 0f;
    float yy = 0f;
    float zz = 0f;
    float yyy = 0f;
    int r = 0;
    int n = 7;
    public string name = "Name";
    public buttton button;
    public buttton offline;
    public buttton offline2;
    // public GameObject of;
    public bool off = false;
    public bool off2 = false;

    public buttton online;
    public buttton online2;
    //public GameObject on;
    public bool onl = false;
    public bool onl2 = false;

    public buttton onlain_1x1x1x1;
    // public GameObject on_1x1x1x1;
    public bool onl_1x1x1x1 = false;
    //public bool onl_1x1x1x1_2 = true;

    public buttton offlain_1x1x1x1;
    // public GameObject of_1x1x1x1;
    public bool off_1x1x1x1 = false;
    //public bool off_1x1x1x1_2 = true;

    public buttton onlain_1x1;
    //public GameObject on_1x1;
    public bool onl_1x1 = false;
    // public bool onl_1x1_2 = true;

    public buttton offlain_1x1;
    // public GameObject of_1x1;
    public bool off_1x1 = false;
    // public bool off_1x1_2 = true;

    public buttton sound_on;
    public buttton sound_on2;
    // public GameObject so_on;
    public bool sou_on = false;
    public bool sou_on2 = false;

    public buttton sound_off;
    public buttton sound_off2;
    //public GameObject so_off;
    public bool sou_off = false;
    public bool sou_off2 = false;

    public buttton music_on;
    public buttton music_on2;
    //public GameObject mu_on;
    public bool mus_on = false;
    public bool mus_on2 = false;

    public buttton music_off;
    public buttton music_off2;
    // public GameObject mu_off;
    public bool mus_off = false;
    public bool mus_off2 = false;

    public buttton RUSS;
    //public GameObject RU;
    public bool RUS = false;

    public buttton ENGG;
    //public GameObject EN;
    public bool ENG = false;

    public buttton in_setting;
    // public GameObject in_se;
    public bool in_set = false;

    public buttton out_setting;
    // public GameObject out_se;
    public bool out_set = false;

    public buttton out_profile;
    //public GameObject in_pr;
    public bool out_pro = false;

    public buttton in_profile;
    //public GameObject in_pr;
    public bool in_pro = false;

    public buttton in_fight;
    //public GameObject in_pr;
    public bool in_fig = false;

    public buttton out_fight;
    //public GameObject in_pr;
    public bool out_fig = false;

    public buttton home;
    //public GameObject in_pr;
    public bool hom = false;

    public buttton daaa_exit;
    //public GameObject in_pr;
    public bool daa_exit = false;

    public buttton nett_exit;
    //public GameObject in_pr;
    public bool net_exit = false;

    public buttton otmena_exit;
    //public GameObject in_pr;
    public bool otm_exit = false;

    public buttton cencel_exit;
    //public GameObject in_pr;
    public bool cen_exit = false;

    public buttton yess_exit;
    //public GameObject in_pr;
    public bool yes_exit = false;

    public buttton nooo_exit;
    //public GameObject in_pr;
    public bool noo_exit = false;

    public buttton daaa_win;
    //public GameObject in_pr;
    public bool daa_win = false;

    public buttton nett_win;
    //public GameObject in_pr;
    public bool net_win = false;

    public buttton obzor_win;
    //public GameObject in_pr;
    public bool obz_win = false;

    public buttton survay_win;
    //public GameObject in_pr;
    public bool sur_win = false;

    public buttton yess_win;
    //public GameObject in_pr;
    public bool yes_win = false;

    public buttton nooo_win;
    public bool noo_win = false;

    public buttton dalee_z;
    public bool dal_z = false;

    public buttton yess_exit_gl;
    //public GameObject in_pr;
    public bool yes_exit_gl = false;

    public buttton nooo_exit_gl;
    //public GameObject in_pr;
    public bool noo_exit_gl = false;

    public buttton daaa_exit_gl;
    //public GameObject in_pr;
    public bool daa_exit_gl = false;

    public buttton nett_exit_gl;
    //public GameObject in_pr;
    public bool net_exit_gl = false;

    public buttton crest_1x1_1;
    public bool cre_1x1_1 = false;
    public buttton crest_1x1_2;
    public bool cre_1x1_2 = false;
    public buttton crest_1x1_3;
    public bool cre_1x1_3 = false;
    public buttton crest_1x1_4;
    public bool cre_1x1_4 = false;
    public buttton crest_1x1_5;
    public bool cre_1x1_5 = false;
    public buttton crest_1x1_6;
    public bool cre_1x1_6 = false;
    public buttton crest_1x1x1x1_1;
    public bool cre_1x1x1x1_1 = false;
    public buttton crest_1x1x1x1_2;
    public bool cre_1x1x1x1_2 = false;
    public buttton crest_1x1x1x1_3;
    public bool cre_1x1x1x1_3 = false;
    public buttton crest_1x1x1x1_4;
    public bool cre_1x1x1x1_4 = false;
    public buttton crest_1x1x1x1_5;
    public bool cre_1x1x1x1_5 = false;
    public buttton crest_1x1x1x1_6;
    public bool cre_1x1x1x1_6 = false;
    public buttton crest_1x1x1x1_7;
    public bool cre_1x1x1x1_7 = false;
    public buttton crest_1x1x1x1_8;
    public bool cre_1x1x1x1_8 = false;
    public buttton crest_1x1x1x1_9;
    public bool cre_1x1x1x1_9 = false;
    public buttton crest_1x1x1x1_10;
    public bool cre_1x1x1x1_10 = false;
    public buttton crest_1x1x1x1_11;
    public bool cre_1x1x1x1_11 = false;
    public buttton crest_1x1x1x1_12;
    public bool cre_1x1x1x1_12 = false;
    

    /// <summary>
    /// 1х1 и 1х1х1х1 не прописал
    /// </summary>


    public GameObject[,] Lightn;

    
    //public 

    public RVPos Position;
    //public FPos HPosition;

    public GameObject[][,] Crosses;

    //CoinCondi is a massve,
    //in which we can see,
    // if coin is on the field or not


    //CoinsQuan is a massive, which has 
    //money from m1, m2, m3 etc.

    /*
    public float[,] Pirates_Standing;
    //This massive helps pirates to stand normal on the ceil.
    //The first argument means the type of the Pirate
    //The second means the type of ceil*/
    IEnumerator SmoothMove(Vector3 startPos, Vector3 endPos, float time)
    {
        float currTime = 0;
        do
        {
            this.transform.position = Vector3.Lerp(startPos, endPos, currTime / time);
            currTime += Time.deltaTime;
            yield return null;
        }
        while (currTime <= time);
    }
    public CCoin[] Chest;
    

    public GameObject HandCoinWh;
    public GameObject HandCoinBl;
    public GameObject HandCoinRe;
    public GameObject HandCoinYe;


    public CCoin Coin1;
    public CCoin Coin2;
    public CCoin Coin3;
    public CCoin Coin4;
    public CCoin Coin5;
    public CCoin Coin6;
    public CCoin Coin7;
    public CCoin Coin8;
    public CCoin Coin9;
    public CCoin Coin10;
    public CCoin Coin11;
    public CCoin Coin12;
    public CCoin Coin13;
    public CCoin Coin14;
    public CCoin Coin15;
    public CCoin Coin16;
    public CCoin Coin17;
    public CCoin Coin18;
    public CCoin Coin19;
    public CCoin Coin20;
    public CCoin Coin21;
    public CCoin Coin22;
    public CCoin Coin23;
    public CCoin Coin24;
    public CCoin Coin25;
    public CCoin Coin26;
    public CCoin Coin27;
    public CCoin Coin28;
    public CCoin Coin29;
    public CCoin Coin30;
    public CCoin Coin31;
    public CCoin Coin32;
    public CCoin Coin33;
    public CCoin Coin34;
    public CCoin Coin35;
    public CCoin Coin36;
    public CCoin Coin37;

    public GameObject Coi1;
    public GameObject Coi2;
    public GameObject Coi3;
    public GameObject Coi4;
    public GameObject Coi5;
    public GameObject Coi6;
    public GameObject Coi7;
    public GameObject Coi8;
    public GameObject Coi9;
    public GameObject Coi10;
    public GameObject Coi11;
    public GameObject Coi12;
    public GameObject Coi13;
    public GameObject Coi14;
    public GameObject Coi15;
    public GameObject Coi16;
    public GameObject Coi17;
    public GameObject Coi18;
    public GameObject Coi19;
    public GameObject Coi20;
    public GameObject Coi21;
    public GameObject Coi22;
    public GameObject Coi23;
    public GameObject Coi24;
    public GameObject Coi25;
    public GameObject Coi26;
    public GameObject Coi27;
    public GameObject Coi28;
    public GameObject Coi29;
    public GameObject Coi30;
    public GameObject Coi31;
    public GameObject Coi32;
    public GameObject Coi33;
    public GameObject Coi34;
    public GameObject Coi35;
    public GameObject Coi36;
    public GameObject Coi37;


    public CPirate ShipWhi;
    public CPirate ShipBla;
    public CPirate ShipYel;
    public CPirate ShipRed;
    public CPirate Pie1;
    public CPirate Pie2;
    public CPirate Pie3;
    public CPirate Pie4;
    public CPirate Pie5;
    public CPirate Pie6;
    public CPirate Pie7;
    public CPirate Pie8;
    public CPirate Pie9;
    public CPirate Pie10;
    public CPirate Pie11;
    public CPirate Pie12;


    public CPirate[,] Pizza;



    public GameObject Pir1;
    public GameObject Pir2;
    public GameObject Pir3;
    public GameObject Pir4;
    public GameObject Pir5;
    public GameObject Pir6;
    public GameObject Pir7;
    public GameObject Pir8;
    public GameObject Pir9;
    public GameObject Pir10;
    public GameObject Pir11;
    public GameObject Pir12;
    

    public GameObject menu;
    public GameObject menu_fight;
    public GameObject MainCamera;
    public GameObject button_1x1_1x1x1x1_online;
    public GameObject button_1x1_1x1x1x1_offine;
    public GameObject button_Online_offline;
    public GameObject Setting_OFF;
    public GameObject Setting_ON;
    //public GameObject in_setting;
    //public GameObject out_setting;
    public GameObject Music_vkl;
    public GameObject Music_vikl;
    public GameObject Sound_vkl;
    public GameObject Sound_vikl;
    public GameObject Music_on;
    public GameObject Music_off;
    public GameObject Sound_on;
    public GameObject Sound_off;
    public GameObject Language_rus;
    public GameObject Language_eng;
    public GameObject Rus1_setting;
    public GameObject Rus2_online;
    public GameObject Rus3_profil;
    public GameObject Rus4_1x1;
    public GameObject Rus5_1x1x1x1;
    public GameObject Rus6_exit;
    public GameObject Rus7_win;
    public GameObject Rus8_exit_gl;
    public GameObject Eng1_setting;
    public GameObject Eng2_online;
    public GameObject Eng3_profil;
    public GameObject Eng4_1x1;
    public GameObject Eng5_1x1x1x1;
    public GameObject Eng6_exit;
    public GameObject Eng7_win;
    public GameObject Eng8_exit_gl;
    public GameObject MF_1x1;
    public GameObject MF_1x1x1x1;
    public GameObject Profile_on;
    public GameObject Fight_on;
    public GameObject Fight_off;
    public GameObject exit_on;
    public GameObject exit_gl;
    public GameObject win_on;
    public GameObject Music;
    public GameObject Sound;
    public GameObject Znakomstvo;


    public Text Trophy_main;
    public Text Money_main;
    public Text Trophy_profile;
    public Text Win1_profile;
    public Text Win2_profile;
    public Text Name_profile;
    public Text PlayerN_win;
    public Text IgrokN_win;
    public Text M_1x1_1;
    public Text M_1x1_2;
    public Text M_1x1x1x1_1;
    public Text M_1x1x1x1_2;
    public Text M_1x1x1x1_3;
    public Text M_1x1x1x1_4;
    public Text Name;



    public GameObject Obj15;
    public GameObject Obj17;
    public GameObject Obj73;
    public GameObject Obj74;
    public GameObject Obj75;
    public GameObject Obj76;
    public GameObject Obj90;
    public GameObject Obj91;
    public GameObject Obj92;
    public GameObject Obj93;
    public GameObject Obj94;
    public GameObject Obj95;
    public GameObject Obj96;
    public GameObject Obj97;
    public GameObject Obj98;
    public GameObject Obj99;
    public GameObject Obj100;
    public GameObject Obj101;
    public GameObject Obj102;
    public GameObject Obj103;
    public GameObject Obj104;
    public GameObject Obj105;

    public GameObject Obj125;
    public GameObject Obj126;
    public GameObject Obj127;
    public GameObject Obj128;
    public GameObject Obj129;
    public GameObject Obj130;
    public GameObject Obj131;
    public GameObject Obj132;
    public GameObject Obj133;
    public GameObject Obj134;
    public GameObject Obj135;
    public GameObject Obj136;
    public GameObject Obj137;
    public GameObject Obj138;
    public GameObject Obj139;
    public GameObject Obj140;
    public GameObject Obj141;
    public GameObject Obj142;
    public GameObject Obj143;
    public GameObject Obj144;
    public GameObject Obj145;
    public GameObject Obj146;
    public GameObject Obj147;
    public GameObject Obj148;
    public GameObject Obj149;
    public GameObject Obj150;
    public GameObject Obj151;
    public GameObject Obj152;
    public GameObject Obj153;
    public GameObject Obj154;
    public GameObject Obj155;
    public GameObject Obj156;
    public GameObject Obj157;
    public GameObject Obj158;
    public GameObject Obj159;
    public GameObject Obj160;
    public GameObject Obj161;
    public GameObject Obj162;
    public GameObject Obj163;
    public GameObject Obj164;
    public GameObject Obj165;
    public GameObject Obj166;
    public GameObject Obj167;
    public GameObject Obj168;
    public GameObject Obj169;
    public GameObject Obj170;
    public GameObject Obj171;
    public GameObject Obj172;
    public GameObject Obj173;

    public GameObject Obj186;
    public GameObject Obj187;
    public GameObject Obj188;
    public GameObject Obj189;
    public GameObject Obj190;
    public GameObject Obj191;
    public GameObject Obj192;
    public GameObject Obj193;
    public GameObject Obj194;
    public GameObject Obj195;
    public GameObject Obj196;
    public GameObject Obj197;
    public GameObject Obj198;
    public GameObject Obj199;
    public GameObject Obj200;
    public GameObject Obj201;
    public GameObject Obj202;
    public GameObject Obj203;
    public GameObject Obj204;
    public GameObject Obj205;
    public GameObject Obj206;
    public GameObject Obj231;
    public GameObject Obj232;
    public GameObject Obj233;
    public GameObject Obj234;
    public GameObject Obj236;
    public GameObject Obj237;
    public GameObject Obj238;
    public GameObject Obj239;
    public GameObject Obj240;
    public GameObject Obj241;
    public GameObject Obj242;
    public GameObject Obj246;
    public GameObject Obj247;
    public GameObject Obj248;
    public GameObject Obj249;
    public GameObject Obj250;
    public GameObject Obj251;
    public GameObject Obj252;
    public GameObject Obj282;
    public GameObject Obj283;
    public GameObject Obj284;
    public GameObject Obj287;
    public GameObject Obj288;
    public GameObject Obj289;
    public GameObject Obj290;
    public GameObject Obj291;
    public GameObject Obj292;
    public GameObject Obj293;
    public GameObject Obj304;
    public GameObject Obj305;
    public GameObject Obj306;
    public GameObject Obj307;
    public GameObject Obj308;
    public GameObject Obj309;
    public GameObject Obj310;
    public GameObject Obj311;
    public GameObject Obj312;
    public GameObject Obj313;
    public GameObject Obj314;
    public GameObject Obj315;
    public GameObject Obj316;
    public GameObject Obj317;
    public GameObject Obj318;
    public GameObject Obj319;
    public GameObject Obj320;
    public GameObject Obj321;
    public GameObject Obj322;
    public GameObject Obj323;
    public GameObject Obj324;
    public GameObject Obj325;
    public GameObject Obj326;
    public GameObject Obj327;
    public GameObject Obj328;
    public GameObject Obj329;
    public GameObject Obj330;
    public GameObject Obj331;
    public GameObject Obj332;
    public GameObject Obj333;
    public GameObject Obj334;
    public GameObject Obj335;

    public GameObject Obj360;
    public GameObject Obj361;
    public GameObject Obj362;
    public GameObject Obj363;
    public GameObject Obj364;
    public GameObject Obj365;
    public GameObject Obj366;
    public GameObject Obj367;
    public GameObject Obj368;
    public GameObject Obj369;
    public GameObject Obj370;
    public GameObject Obj371;
    public GameObject Obj372;
    public GameObject Obj373;
    public GameObject Obj374;
    public GameObject Obj375;


    public GameObject Obj436;
    public GameObject Obj437;
    public GameObject Obj438;
    public GameObject Obj439;
    public GameObject Obj440;
    public GameObject Obj441;
    public GameObject Obj442;
    public GameObject Obj443;
    public GameObject Obj444;
    public GameObject Obj445;
    public GameObject Obj446;
    public GameObject Obj447;



    public GameObject L1;
    public GameObject L2;
    public GameObject L3;
    public GameObject L4;
    public GameObject L5;
    public GameObject L6;
    public GameObject L7;
    public GameObject L8;
    public GameObject L9;
    public GameObject L10;
    public GameObject L11;
    public GameObject L12;
    public GameObject L13;
    public GameObject L14;
    public GameObject L15;
    public GameObject L16;
    public GameObject L17;
    public GameObject L18;
    public GameObject L19;
    public GameObject L20;
    public GameObject L21;
    public GameObject L22;
    public GameObject L23;
    public GameObject L24;
    public GameObject L25;
    public GameObject L26;
    public GameObject L27;
    public GameObject L28;
    public GameObject L29;
    public GameObject L30;
    public GameObject L31;
    public GameObject L32;
    public GameObject L33;
    public GameObject L34;
    public GameObject L35;
    public GameObject L36;
    public GameObject L37;
    public GameObject L38;
    public GameObject L39;
    public GameObject L40;
    public GameObject L41;
    public GameObject L42;
    public GameObject L43;
    public GameObject L44;
    public GameObject L45;
    public GameObject L46;
    public GameObject L47;
    public GameObject L48;
    public GameObject L49;
    public GameObject L50;
    public GameObject L51;
    public GameObject L52;
    public GameObject L53;
    public GameObject L54;
    public GameObject L55;
    public GameObject L56;
    public GameObject L57;
    public GameObject L58;
    public GameObject L59;
    public GameObject L60;
    public GameObject L61;
    public GameObject L62;
    public GameObject L63;
    public GameObject L64;
    public GameObject L65;
    public GameObject L66;
    public GameObject L67;
    public GameObject L68;
    public GameObject L69;
    public GameObject L70;
    public GameObject L71;
    public GameObject L72;
    public GameObject L73;
    public GameObject L74;
    public GameObject L75;
    public GameObject L76;
    public GameObject L77;
    public GameObject L78;
    public GameObject L79;
    public GameObject L80;
    public GameObject L81;
    public GameObject L82;
    public GameObject L83;
    public GameObject L84;
    public GameObject L85;
    public GameObject L86;
    public GameObject L87;
    public GameObject L88;
    public GameObject L89;
    public GameObject L90;
    public GameObject L91;
    public GameObject L92;
    public GameObject L93;
    public GameObject L94;
    public GameObject L95;
    public GameObject L96;
    public GameObject L97;
    public GameObject L98;
    public GameObject L99;
    public GameObject L100;
    public GameObject L101;
    public GameObject L102;
    public GameObject L103;
    public GameObject L104;
    public GameObject L105;
    public GameObject L106;
    public GameObject L107;
    public GameObject L108;
    public GameObject L109;
    public GameObject L110;
    public GameObject L111;
    public GameObject L112;
    public GameObject L113;
    public GameObject L114;
    public GameObject L115;
    public GameObject L116;
    public GameObject L117;
    public GameObject L118;
    public GameObject L119;
    public GameObject L120;
    public GameObject L121;
    public GameObject L122;
    public GameObject L123;
    public GameObject L124;
    public GameObject L125;
    public GameObject L126;
    public GameObject L127;
    public GameObject L128;

    public GameObject L129;
    public GameObject L130;
    public GameObject L131;
    public GameObject L132;
    public GameObject L133;
    public GameObject L134;
    public GameObject L135;
    public GameObject L136;
    public GameObject L137;
    public GameObject L138;
    public GameObject L139;
    public GameObject L140;
    public GameObject L141;
    public GameObject L142;
    public GameObject L143;
    public GameObject L144;
    public GameObject L145;
    public GameObject L146;
    public GameObject L147;
    public GameObject L148;
    public GameObject L149;
    public GameObject L150;
    public GameObject L151;
    public GameObject L152;
    public GameObject L153;
    public GameObject L154;
    public GameObject L155;
    public GameObject L156;
    public GameObject L157;
    public GameObject L158;
    public GameObject L159;
    public GameObject L160;
    public GameObject L161;
    public GameObject L162;
    public GameObject L163;
    public GameObject L164;
    public GameObject L165;
    public GameObject L166;
    public GameObject L167;
    public GameObject L168;
    public GameObject L169;
    public GameObject L170;
    public GameObject L171;
    public GameObject L172;
    public GameObject L173;
    public GameObject L174;
    public GameObject L175;
    public GameObject L176;
    public GameObject L177;
    public GameObject L178;
    public GameObject L179;
    public GameObject L180;
    public GameObject L181;
    public GameObject L182;
    public GameObject L183;
    public GameObject L184;
    public GameObject L185;
    public GameObject L186;
    public GameObject L187;
    public GameObject L188;
    public GameObject L189;
    public GameObject L190;
    public GameObject L191;
    public GameObject L192;
    public GameObject L193;
    public GameObject L194;
    public GameObject L195;
    public GameObject L196;
    public GameObject L197;
    public GameObject L198;
    public GameObject L199;
    public GameObject L200;
    public GameObject L201;
    public GameObject L202;
    public GameObject L203;
    public GameObject L204;
    public GameObject L205;
    public GameObject L206;
    public GameObject L207;
    public GameObject L208;
    public GameObject L209;
    public GameObject L210;
    public GameObject L211;
    public GameObject L212;
    public GameObject L213;
    public GameObject L214;
    public GameObject L215;
    public GameObject L216;
    public GameObject L217;
    public GameObject L218;
    public GameObject L219;
    public GameObject L220;
    public GameObject L221;
    public GameObject L222;
    public GameObject L223;
    public GameObject L224;
    public GameObject L225;



    public Material Mat;
    public Material Mat1;
    public Material Mat2;
    public Material Mat3;
    public Material Mat4;
    public Material Mat5;
    public Material Mat6;
    public Material Mat7;
    public Material Mat8;
    public Material Mat9;
    public Material Mat10;
    public Material Mat11;
    public Material Mat12;
    public Material Mat13;
    public Material Mat14;
    public Material Mat15;
    public Material Mat16;
    public Material Mat17;
    public Material Mat18;
    public Material Mat19;
    public Material Mat20;
    public Material Mat21;
    public Material Mat22;
    public Material Mat23;
    //public FormU FormUu;
    public AudioSource audios;
    

    




    //public A IndiC;
    public Material mat0;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material mat5;
    public Material mat6;
    public Material mat7;
    public Material mat8;
    public Material mat9;
    public Material mat10;
    public Material mat11;
    public Material mat12;
    public Material mat13;
    public Material mat14;
    public Material mat15;
    public Material mat16;
    public Material mat17;
    public Material mat18;
    public Material mat19;
    public Material mat20;
    public Material mat21;
    public Material mat22;
    public Material mat23;
    public Material mat24;
    public Material mat25;
    public Material mat26;
    public Material mat27;
    public Material mat28;
    public Material mat29;
    public Material mat30;
    public Material mat31;
    public Material mat32;
    public Material mat33;
    public Material mat34;
    public Material mat35;
    public Material mat36;
    public Material mat37;
    public Material mat38;
    public Material mat39;
    public Material mat40;
    public Material mat41;


    public CField Field225;
    public CField Field1;
    public CField Field2;
    public CField Field3;
    public CField Field4;
    public CField Field5;
    public CField Field6;
    public CField Field7;
    public CField Field8;
    public CField Field9;
    public CField Field10;
    public CField Field11;
    public CField Field12;
    public CField Field13;
    public CField Field14;
    public CField Field15;
    public CField Field16;
    public CField Field17;
    public CField Field18;
    public CField Field19;
    public CField Field20;
    public CField Field21;
    public CField Field22;
    public CField Field23;
    public CField Field24;
    public CField Field25;
    public CField Field26;
    public CField Field27;
    public CField Field28;
    public CField Field29;
    public CField Field30;
    public CField Field31;
    public CField Field32;
    public CField Field33;
    public CField Field34;
    public CField Field35;
    public CField Field36;
    public CField Field37;
    public CField Field38;
    public CField Field39;
    public CField Field40;
    public CField Field41;
    public CField Field42;
    public CField Field43;
    public CField Field44;
    public CField Field45;
    public CField Field46;
    public CField Field47;
    public CField Field48;
    public CField Field49;
    public CField Field50;
    public CField Field51;
    public CField Field52;
    public CField Field53;
    public CField Field54;
    public CField Field55;
    public CField Field56;
    public CField Field57;
    public CField Field58;
    public CField Field59;
    public CField Field60;
    public CField Field61;
    public CField Field62;
    public CField Field63;
    public CField Field64;
    public CField Field65;
    public CField Field66;
    public CField Field67;
    public CField Field68;
    public CField Field69;
    public CField Field70;
    public CField Field71;
    public CField Field72;
    public CField Field73;
    public CField Field74;
    public CField Field75;
    public CField Field76;
    public CField Field77;
    public CField Field78;
    public CField Field79;
    public CField Field80;
    public CField Field81;
    public CField Field82;
    public CField Field83;
    public CField Field84;
    public CField Field85;
    public CField Field86;
    public CField Field87;
    public CField Field88;
    public CField Field89;
    public CField Field90;
    public CField Field91;
    public CField Field92;
    public CField Field93;
    public CField Field94;
    public CField Field95;
    public CField Field96;
    public CField Field97;
    public CField Field98;
    public CField Field99;
    public CField Field100;
    public CField Field101;
    public CField Field102;
    public CField Field103;
    public CField Field104;
    public CField Field105;
    public CField Field106;
    public CField Field107;
    public CField Field108;
    public CField Field109;
    public CField Field110;
    public CField Field111;
    public CField Field112;
    public CField Field113;
    public CField Field114;
    public CField Field115;
    public CField Field116;
    public CField Field117;
    public CField Field118;
    public CField Field119;
    public CField Field120;
    public CField Field121;
    public CField Field122;
    public CField Field123;
    public CField Field124;
    public CField Field125;
    public CField Field126;
    public CField Field127;
    public CField Field128;
    public CField Field129;
    public CField Field130;
    public CField Field131;
    public CField Field132;
    public CField Field133;
    public CField Field134;
    public CField Field135;
    public CField Field136;
    public CField Field137;
    public CField Field138;
    public CField Field139;
    public CField Field140;
    public CField Field141;
    public CField Field142;
    public CField Field143;
    public CField Field144;
    public CField Field145;
    public CField Field146;
    public CField Field147;
    public CField Field148;
    public CField Field149;
    public CField Field150;
    public CField Field151;
    public CField Field152;
    public CField Field153;
    public CField Field154;
    public CField Field155;
    public CField Field156;
    public CField Field157;
    public CField Field158;
    public CField Field159;
    public CField Field160;
    public CField Field161;
    public CField Field162;
    public CField Field163;
    public CField Field164;
    public CField Field165;
    public CField Field166;
    public CField Field167;
    public CField Field168;
    public CField Field169;
    public CField Field170;
    public CField Field171;
    public CField Field172;
    public CField Field173;
    public CField Field174;
    public CField Field175;
    public CField Field176;
    public CField Field177;
    public CField Field178;
    public CField Field179;
    public CField Field180;
    public CField Field181;
    public CField Field182;
    public CField Field183;
    public CField Field184;
    public CField Field185;
    public CField Field186;
    public CField Field187;
    public CField Field188;
    public CField Field189;
    public CField Field190;
    public CField Field191;
    public CField Field192;
    public CField Field193;
    public CField Field194;
    public CField Field195;
    public CField Field196;
    public CField Field197;
    public CField Field198;
    public CField Field199;
    public CField Field200;
    public CField Field201;
    public CField Field202;
    public CField Field203;
    public CField Field204;
    public CField Field205;
    public CField Field206;
    public CField Field207;
    public CField Field208;
    public CField Field209;
    public CField Field210;
    public CField Field211;
    public CField Field212;
    public CField Field213;
    public CField Field214;
    public CField Field215;
    public CField Field216;
    public CField Field217;
    public CField Field218;
    public CField Field219;
    public CField Field220;
    public CField Field221;
    public CField Field222;
    public CField Field223;
    public CField Field224;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;
    public GameObject obj13;
    public GameObject obj14;
    public GameObject obj15;
    public GameObject obj16;
    public GameObject obj17;
    public GameObject obj18;
    public GameObject obj19;
    public GameObject obj20;
    public GameObject obj21;
    public GameObject obj22;
    public GameObject obj23;
    public GameObject obj24;
    public GameObject obj25;
    public GameObject obj26;
    public GameObject obj27;
    public GameObject obj28;
    public GameObject obj29;
    public GameObject obj30;
    public GameObject obj31;
    public GameObject obj32;
    public GameObject obj33;
    public GameObject obj34;
    public GameObject obj35;
    public GameObject obj36;
    public GameObject obj37;
    public GameObject obj38;
    public GameObject obj39;
    public GameObject obj40;
    public GameObject obj41;
    public GameObject obj42;
    public GameObject obj43;
    public GameObject obj44;
    public GameObject obj45;
    public GameObject obj46;
    public GameObject obj47;
    public GameObject obj48;
    public GameObject obj49;
    public GameObject obj50;
    public GameObject obj51;
    public GameObject obj52;
    public GameObject obj53;
    public GameObject obj54;
    public GameObject obj55;
    public GameObject obj56;
    public GameObject obj57;
    public GameObject obj58;
    public GameObject obj59;
    public GameObject obj60;
    public GameObject obj61;
    public GameObject obj62;
    public GameObject obj63;
    public GameObject obj64;
    public GameObject obj65;
    public GameObject obj66;
    public GameObject obj67;
    public GameObject obj68;
    public GameObject obj69;
    public GameObject obj70;
    public GameObject obj71;
    public GameObject obj72;
    public GameObject obj73;
    public GameObject obj74;
    public GameObject obj75;
    public GameObject obj76;
    public GameObject obj77;
    public GameObject obj78;
    public GameObject obj79;
    public GameObject obj80;
    public GameObject obj81;
    public GameObject obj82;
    public GameObject obj83;
    public GameObject obj84;
    public GameObject obj85;
    public GameObject obj86;
    public GameObject obj87;
    public GameObject obj88;
    public GameObject obj89;
    public GameObject obj90;
    public GameObject obj91;
    public GameObject obj92;
    public GameObject obj93;
    public GameObject obj94;
    public GameObject obj95;
    public GameObject obj96;
    public GameObject obj97;
    public GameObject obj98;
    public GameObject obj99;
    public GameObject obj100;
    public GameObject obj101;
    public GameObject obj102;
    public GameObject obj103;
    public GameObject obj104;
    public GameObject obj105;
    public GameObject obj106;
    public GameObject obj107;
    public GameObject obj108;
    public GameObject obj109;
    public GameObject obj110;
    public GameObject obj111;
    public GameObject obj112;
    public GameObject obj113;
    public GameObject obj114;
    public GameObject obj115;
    public GameObject obj116;
    public GameObject obj117;
    public GameObject obj118;
    public GameObject obj119;
    public GameObject obj120;
    public GameObject obj121;
    public GameObject obj122;
    public GameObject obj123;
    public GameObject obj124;
    public GameObject obj125;
    public GameObject obj126;
    public GameObject obj127;
    public GameObject obj128;
    public GameObject obj129;
    public GameObject obj130;
    public GameObject obj131;
    public GameObject obj132;
    public GameObject obj133;
    public GameObject obj134;
    public GameObject obj135;
    public GameObject obj136;
    public GameObject obj137;
    public GameObject obj138;
    public GameObject obj139;
    public GameObject obj140;
    public GameObject obj141;
    public GameObject obj142;
    public GameObject obj143;
    public GameObject obj144;
    public GameObject obj145;
    public GameObject obj146;
    public GameObject obj147;
    public GameObject obj148;
    public GameObject obj149;
    public GameObject obj150;
    public GameObject obj151;
    public GameObject obj152;
    public GameObject obj153;
    public GameObject obj154;
    public GameObject obj155;
    public GameObject obj156;
    public GameObject obj157;
    public GameObject obj158;
    public GameObject obj159;
    public GameObject obj160;
    public GameObject obj161;
    public GameObject obj162;
    public GameObject obj163;
    public GameObject obj164;
    public GameObject obj165;
    public GameObject obj166;
    public GameObject obj167;
    public GameObject obj168;
    public GameObject obj169;
    public GameObject obj170;
    public GameObject obj171;
    public GameObject obj172;
    public GameObject obj173;
    public GameObject obj174;
    public GameObject obj175;
    public GameObject obj176;
    public GameObject obj177;
    public GameObject obj178;
    public GameObject obj179;
    public GameObject obj180;
    public GameObject obj181;
    public GameObject obj182;
    public GameObject obj183;
    public GameObject obj184;
    public GameObject obj185;
    public GameObject obj186;
    public GameObject obj187;
    public GameObject obj188;
    public GameObject obj189;
    public GameObject obj190;
    public GameObject obj191;
    public GameObject obj192;
    public GameObject obj193;
    public GameObject obj194;
    public GameObject obj195;
    public GameObject obj196;
    public GameObject obj197;
    public GameObject obj198;
    public GameObject obj199;
    public GameObject obj200;
    public GameObject obj201;
    public GameObject obj202;
    public GameObject obj203;
    public GameObject obj204;
    public GameObject obj205;
    public GameObject obj206;
    public GameObject obj207;
    public GameObject obj208;
    public GameObject obj209;
    public GameObject obj210;
    public GameObject obj211;
    public GameObject obj212;
    public GameObject obj213;
    public GameObject obj214;
    public GameObject obj215;
    public GameObject obj216;
    public GameObject obj217;
    public GameObject obj218;
    public GameObject obj219;
    public GameObject obj220;
    public GameObject obj221;
    public GameObject obj222;
    public GameObject obj223;
    public GameObject obj224;
    public GameObject obj225;



    


    public string path = "F:/JFA/проекты/Jackal_0.3 " +
        "(+ дизайн, + оффлайн)/Assets/Assetse/Input-Output"; // путь к файлу
    public string nameFile = "test.txt"; // название файла 
    public string tesst = "ONO RABOTAET";
    public string tesst1 = " ";
    public void OnSave()
    { // функция сохранения
        StreamWriter sw = new StreamWriter(path + "/" + nameFile); // создаём файл
        sw.WriteLine(name); // записываем в файл строку
        sw.WriteLine(trophy);
        sw.WriteLine(money);
        sw.WriteLine(win1);
        sw.WriteLine(win2);
        sw.WriteLine(musss);
        sw.WriteLine(souuu);
        sw.WriteLine(lannn);
        sw.WriteLine(0);
        sw.Close(); // закрываем файл
    }
    public void OnLoad() // функция чтения
    {
        StreamReader sr = new StreamReader(path + "/" + nameFile); // открываем файл
        name = sr.ReadLine(); // читаем строку
        Name.text = name;
        trophy = Convert.ToInt32(sr.ReadLine());
        money = Convert.ToInt32(sr.ReadLine());
        win1 = Convert.ToInt32(sr.ReadLine());
        win2 = Convert.ToInt32(sr.ReadLine());
        musss = Convert.ToInt32(sr.ReadLine());
        souuu = Convert.ToInt32(sr.ReadLine());
        lannn = Convert.ToInt32(sr.ReadLine());
        l = Convert.ToInt32(sr.ReadLine());
        sr.Close(); // закрываем файл
    }

    // Start is called before the first frame update
    void Start()
    {


    }

    public void ToT()
    {
        Indic = true;
        //to go to game with 
        //sorted fields
        MovesQuan = 0;
    }
    public void ToF()
    {
        Indic = false;
        //to make that indicator false
        //to not to remake sorted fields
    }

    // Update is called once per frame
    void Update()
    {


        /* if (russin=true)
         {
             Obj253.SetActive(true);
             Obj254.SetActive(true);
             Obj255.SetActive(true);
             Obj244.SetActive(false);
             Obj245.SetActive(false);
             Obj243.SetActive(false);
         }
         if (english = true)
         {
             Obj253.SetActive(false);
             Obj254.SetActive(false);
             Obj255.SetActive(false);
             Obj244.SetActive(true);
             Obj245.SetActive(true);
             Obj243.SetActive(true);
         }*/




        //start



        if (z == true)
        {
            exit_gl.SetActive(false);
            menu_fight.SetActive(false);
            menu.SetActive(true);
            Setting_OFF.SetActive(true);
            Setting_ON.SetActive(false);
            Eng1_setting.SetActive(false);
            Eng2_online.SetActive(false);
            Eng3_profil.SetActive(false);
            Eng4_1x1.SetActive(false);
            Eng5_1x1x1x1.SetActive(false);
            Eng6_exit.SetActive(false);
            Eng7_win.SetActive(false);
            Eng8_exit_gl.SetActive(false);
            Rus1_setting.SetActive(true);
            Rus2_online.SetActive(true);
            Rus3_profil.SetActive(true);
            Rus4_1x1.SetActive(true);
            Rus5_1x1x1x1.SetActive(true);
            Rus6_exit.SetActive(true);
            Rus7_win.SetActive(true);
            Rus8_exit_gl.SetActive(true);
            Position = new RVPos();
            //HPosition = new FPos();
            z = false;
            Indic = false;
            //IndiC = 
            //FormUu = new FormU();
            can_die = true;
            swim_only_forward = true;
            hidden_field = true;
            unlimited_plane = true;
            steply_rotation = true;
            sequence = true;
            unlimited_moving = true;
            russin = false;
            english = true;
            Win = false;
            a1 = 1;

            Obj17.SetActive(true);
            Obj73.SetActive(false);
            Obj74.SetActive(false);
            Obj75.SetActive(false);
            Obj76.SetActive(false);
            /* Obj77.GetComponent<Renderer>().material = Mat;
                        Obj78.GetComponent<Renderer>().material = Mat;
                        Obj79.GetComponent<Renderer>().material = Mat;
                        Obj80.GetComponent<Renderer>().material = Mat;
                        Obj81.GetComponent<Renderer>().material = Mat;
                        Obj82.GetComponent<Renderer>().material = Mat;
                        Obj83.GetComponent<Renderer>().material = Mat;
                        Obj84.GetComponent<Renderer>().material = Mat;
                        Obj85.GetComponent<Renderer>().material = Mat;
                        Obj86.GetComponent<Renderer>().material = Mat;*/
            Obj156.SetActive(false);
            Obj157.SetActive(false);
            Obj158.SetActive(false);
            Obj159.SetActive(false);
            Obj160.SetActive(false);
            Obj161.SetActive(false);
            Obj162.SetActive(false);
            Obj163.SetActive(false);
            Obj164.SetActive(false);
            Obj165.SetActive(false);
            Obj166.SetActive(false);
            Obj167.SetActive(false);
            Obj168.SetActive(false);
            Obj169.SetActive(false);
            Obj170.SetActive(false);
            Obj171.SetActive(false);
            Obj172.SetActive(false);
            Obj173.SetActive(false);
           /* Obj125.SetActive(false);
            Obj126.SetActive(false);
            Obj127.SetActive(false);
            Obj128.SetActive(false);
            Obj195.SetActive(false);
            Obj193.SetActive(false);
            Obj197.SetActive(false);
            Obj199.SetActive(false);
            Obj201.SetActive(false);
            Obj203.SetActive(false);
            Obj205.SetActive(false);
            Obj282.SetActive(false);
            Obj283.SetActive(true);
            Obj284.SetActive(false);
            Obj287.SetActive(true);
            Obj288.SetActive(false);
            Obj289.SetActive(true);
            Obj290.SetActive(false);
            Obj291.SetActive(true);
            Obj292.SetActive(false);
            Obj293.SetActive(true);

            Obj305.SetActive(false);
            Obj304.SetActive(true);
            Obj307.SetActive(false);
            Obj306.SetActive(true);
            Obj309.SetActive(false);
            Obj308.SetActive(true);
            Obj318.SetActive(false);
            Obj319.SetActive(true);
            Obj320.SetActive(false);
            Obj321.SetActive(true);
            Obj322.SetActive(false);
            Obj323.SetActive(true);
            Obj324.SetActive(false);
            Obj325.SetActive(true);
            Obj326.SetActive(false);
            Obj327.SetActive(true);
            Obj360.SetActive(true);
            Obj361.SetActive(false);
            Obj311.SetActive(false);
            Obj310.SetActive(true);
            Obj313.SetActive(false);
            Obj312.SetActive(true);
            Obj315.SetActive(false);
            Obj314.SetActive(true);
            Obj317.SetActive(false);
            Obj316.SetActive(true);
            Obj328.SetActive(false);
            Obj329.SetActive(true);
            Obj330.SetActive(false);
            Obj331.SetActive(true);
            Obj332.SetActive(false);
            Obj333.SetActive(true);
            Obj334.SetActive(false);
            Obj335.SetActive(true);
            Obj324.SetActive(false);
            Obj362.SetActive(false);
            Obj363.SetActive(true);
            Obj364.SetActive(false);
            Obj365.SetActive(true);
            Obj366.SetActive(false);
            Obj367.SetActive(true);
            Obj368.SetActive(false);
            Obj369.SetActive(true);
            Obj370.SetActive(false);
            Obj371.SetActive(true);
            Obj372.SetActive(false);
            Obj373.SetActive(true);
            Obj374.SetActive(false);
            Obj375.SetActive(true);
            Obj436.SetActive(false);
            Obj437.SetActive(false);
            Obj438.SetActive(false);
            Obj439.SetActive(false);
            Obj440.SetActive(false);
            Obj441.SetActive(false);
            Obj442.SetActive(false);
            Obj443.SetActive(false);
            Obj444.SetActive(false);
            Obj445.SetActive(false);
            Obj446.SetActive(false);
            Obj447.SetActive(false);*/

            Obj93.transform.position = new Vector3(+5f, 0f, -55f);
            Obj97.transform.position = new Vector3(+125f, 0f, -55f);
            Obj101.transform.position = new Vector3(+65f, 0f, 5f);
            Obj105.transform.position = new Vector3(+65f, 0f, -115f);/*
            Obj90.transform.position = new Vector3(+5f, 0f, -55f);
            Obj91.transform.position = new Vector3(+5f, 0f, -55f);
            Obj92.transform.position = new Vector3(+5f, 0f, -55f);
            Obj94.transform.position = new Vector3(+125f, 0f, -55f);
            Obj95.transform.position = new Vector3(+125f, 0f, -55f);
            Obj96.transform.position = new Vector3(+125f, 0f, -55f);
            Obj98.transform.position = new Vector3(+65f, 0f, 5f);
            Obj99.transform.position = new Vector3(+65f, 0f, 5f);
            Obj100.transform.position = new Vector3(+65f, 0f, 5f);
            Obj102.transform.position = new Vector3(+65f, 0f, -115f);
            Obj103.transform.position = new Vector3(+65f, 0f, -115f);
            Obj104.transform.position = new Vector3(+65f, 0f, -115f);*/
            Obj15.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            Obj15.transform.position = new Vector3(+65f, 0f, -55f);
            Obj17.transform.rotation = Quaternion.Euler(90, 0, 180f);
            Obj17.transform.position = new Vector3(0, 160, 0);
            yyy = 90f;
            Obj90.transform.position = new Vector3(+5f, 0f, -58.3f);
            Obj91.transform.position = new Vector3(+5f, 0f, -56.2f);
            Obj92.transform.position = new Vector3(+5f, 0f, -54.1f);
            Obj94.transform.position = new Vector3(+125f, 0f, -55.9f);
            Obj95.transform.position = new Vector3(+125f, 0f, -53.8f);
            Obj96.transform.position = new Vector3(+125f, 0f, -51.7f);
            Obj98.transform.position = new Vector3(+65f - 3.3f, 0f, 5f);
            Obj99.transform.position = new Vector3(+65f - 1.2f, 0f, 5f);
            Obj100.transform.position = new Vector3(+65f + 0.9f, 0f, 5f);
            Obj102.transform.position = new Vector3(+65f + 3.3f, 0f, -115f);
            Obj103.transform.position = new Vector3(+65f + 1.2f, 0f, -115f);
            Obj104.transform.position = new Vector3(+65f - 0.9f, 0f, -115f);

            p1 = 0;
            p2 = 0;
            p3 = 0;
            p4 = 0;

            a1 = 1;
            r = 0;
            russin = false;
            english = true;
            sum = 37f;
            sumpole = 37f;


            OnLoad();
        }
        if (z0)
        {
            if (musss == 0)
            {
                Music_on.SetActive(true);

                Music_vkl.SetActive(true);

                Music_off.SetActive(false);

                Music_vikl.SetActive(false);

                Music.SetActive(true);
            }
            if (musss == 1)
            {
                Music_on.SetActive(false);

                Music_vkl.SetActive(false);

                Music_off.SetActive(true);

                Music_vikl.SetActive(true);

                Music.SetActive(false);
            }
            if (souuu == 0)
            {
                Sound_on.SetActive(true);

                Sound_vkl.SetActive(true);

                Sound_off.SetActive(false);

                Sound_vikl.SetActive(false);

                Sound.SetActive(true);
            }
            if (souuu == 1)
            {
                Sound_on.SetActive(false);

                Sound_vkl.SetActive(false);

                Sound_off.SetActive(true);

                Sound_vikl.SetActive(true);

                Sound.SetActive(false);
            }
            if (lannn == 0)
            {
                RUSS.re = false;
                Rus1_setting.SetActive(false);
                Rus2_online.SetActive(false);
                Rus3_profil.SetActive(false);
                Rus4_1x1.SetActive(false);
                Rus5_1x1x1x1.SetActive(false);
                Rus6_exit.SetActive(false);
                Rus7_win.SetActive(false);
                Rus8_exit_gl.SetActive(false);
                Eng1_setting.SetActive(true);
                Eng2_online.SetActive(true);
                Eng3_profil.SetActive(true);
                Eng4_1x1.SetActive(true);
                Eng5_1x1x1x1.SetActive(true);
                Eng6_exit.SetActive(true);
                Eng7_win.SetActive(true);
                Eng8_exit_gl.SetActive(true);
            }
            if (lannn == 1)
            {
                Eng1_setting.SetActive(false);
                Eng2_online.SetActive(false);
                Eng3_profil.SetActive(false);
                Eng4_1x1.SetActive(false);
                Eng5_1x1x1x1.SetActive(false);
                Eng6_exit.SetActive(false);
                Eng7_win.SetActive(false);
                Eng8_exit_gl.SetActive(false);
                Rus1_setting.SetActive(true);
                Rus2_online.SetActive(true);
                Rus3_profil.SetActive(true);
                Rus4_1x1.SetActive(true);
                Rus5_1x1x1x1.SetActive(true);
                Rus6_exit.SetActive(true);
                Rus7_win.SetActive(true);
                Rus8_exit_gl.SetActive(true);
            }



            Crosses = new GameObject[3][,];
            Crosses[0] = new GameObject[2, 3]{ { Obj156, Obj157, Obj158 },
                                               { Obj159, Obj160, Obj161 } };
            Crosses[1] = new GameObject[4, 3]{ { Obj162, Obj163, Obj164 },
                                               { Obj165, Obj166, Obj167 },
                                               { Obj168, Obj169, Obj170 },
                                               { Obj171, Obj172, Obj173 }};




            z0 = false;

            Lightn = new GameObject[15, 15] {{L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12, L13, L14, L15 },
{ L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30 },
{ L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42, L43, L44, L45 },
{ L46, L47, L48, L49, L50, L51, L52, L53, L54, L55, L56, L57, L58, L59, L60 },
{ L61, L62, L63, L64, L65, L66, L67, L68, L69, L70, L71, L72, L73, L74, L75 },
{ L76, L77, L78, L79, L80, L81, L82, L83, L84, L85, L86, L87, L88, L89, L90 },
{ L91, L92, L93, L94, L95, L96, L97, L98, L99, L100, L101, L102, L103, L104, L105 },
{ L106, L107, L108, L109, L110, L111, L112, L113, L114, L115, L116, L117, L118, L119, L120 },
{ L121, L122, L123, L124, L125, L126, L127, L128, L129, L130, L131, L132, L133, L134, L135 },
{ L136, L137, L138, L139, L140, L141, L142, L143, L144, L145, L146, L147, L148, L149, L150 },
{ L151, L152, L153, L154, L155, L156, L157, L158, L159, L160, L161, L162, L163, L164, L165 },
{ L166, L167, L168, L169, L170, L171, L172, L173, L174, L175, L176, L177, L178, L179, L180 },
{ L181, L182, L183, L184, L185, L186, L187, L188, L189, L190, L191, L192, L193, L194, L195 },
{ L196, L197, L198, L199, L200, L201, L202, L203, L204, L205, L206, L207, L208, L209, L210 },
{ L211, L212, L213, L214, L215, L216, L217, L218, L219, L220, L221, L222, L223, L224, L225 } };
            //massive of illumination

            ToF();
            Field1 = new CField(obj1);
            Field2 = new CField(obj2);
            Field3 = new CField(obj3);
            Field4 = new CField(obj4);
            Field5 = new CField(obj5);
            Field6 = new CField(obj6);
            Field7 = new CField(obj7);
            Field8 = new CField(obj8);
            Field9 = new CField(obj9);
            Field10 = new CField(obj10);
            Field11 = new CField(obj11);
            Field12 = new CField(obj12);
            Field13 = new CField(obj13);
            Field14 = new CField(obj14);
            Field15 = new CField(obj15);
            Field16 = new CField(obj16);
            Field17 = new CField(obj17);
            Field18 = new CField(obj18);
            Field19 = new CField(obj19);
            Field20 = new CField(obj20);
            Field21 = new CField(obj21);
            Field22 = new CField(obj22);
            Field23 = new CField(obj23);
            Field24 = new CField(obj24);
            Field25 = new CField(obj25);
            Field26 = new CField(obj26);
            Field27 = new CField(obj27);
            Field28 = new CField(obj28);
            Field29 = new CField(obj29);
            Field30 = new CField(obj30);
            Field31 = new CField(obj31);
            Field32 = new CField(obj32);
            Field33 = new CField(obj33);
            Field34 = new CField(obj34);
            Field35 = new CField(obj35);
            Field36 = new CField(obj36);
            Field37 = new CField(obj37);
            Field38 = new CField(obj38);
            Field39 = new CField(obj39);
            Field40 = new CField(obj40);
            Field41 = new CField(obj41);
            Field42 = new CField(obj42);
            Field43 = new CField(obj43);
            Field44 = new CField(obj44);
            Field45 = new CField(obj45);
            Field46 = new CField(obj46);
            Field47 = new CField(obj47);
            Field48 = new CField(obj48);
            Field49 = new CField(obj49);
            Field50 = new CField(obj50);
            Field51 = new CField(obj51);
            Field52 = new CField(obj52);
            Field53 = new CField(obj53);
            Field54 = new CField(obj54);
            Field55 = new CField(obj55);
            Field56 = new CField(obj56);
            Field57 = new CField(obj57);
            Field58 = new CField(obj58);
            Field59 = new CField(obj59);
            Field60 = new CField(obj60);
            Field61 = new CField(obj61);
            Field62 = new CField(obj62);
            Field63 = new CField(obj63);
            Field64 = new CField(obj64);
            Field65 = new CField(obj65);
            Field66 = new CField(obj66);
            Field67 = new CField(obj67);
            Field68 = new CField(obj68);
            Field69 = new CField(obj69);
            Field70 = new CField(obj70);
            Field71 = new CField(obj71);
            Field72 = new CField(obj72);
            Field73 = new CField(obj73);
            Field74 = new CField(obj74);
            Field75 = new CField(obj75);
            Field76 = new CField(obj76);
            Field77 = new CField(obj77);
            Field78 = new CField(obj78);
            Field79 = new CField(obj79);
            Field80 = new CField(obj80);
            Field81 = new CField(obj81);
            Field82 = new CField(obj82);
            Field83 = new CField(obj83);
            Field84 = new CField(obj84);
            Field85 = new CField(obj85);
            Field86 = new CField(obj86);
            Field87 = new CField(obj87);
            Field88 = new CField(obj88);
            Field89 = new CField(obj89);
            Field90 = new CField(obj90);
            Field91 = new CField(obj91);
            Field92 = new CField(obj92);
            Field93 = new CField(obj93);
            Field94 = new CField(obj94);
            Field95 = new CField(obj95);
            Field96 = new CField(obj96);
            Field97 = new CField(obj97);
            Field98 = new CField(obj98);
            Field99 = new CField(obj99);
            Field100 = new CField(obj100);
            Field101 = new CField(obj101);
            Field102 = new CField(obj102);
            Field103 = new CField(obj103);
            Field104 = new CField(obj104);
            Field105 = new CField(obj105);
            Field106 = new CField(obj106);
            Field107 = new CField(obj107);
            Field108 = new CField(obj108);
            Field109 = new CField(obj109);
            Field110 = new CField(obj110);
            Field111 = new CField(obj111);
            Field112 = new CField(obj112);
            Field113 = new CField(obj113);
            Field114 = new CField(obj114);
            Field115 = new CField(obj115);
            Field116 = new CField(obj116);
            Field117 = new CField(obj117);
            Field118 = new CField(obj118);
            Field119 = new CField(obj119);
            Field120 = new CField(obj120);
            Field121 = new CField(obj121);
            Field122 = new CField(obj122);
            Field123 = new CField(obj123);
            Field124 = new CField(obj124);
            Field125 = new CField(obj125);
            Field126 = new CField(obj126);
            Field127 = new CField(obj127);
            Field128 = new CField(obj128);
            Field129 = new CField(obj129);
            Field130 = new CField(obj130);
            Field131 = new CField(obj131);
            Field132 = new CField(obj132);
            Field133 = new CField(obj133);
            Field134 = new CField(obj134);
            Field135 = new CField(obj135);
            Field136 = new CField(obj136);
            Field137 = new CField(obj137);
            Field138 = new CField(obj138);
            Field139 = new CField(obj139);
            Field140 = new CField(obj140);
            Field141 = new CField(obj141);
            Field142 = new CField(obj142);
            Field143 = new CField(obj143);
            Field144 = new CField(obj144);
            Field145 = new CField(obj145);
            Field146 = new CField(obj146);
            Field147 = new CField(obj147);
            Field148 = new CField(obj148);
            Field149 = new CField(obj149);
            Field150 = new CField(obj150);
            Field151 = new CField(obj151);
            Field152 = new CField(obj152);
            Field153 = new CField(obj153);
            Field154 = new CField(obj154);
            Field155 = new CField(obj155);
            Field156 = new CField(obj156);
            Field157 = new CField(obj157);
            Field158 = new CField(obj158);
            Field159 = new CField(obj159);
            Field160 = new CField(obj160);
            Field161 = new CField(obj161);
            Field162 = new CField(obj162);
            Field163 = new CField(obj163);
            Field164 = new CField(obj164);
            Field165 = new CField(obj165);
            Field166 = new CField(obj166);
            Field167 = new CField(obj167);
            Field168 = new CField(obj168);
            Field169 = new CField(obj169);
            Field170 = new CField(obj170);
            Field171 = new CField(obj171);
            Field172 = new CField(obj172);
            Field173 = new CField(obj173);
            Field174 = new CField(obj174);
            Field175 = new CField(obj175);
            Field176 = new CField(obj176);
            Field177 = new CField(obj177);
            Field178 = new CField(obj178);
            Field179 = new CField(obj179);
            Field180 = new CField(obj180);
            Field181 = new CField(obj181);
            Field182 = new CField(obj182);
            Field183 = new CField(obj183);
            Field184 = new CField(obj184);
            Field185 = new CField(obj185);
            Field186 = new CField(obj186);
            Field187 = new CField(obj187);
            Field188 = new CField(obj188);
            Field189 = new CField(obj189);
            Field190 = new CField(obj190);
            Field191 = new CField(obj191);
            Field192 = new CField(obj192);
            Field193 = new CField(obj193);
            Field194 = new CField(obj194);
            Field195 = new CField(obj195);
            Field196 = new CField(obj196);
            Field197 = new CField(obj197);
            Field198 = new CField(obj198);
            Field199 = new CField(obj199);
            Field200 = new CField(obj200);
            Field201 = new CField(obj201);
            Field202 = new CField(obj202);
            Field203 = new CField(obj203);
            Field204 = new CField(obj204);
            Field205 = new CField(obj205);
            Field206 = new CField(obj206);
            Field207 = new CField(obj207);
            Field208 = new CField(obj208);
            Field209 = new CField(obj209);
            Field210 = new CField(obj210);
            Field211 = new CField(obj211);
            Field212 = new CField(obj212);
            Field213 = new CField(obj213);
            Field214 = new CField(obj214);
            Field215 = new CField(obj215);
            Field216 = new CField(obj216);
            Field217 = new CField(obj217);
            Field218 = new CField(obj218);
            Field219 = new CField(obj219);
            Field220 = new CField(obj220);
            Field221 = new CField(obj221);
            Field222 = new CField(obj222);
            Field223 = new CField(obj223);
            Field224 = new CField(obj224);
            Field225 = new CField(obj225);
        }
        if (iz2)
        {
            iz2 = false;
            Pie1 = new CPirate(1, 7, 0, Obj90);
            Pie2 = new CPirate(1, 7, 0, Obj91);
            Pie3 = new CPirate(1, 7, 0, Obj92);
            Pie4 = new CPirate(13, 7, 1, Obj94);
            Pie5 = new CPirate(13, 7, 1, Obj95);
            Pie6 = new CPirate(13, 7, 1, Obj96);
            Pie7 = new CPirate(7, 1, 2, Obj98);
            Pie8 = new CPirate(7, 1, 2, Obj99);
            Pie9 = new CPirate(7, 1, 2, Obj100);
            Pie10 = new CPirate(7, 13, 3, Obj102);
            Pie11 = new CPirate(7, 13, 3, Obj103);
            Pie12 = new CPirate(7, 13, 3, Obj104);
            ShipWhi = new CPirate(1, 7, 0, Obj93);
            ShipBla = new CPirate(13, 7, 1, Obj97);
            ShipYel = new CPirate(7, 13, 3, Obj105);
            ShipRed = new CPirate(7, 1, 2, Obj101);


            //Coin object

            Coin1 = new CCoin(Coi1, 0);
            Coin2 = new CCoin(Coi2, 0);
            Coin3 = new CCoin(Coi3, 0);
            Coin4 = new CCoin(Coi4, 0);
            Coin5 = new CCoin(Coi5, 0);
            Coin6 = new CCoin(Coi6, 0);
            Coin7 = new CCoin(Coi7, 0);
            Coin8 = new CCoin(Coi8, 0);
            Coin9 = new CCoin(Coi9, 0);
            Coin10 = new CCoin(Coi10, 0);
            Coin11 = new CCoin(Coi11, 0);
            Coin12 = new CCoin(Coi12, 0);
            Coin13 = new CCoin(Coi13, 0);
            Coin14 = new CCoin(Coi14, 0);
            Coin15 = new CCoin(Coi15, 0);
            Coin16 = new CCoin(Coi16, 0);
            Coin17 = new CCoin(Coi17, 0);
            Coin18 = new CCoin(Coi18, 0);
            Coin19 = new CCoin(Coi19, 0);
            Coin20 = new CCoin(Coi20, 0);
            Coin21 = new CCoin(Coi21, 0);
            Coin22 = new CCoin(Coi22, 0);
            Coin23 = new CCoin(Coi23, 0);
            Coin24 = new CCoin(Coi24, 0);
            Coin25 = new CCoin(Coi25, 0);
            Coin26 = new CCoin(Coi26, 0);
            Coin27 = new CCoin(Coi27, 0);
            Coin28 = new CCoin(Coi28, 0);
            Coin29 = new CCoin(Coi29, 0);
            Coin30 = new CCoin(Coi30, 0);
            Coin31 = new CCoin(Coi31, 0);
            Coin32 = new CCoin(Coi32, 0);
            Coin33 = new CCoin(Coi33, 0);
            Coin34 = new CCoin(Coi34, 0);
            Coin35 = new CCoin(Coi35, 0);
            Coin36 = new CCoin(Coi36, 0);
            Coin37 = new CCoin(Coi37, 0);

            //massive of coins

            Chest = new CCoin[37] {Coin1, Coin2, Coin3, Coin4,
                Coin5, Coin6, Coin7, Coin8,
                Coin9, Coin10, Coin11, Coin12,
                Coin13, Coin14, Coin15, Coin16,
                Coin17, Coin18, Coin19, Coin20,
                Coin21, Coin22, Coin23, Coin24,
                Coin25, Coin26, Coin27, Coin28,
                Coin29, Coin30, Coin31, Coin32,
                Coin33, Coin34, Coin35, Coin36,
                Coin37 };

            //massive of pirates and their own ships

            Pizza = new CPirate[4, 4] { { Pie1,Pie2,Pie3, ShipWhi },
            {Pie7,Pie8,Pie9, ShipRed },
            {Pie4,Pie5,Pie6, ShipBla },
            {Pie10,Pie11,Pie12, ShipYel }};

            for (int qqq = 0; qqq < 4; qqq++)
            {

                Pizza[qqq, 3].is_ship = true;
            }


            /*CoinsQuan = new int[3, 4] { { 0, 0, -1, -1},
                                        { 0, 0, 0, 0 },
                                        { 0, 0, 0, 0 } };*/
            CoinsQuan = new int[3][];
            CoinsQuan[0] = new int[2] { 0, 0 };
            CoinsQuan[1] = new int[4] { 0, 0, 0, 0 };
            CoinsQuan[2] = new int[4] { 0, 0, 0, 0 };


            CoinCondi = new int[37] { 0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0};
        }












        int k;
        System.Random rand = new System.Random();
        CField[,] FieldField = new CField[15, 15] {{Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10, Field11, Field12, Field13, Field14, Field15 },
{ Field16, Field17, Field18, Field19, Field20, Field21, Field22, Field23, Field24, Field25, Field26, Field27, Field28, Field29, Field30 },
{ Field31, Field32, Field33, Field34, Field35, Field36, Field37, Field38, Field39, Field40, Field41, Field42, Field43, Field44, Field45 },
{ Field46, Field47, Field48, Field49, Field50, Field51, Field52, Field53, Field54, Field55, Field56, Field57, Field58, Field59, Field60 },
{ Field61, Field62, Field63, Field64, Field65, Field66, Field67, Field68, Field69, Field70, Field71, Field72, Field73, Field74, Field75 },
{ Field76, Field77, Field78, Field79, Field80, Field81, Field82, Field83, Field84, Field85, Field86, Field87, Field88, Field89, Field90 },
{ Field91, Field92, Field93, Field94, Field95, Field96, Field97, Field98, Field99, Field100, Field101, Field102, Field103, Field104, Field105 },
{ Field106, Field107, Field108, Field109, Field110, Field111, Field112, Field113, Field114, Field115, Field116, Field117, Field118, Field119, Field120 },
{ Field121, Field122, Field123, Field124, Field125, Field126, Field127, Field128, Field129, Field130, Field131, Field132, Field133, Field134, Field135 },
{ Field136, Field137, Field138, Field139, Field140, Field141, Field142, Field143, Field144, Field145, Field146, Field147, Field148, Field149, Field150 },
{ Field151, Field152, Field153, Field154, Field155, Field156, Field157, Field158, Field159, Field160, Field161, Field162, Field163, Field164, Field165 },
{ Field166, Field167, Field168, Field169, Field170, Field171, Field172, Field173, Field174, Field175, Field176, Field177, Field178, Field179, Field180 },
{ Field181, Field182, Field183, Field184, Field185, Field186, Field187, Field188, Field189, Field190, Field191, Field192, Field193, Field194, Field195 },
{ Field196, Field197, Field198, Field199, Field200, Field201, Field202, Field203, Field204, Field205, Field206, Field207, Field208, Field209, Field210 },
{ Field211, Field212, Field213, Field214, Field215, Field216, Field217, Field218, Field219, Field220, Field221, Field222, Field223, Field224, Field225 } };


        Material[] matfield = new Material[41] { mat1, mat2, mat3, mat4, mat5,
                                             mat6, mat7, mat8, mat9, mat10,
                                             mat11, mat12, mat13, mat14, mat15,
                                             mat16, mat17, mat18, mat19, mat20,
                                             mat21, mat22, mat23, mat24, mat25,
                                             mat26, mat27, mat28, mat29, mat30,
                                             mat31, mat32, mat33, mat34, mat35,
                                             mat36, mat37, mat38, mat39, mat40,
                                             mat41};

        //Now creating a new randomized gamefield

        if ((Input.GetKey(KeyCode.U)) | (Indic))

        {


            Obj93.transform.position = new Vector3(+5f, 0.3f, -55f);
            Obj97.transform.position = new Vector3(+125f, 0.3f, -55f);
            Obj101.transform.position = new Vector3(+65f, 0.3f, 5f);
            Obj105.transform.position = new Vector3(+65f, 0.3f, -115f);

            Obj90.transform.position = new Vector3(+5f, 0f, -58.3f);
            Obj91.transform.position = new Vector3(+5f, 0f, -56.2f);
            Obj92.transform.position = new Vector3(+5f, 0f, -54.1f);
            Obj94.transform.position = new Vector3(+125f, 0f, -55.9f);
            Obj95.transform.position = new Vector3(+125f, 0f, -53.8f);
            Obj96.transform.position = new Vector3(+125f, 0f, -51.7f);
            Obj98.transform.position = new Vector3(+65f - 3.3f, 0f, 5f);
            Obj99.transform.position = new Vector3(+65f - 1.2f, 0f, 5f);
            Obj100.transform.position = new Vector3(+65f + 0.9f, 0f, 5f);
            Obj102.transform.position = new Vector3(+65f + 3.3f, 0f, -115f);
            Obj103.transform.position = new Vector3(+65f + 1.2f, 0f, -115f);
            Obj104.transform.position = new Vector3(+65f - 0.9f, 0f, -115f);
            //z0 = true;
            //z1 = true;
            //iz2 = true;

            Indic = false;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    FieldField[i, j].obj.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
            Beginning func = new Beginning();
            field = new int[15, 15];
            field = func.RecreatingUP();

            Position = CEmpty();

            FieldField = Position.RVField;
            Pizza = Position.RVPizza;
            Chest = Position.RVest;
            CoinCondi = Position.RVCCondi;
            CoinsQuan = Position.RVCoQuan;


            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {

                    field[i, j] = FieldField[i, j].type;



                    if ((i < 13) & (i > 1) & (j < 13) & (j > 1))
                    {
                        if (hidden_field)
                        {
                            FieldField[i, j].obj.GetComponent<Renderer>().material =
                                mat0;///
                        }
                        else
                        {
                            FieldField[i, j].obj.GetComponent<Renderer>().material =
                                matfield[FieldField[i, j].type - 1];
                        }

                    }

                }

            }


            obj33.GetComponent<Renderer>().material = mat41;
            obj43.GetComponent<Renderer>().material = mat41;
            obj183.GetComponent<Renderer>().material = mat41;
            obj193.GetComponent<Renderer>().material = mat41;

            for (int i = 0; i < 37; i++)
            {
                Chest[i].CoinStartPosition= new Vector3(
                    FieldField[Chest[i].ci, Chest[i].cj].obj.transform.position.x,
                    0.15f + Chest[i].level,
                    FieldField[Chest[i].ci, Chest[i].cj].obj.transform.position.z);
                Chest[i].Startci = Chest[i].ci;
                Chest[i].Startcj = Chest[i].cj;
                Chest[i].coin.transform.position = new Vector3(
                    FieldField[Chest[i].ci, Chest[i].cj].obj.transform.position.x,
                    0.15f + Chest[i].level,
                    FieldField[Chest[i].ci, Chest[i].cj].obj.transform.position.z);
                Chest[i].coin.SetActive(false);

            }

            Obj156.SetActive(false);
            Obj157.SetActive(false);
            Obj158.SetActive(false);
            Obj159.SetActive(false);
            Obj160.SetActive(false);
            Obj161.SetActive(false);
            Obj162.SetActive(false);
            Obj163.SetActive(false);
            Obj164.SetActive(false);
            Obj165.SetActive(false);
            Obj166.SetActive(false);
            Obj167.SetActive(false);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Pizza[i, j].ressurect();
                    Pizza[i, j].dead = false;
                    Pizza[i, j].move(Pizza[i, 3].x, Pizza[i, 3].z);
                    Pizza[i, j].Pirate.transform.position =
                                                   new Vector3(Pizza[i, 3].Pirate.transform.position.x, 0,
                                                   Pizza[i, 3].Pirate.transform.position.z);

                }

            }
        }


        if ((blok == false))
            off = offline.re;
        if ((blok == false))
            off2 = offline2.re;

        //if ((off == true) &(off2 == true))
        if ((off == true) | (off2 == true) & (blok == false))
        {
            audios.Play();
            offline.re = false;
            offline2.re = false;
            button_1x1_1x1x1x1_offine.SetActive(true);
            button_Online_offline.SetActive(false);
            //button_Online_offline.transform.position = new Vector3(0f, 0f, -1f);
            if (save)
            {
                button_1x1_1x1x1x1_offine.SetActive(false);
                button_Online_offline.SetActive(true);
                menu.SetActive(false);
                menu_fight.SetActive(true);
                save = false;
            }

            off = false;
            off2 = false;

        }
        if ((blok == false))
            onl = online.re;
        if ((blok == false))
            onl2 = online2.re;
        //if ((onl == true) &(onl2 == true))
        if (((onl == true) | (onl2 == true)) & (blok == false))
        {
            audios.Play();
            online.re = false;
            online2.re = false;
            button_1x1_1x1x1x1_online.SetActive(true);

            button_Online_offline.SetActive(false);
            //button_Online_offline.transform.position = new Vector3(0f, 0f, -1f);
            // print("3333333");
            onl = false;
            onl2 = false;
        }
        if ((blok == false))
            onl_1x1 = onlain_1x1.re;
        // if ((onl_1x1 == true) &(onl_1x1_2 == true))
        if ((onl_1x1 == true) & (blok == false))
        {
            audios.Play();
            onlain_1x1.re = false;
            button_1x1_1x1x1x1_online.SetActive(false);
            //button_1x1_1x1x1x1_online.transform.position = new Vector3(0f, 0f, +1f); 
            button_Online_offline.SetActive(true);
            onl_1x1 = false;
            pun.jr();
        }
        if ((blok == false))
            onl_1x1x1x1 = onlain_1x1x1x1.re;
        //if ((onl_1x1x1x1 == true) &(onl_1x1x1x1_2 == true))
        if ((onl_1x1x1x1 == true) & (blok == false))
        {
            audios.Play();
            onlain_1x1x1x1.re = false;
            button_1x1_1x1x1x1_online.SetActive(false);
            button_Online_offline.SetActive(true);
            MF_1x1x1x1.SetActive(true);
            MF_1x1.SetActive(false);
            onl_1x1x1x1 = false;


        }
        if ((blok == false))
            off_1x1 = offlain_1x1.re;
        //if ((off_1x1 == true) &(off_1x1_2 == true))
        if ((off_1x1 == true) & (blok == false))
        {
            ToT();
            audios.Play();
            offlain_1x1.re = false;
            button_1x1_1x1x1x1_offine.SetActive(false);
            button_Online_offline.SetActive(true);
            Obj73.SetActive(true);
            Obj74.SetActive(true);
            Obj75.SetActive(false);
            Obj76.SetActive(false);
            menu.SetActive(false);
            menu_fight.SetActive(true);
            MF_1x1.SetActive(true);
            MF_1x1x1x1.SetActive(false);
            off_1x1 = false;
             whiteeliminated = false;
             blackeliminated = false;
             redeliminated = false;
             yelloweliminated = false;
    Mode = 0;
        }

        if ((blok == false))
            off_1x1x1x1 = offlain_1x1x1x1.re;
        //if ((off_1x1x1x1 == true)&(off_1x1x1x1_2 == true))
        if ((off_1x1x1x1 == true) & (blok == false))
        {
            ToT();
            audios.Play();
            offlain_1x1x1x1.re = false;
            button_1x1_1x1x1x1_offine.SetActive(false);
            button_Online_offline.SetActive(true);
            Obj73.SetActive(true);
            Obj74.SetActive(true);
            Obj75.SetActive(true);
            Obj76.SetActive(true);
            menu.SetActive(false);
            menu_fight.SetActive(true);
            MF_1x1.SetActive(false);
            MF_1x1x1x1.SetActive(true);
            off_1x1x1x1 = false;
            Mode = 1;
            whiteeliminated = false;
            blackeliminated = false;
            redeliminated = false;
            yelloweliminated = false;
        }
        if ((blok == false))
            sou_on = sound_on.re;
        if ((blok == false))
            sou_on2 = sound_on2.re;
        if (((sou_on == true) | (sou_on2 == true)) & (blok == false))
        {
            audios.Play();
            sound_on.re = false;
            sound_on2.re = false;
            Sound_on.SetActive(false);
            Sound_off.SetActive(true);
            Sound_vkl.SetActive(false);
            Sound_vikl.SetActive(true);
            sou_on = false;
            sou_on2 = false;
            Sound.SetActive(false);
            souuu = 1;
        }
        if ((blok == false))
            sou_off = sound_off.re;
        if ((blok == false))
            sou_off2 = sound_off2.re;
        if (((sou_off == true) | (sou_off2 == true)) & (blok == false))
        {
            audios.Play();
            sound_off.re = false;
            sound_off2.re = false;
            Sound_on.SetActive(true);
            Sound_off.SetActive(false);
            Sound_vkl.SetActive(true);
            Sound_vikl.SetActive(false);
            sou_off = false;
            sou_off2 = false;
            Sound.SetActive(true);
            souuu = 0;
        }
        if ((blok == false))
            mus_off = music_off.re;
        if ((blok == false))
            mus_off2 = music_off2.re;
        if (((mus_off == true) | (mus_off2 == true)) & (blok == false))
        {
            audios.Play();
            music_off.re = false;
            music_off2.re = false;
            Music_on.SetActive(true);
            Music_off.SetActive(false);
            Music_vkl.SetActive(true);
            Music_vikl.SetActive(false);
            mus_off = false;
            mus_off2 = false;
            Music.SetActive(true);
            musss = 0;
        }
        if ((blok == false))
            mus_on = music_on.re;
        if ((blok == false))
            mus_on2 = music_on2.re;
        if (((mus_on == true) | (mus_on2 == true)) & (blok == false))
        {
            audios.Play();
            music_on.re = false;
            music_on2.re = false;
            Music_on.SetActive(false);
            Music_off.SetActive(true);
            Music_vkl.SetActive(false);
            Music_vikl.SetActive(true);
            mus_on = false;
            mus_on2 = false;
            Music.SetActive(false);
            musss = 1;
        }
        if ((blok == false))
            RUS = RUSS.re;
        if ((RUS == true) & (blok == false))
        {
            audios.Play();
            RUSS.re = false;
            Rus1_setting.SetActive(false);
            Rus2_online.SetActive(false);
            Rus3_profil.SetActive(false);
            Rus4_1x1.SetActive(false);
            Rus5_1x1x1x1.SetActive(false);
            Rus6_exit.SetActive(false);
            Rus7_win.SetActive(false);
            Rus8_exit_gl.SetActive(false);
            Eng1_setting.SetActive(true);
            Eng2_online.SetActive(true);
            Eng3_profil.SetActive(true);
            Eng4_1x1.SetActive(true);
            Eng5_1x1x1x1.SetActive(true);
            Eng6_exit.SetActive(true);
            Eng7_win.SetActive(true);
            Eng8_exit_gl.SetActive(true);
            RUS = false;
            lannn = 0;
        }
        if ((blok == false))
            ENG = ENGG.re;
        if ((ENG == true) & (blok == false))
        {
            audios.Play();
            ENGG.re = false;
            Eng1_setting.SetActive(false);
            Eng2_online.SetActive(false);
            Eng3_profil.SetActive(false);
            Eng4_1x1.SetActive(false);
            Eng5_1x1x1x1.SetActive(false);
            Eng6_exit.SetActive(false);
            Eng7_win.SetActive(false);
            Eng8_exit_gl.SetActive(false);
            Rus1_setting.SetActive(true);
            Rus2_online.SetActive(true);
            Rus3_profil.SetActive(true);
            Rus4_1x1.SetActive(true);
            Rus5_1x1x1x1.SetActive(true);
            Rus6_exit.SetActive(true);
            Rus7_win.SetActive(true);
            Rus8_exit_gl.SetActive(true);
            ENG = false;
            lannn = 1;
        }
        if ((blok == false))
            in_set = in_setting.re;
        if ((in_set == true) & (blok == false))
        {
            audios.Play();
            in_setting.re = false;
            Setting_OFF.SetActive(false);
            Setting_ON.SetActive(true);
            in_set = false;
        }
        if ((blok == false))
            out_set = out_setting.re;
        if ((out_set == true) & (blok == false))
        {
            audios.Play();
            out_setting.re = false;
            Setting_OFF.SetActive(true);
            Setting_ON.SetActive(false);
            out_set = false;
        }
        if ((blok == false))
        {
            in_pro = in_profile.re;
            if ((in_pro == true) & (blok == false))
            {
                audios.Play();
                in_profile.re = false;
                Profile_on.SetActive(true);
                in_pro = false;
                blok = true;
            }
        }
        out_pro = out_profile.re;
        if ((out_pro == true))
        {
            audios.Play();
            out_profile.re = false;
            Profile_on.SetActive(false);
            out_pro = false;
            blok = false;
            button.re = false;

            offline.re = false;
            offline2.re = false;
            online.re = false;
            online2.re = false;
            onlain_1x1.re = false;
            offlain_1x1.re = false;
            onlain_1x1x1x1.re = false;
            offlain_1x1x1x1.re = false;
            sound_on.re = false;
            sound_on2.re = false;
            sound_off.re = false;
            sound_off2.re = false;
            music_off.re = false;
            music_off2.re = false;
            music_on.re = false;
            music_on2.re = false;
            RUSS.re = false;
            ENGG.re = false;
            in_setting.re = false;
            out_setting.re = false;
            in_profile.re = false;
        }
        if ((blok2 == false) & (blok3 == false))
            in_fig = in_fight.re;
        if ((in_fig == true) & (blok2 == false) & (blok3 == false))
        {
            audios.Play();
            in_fight.re = false;
            button.re = false;
            Fight_off.SetActive(false);
            Fight_on.SetActive(true);
            in_fig = false;

        }
        if ((blok2 == false) & (blok3 == false))
            out_fig = out_fight.re;
        if ((out_fig == true) & (blok2 == false) & (blok3 == false))
        {
            out_fig = false;
            audios.Play();
            out_fight.re = false;
            button.re = false;
            Fight_off.SetActive(true);
            Fight_on.SetActive(false);


        }
        if ((blok3 == false))
            hom = home.re;
        if ((hom == true) & (blok3 == false))
        {
            audios.Play();
            home.re = false;
            button.re = false;
            exit_on.SetActive(true);
            hom = false;
            blok2 = true;
        }
        otm_exit = otmena_exit.re;
        cen_exit = cencel_exit.re;
        if ((otm_exit == true) | (cen_exit == true) | (Input.GetKey(KeyCode.Escape) | Input.GetKey(KeyCode.E)))
        {
            audios.Play();
            otmena_exit.re = false;
            cencel_exit.re = false;
            button.re = false;
            exit_on.SetActive(false);
            otm_exit = false;
            cen_exit = false;
            blok2 = false;
            in_fight.re = false;
            out_fight.re = false;
            home.re = false;

        }
        daa_exit = daaa_exit.re;
        yes_exit = yess_exit.re;
        if ((daa_exit == true) | (yes_exit == true))
        {
            audios.Play();
            daaa_exit.re = false;
            yess_exit.re = false;
            button.re = false;
            exit_on.SetActive(false);
            daa_exit = false;
            yes_exit = false;
            blok2 = false;
            menu_fight.SetActive(false);
            menu.SetActive(true);
            save = true;
            in_fight.re = false;
            out_fight.re = false;
            home.re = false;
            m1 = 0;
            m2 = 0;
            m3 = 0;
            m4 = 0;
            m5 = 0;
            m6 = 0;
            m7 = 0;
            m8 = 0;
            m9 = 0;
            m10 = 0;
            p1 = 0;
            p2 = 0;
            p3 = 0;
            p4 = 0;
            win_menu = 0;
            Win = false;
        }
        net_exit = nett_exit.re;
        noo_exit = nooo_exit.re;
        if ((net_exit == true) | (noo_exit == true))
        {
            audios.Play();
            nooo_exit.re = false;
            nett_exit.re = false;
            button.re = false;
            exit_on.SetActive(false);
            net_exit = false;
            noo_exit = false;
            blok2 = false;
            menu_fight.SetActive(false);
            menu.SetActive(true);
            save = false;
            in_fight.re = false;
            out_fight.re = false;
            home.re = false;

            win_menu = 0;
            Win = false;
            m1 = 0;
            m2 = 0;
            m3 = 0;
            m4 = 0;
            m5 = 0;
            m6 = 0;
            m7 = 0;
            m8 = 0;
            m9 = 0;
            m10 = 0;
            p1 = 0;
            p2 = 0;
            p3 = 0;
            p4 = 0;
        }

        daa_exit_gl = daaa_exit_gl.re;
        yes_exit_gl = yess_exit_gl.re;
        if ((daa_exit_gl == true) | (yes_exit_gl == true))
        {
            OnSave();
            audios.Play();
            daaa_exit_gl.re = false;
            yess_exit_gl.re = false;
            button.re = false;
            daa_exit_gl = false;
            yes_exit_gl = false;
            blok = false;
            //exit_on.SetActive(false);
            //menu_fight.SetActive(false);
            //menu.SetActive(true);
            //save = true;
            //in_fight.re = false;
            //out_fight.re = false;
            home.re = false;
            Application.Quit();
        }

        net_exit_gl = nett_exit_gl.re;
        noo_exit_gl = nooo_exit_gl.re;
        if ((net_exit_gl == true) | (noo_exit_gl == true) | (Input.GetKey(KeyCode.Escape)))
        {
            audios.Play();
            nett_exit_gl.re = false;
            nooo_exit_gl.re = false;
            button.re = false;
            net_exit_gl = false;
            noo_exit_gl = false;
            blok = false;
            exit_gl.SetActive(false);
            //exit_on.SetActive(false);
            //menu_fight.SetActive(false);
            //menu.SetActive(true);
            //save = true;
            //in_fight.re = false;
            //out_fight.re = false;
            home.re = false;

        }

        if ((menu.active == (true)) & (Znakomstvo.active == (false))
            & (Profile_on.active == (false)) & (exit_gl.active == (false))
            & (Input.GetKey(KeyCode.Escape)))
        {
            blok = true;
            exit_gl.SetActive(true);
        }

        obz_win = obzor_win.re;
        sur_win = survay_win.re;
        if ((obz_win == true) | (sur_win == true))
        {
            audios.Play();
            obzor_win.re = false;
            survay_win.re = false;
            button.re = false;
            win_on.SetActive(false);
            obz_win = false;
            sur_win = false;
            blok3 = false;
            in_fight.re = false;
            out_fight.re = false;
            home.re = false;
            obzor = true;
            //Obj141.SetActive(false);
            print("ебучий обзор");
            home.re = false;
            ///*
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {

                    field[i, j] = FieldField[i, j].type;



                    if ((i < 13) & (i > 1) & (j < 13) & (j > 1))
                    {
                       
                        {
                            FieldField[i, j].obj.GetComponent<Renderer>().material =
                                matfield[FieldField[i, j].type - 1];
                        }

                    }

                }

            }
            /////*/
        }
        daa_win = daaa_win.re;
        yes_win = yess_win.re;
        if ((daa_win == true) | (yes_win == true))
        {
            //Win = false;
            audios.Play();
            daaa_win.re = false;
            yess_win.re = false;
            button.re = false;
            win_on.SetActive(false);
            daa_win = false;
            yes_win = false;
            blok3 = false;
            menu_fight.SetActive(false);
            menu.SetActive(true);
            save = false;
            print("ДДАА");
            //in_fight.re=false;
            //in_fight.re = false;
            in_fight.re = false;
            out_fight.re = false;
            home.re = false;
            //save = false;
            home.re = false;
            win_menu = 0;
            Win = false;
            m1 = 0;
            m2 = 0;
            m3 = 0;
            m4 = 0;
            m5 = 0;
            m6 = 0;
            m7 = 0;
            m8 = 0;
            m9 = 0;
            m10 = 0;
            p1 = 0;
            p2 = 0;
            p3 = 0;
            p4 = 0;
        }
        net_win = nett_win.re;
        noo_win = nooo_win.re;
        if ((net_win == true) | (noo_win == true) | (Input.GetKey(KeyCode.Escape)))
        {
            home.re = false;
            //Win = false;
            audios.Play();
            nooo_win.re = false;
            nett_win.re = false;
            button.re = false;
            win_on.SetActive(false);
            net_win = false;
            noo_win = false;
            blok3 = false;
            in_fight.re = false;
            out_fight.re = false;
        }
        
        if ((Input.GetKey(KeyCode.Q)) | (Win == true)&(win_menu<1))
        {
            win_on.SetActive(true);
            blok3 = true;
            win_menu++;
        }
        if (name.Length > 3)
            dal_z = dalee_z.re;
        else dalee_z.re = false;
        if ((dal_z == true) & (name.Length > 3))
        {
            audios.Play();
            dalee_z.re = false;
            Znakomstvo.SetActive(false);
            dal_z = false;
            blok = false;

            in_profile.re = false;
            offline.re = false;
            offline2.re = false;
            online.re = false;
            online2.re = false;
            onlain_1x1.re = false;
            offlain_1x1.re = false;
            onlain_1x1x1x1.re = false;
            offlain_1x1x1x1.re = false;
            sound_on.re = false;
            sound_on2.re = false;
            sound_off.re = false;
            sound_off2.re = false;
            music_off.re = false;
            music_off2.re = false;
            music_on.re = false;
            music_on2.re = false;
            RUSS.re = false;
            ENGG.re = false;
            in_setting.re = false;
            out_setting.re = false;
        }
        if ((name == "") & (l == 1))
        {
            Znakomstvo.SetActive(true);
            blok = true;
        }
        if (l == 0)
        {
            Znakomstvo.SetActive(false);
        }
        if ((Input.GetKey(KeyCode.Escape)) | (Input.GetKey(KeyCode.E)))
        {
            if ((button_1x1_1x1x1x1_offine.active == true) & (Setting_ON.active == false) & (Profile_on.active == false))
            {
                button_1x1_1x1x1x1_offine.SetActive(false);
                button_Online_offline.SetActive(true);
            }
            if ((button_1x1_1x1x1x1_online.active == true) & (Setting_ON.active == false) & (Profile_on.active == false))
            {
                button_1x1_1x1x1x1_online.SetActive(false);
                button_Online_offline.SetActive(true);
            }
            if ((Setting_ON.active == true) & (Profile_on.active == false))
            {
                Setting_ON.SetActive(false);
                Setting_OFF.SetActive(true);
            }
            if (Profile_on.active == true)
            {
                Profile_on.SetActive(false);
                in_profile.re = false;
                in_pro = false;
                blok = false;
            }
        }

        if (Znakomstvo.active == true)
        {
            name = Name.text;
        }
        name = name.Trim(new char[] { ' ', ',', '.', ';', ':', '?', '!', '%', '(', ')' });
        Trophy_main.text = trophy.ToString();
        Money_main.text = money.ToString();
        Trophy_profile.text = trophy.ToString();
        Win1_profile.text = win1.ToString();
        Win2_profile.text = win2.ToString();
        Name_profile.text = name.ToString();
        M_1x1_1.text = m1.ToString();
        M_1x1_2.text = m2.ToString();
        M_1x1x1x1_1.text = m3.ToString();
        M_1x1x1x1_2.text = m4.ToString();
        M_1x1x1x1_2.text = m5.ToString();
        M_1x1x1x1_4.text = m6.ToString();
        PlayerN_win.text = ("Player " + winer.ToString() + " won!");
        IgrokN_win.text = ("Игрок " + winer.ToString() + " победил!");

        //  void Main(string[] args)
        {
            /*      try
                  {
                      // A?A?A‚A?A?A?A‚A?A?A?A‚A•A?A?A‚A?A?A?A‚A°A?A?A‚A?A?A?A‚A?A?A?A‚Aµ A?a€?A‚A?A?A?A‚A?A?A?A‚A•A?A?A‚AµA?A?A‚A?A?A?A‚A?A?A?A‚A»A?a€?A‚A?A?a€?A?a€sA¬A?A?A‚A° A?A?A‚A?A?A?A‚A»A?A?A‚A°A?a€?A‚A?A?a€?A‚A?A?A?A‚A° StreamReader A?A?A‚A?A?A?A‚A»A?a€?A‚A? A?a€?A?a‚¬A?A?a€?A?a‚¬A?A?A?A‚AµA?A?A‚A?A?A?A‚A?A?a€?A‚A? A?A?A‚A?A?A?A‚A• A?a€?A?a‚¬A?A?A?A‚A°A?A?A‚A?A?A?A‚A»A?A?A‚A°.
                      // A?A?A…A?A?A?A‚A?A?A?A‚AµA?a€?A?a€sA¬A?A?A‚A°A?a€?A?a‚¬A?A?A?A‚A?A?a€?A?a€sA¬ using A?A?A‚A?A?A?A‚A±A?a€?A?a€sA¬A?A?A‚A°A?A?A‚A?A?A?A‚A»A?a€?A‚A?A?A?A‚AµA?a€?A?a‚¬A? A?A?A‚A?A?A?A‚A?A?A?A‚A?, A?A?A‚A?A?A?A‚A?A?A?A‚Aµ A?A?A‚A?A?a€?A‚A?A?A?A‚A?A?A?A‚A?A?A?A‚A»A?a€?A…a€™A?A?A‚A•A?a€?A†a€™A?A?A‚AµA?a€?A?a‚¬A?A?a€?A‚A?A?a€?A‚A? StreamReader.
                      using (StreamReader sr = new StreamReader("c:/temp/mytext.txt"))
                      {
                         // string line;
                          // A?A?A…A?A?A?A‚A?A?a€?A‚A?A?a€?A?a‚¬A?A?a€?A?a€sA¬A?A?A‚A?A?a€?A?a‚¬A?A?A?A‚A?A?A?A‚A?A?A?A‚Aµ A?a€?A?a‚¬A?A?a€?A?a‚¬A?A?A?A‚AµA?A?A‚A?A?A?A‚A?A?A?A‚Aµ A?a€?A?a‚¬A?A?A?A‚A°A?A?A‚A?A?A?A‚A»A?A?A‚A° A?A?A‚A? A?A?A‚A?A?a€?A?a‚¬A?A?A?A‚A?A?A?A‚A±A?a€?A?a€sA¬A?A?A‚A°A?A?A‚A¶A?A?A‚AµA?A?A‚A?A?A?A‚A?A?A?A‚Aµ A?a€?A‚A?A?a€?A?a‚¬A?A?A?A‚A?A?a€?A?a‚¬A¦ A?a€?A‚A?A?a€?A?a‚¬A?A?a€?A?a€sA¬A?A?A‚A?A?A?A‚A?,
                          // A?A?A‚A?A?A?A‚A?A?A?A‚A?A?A?A‚A° A?A?A‚A?A?A?A‚Aµ A?A?A‚A±A?a€?A†a€™A?A?A‚A?A?A?A‚AµA?a€?A?a‚¬A? A?A?A‚A?A?A?A‚A?A?a€?A‚A?A?a€?A?a‚¬A?A?A?A‚A?A?A?A‚A?A?A?A‚A?A?a€?A†a€™A?a€?A?a‚¬A? A?A?A‚A?A?A?A‚A?A?A?A‚A?A?A?A‚AµA?a€?A?a‚¬  A?a€?A?a‚¬A?A?A?A‚A°A?A?A‚A?A?A?A‚A»A?A?A‚A°.
                        // while ((line = sr.ReadLine()) != null)
                             // Console.WriteLine(line);
                             for (int i=1; i<=7; i++)
                          {
                           // sr.ReadLine(t[i]);
                          }
                      }
                  }
                  catch (Exception e)
                  {
                      // A?A?A…A?A?A?A‚A±A?a€?A?a€sA¬A?A?A‚A°A?A?A‚A±A?A?A‚A?A?a€?A?a‚¬A?A?A?A‚A?A?A?A‚A° A?A?A‚A?A?a€?A‚A?A?A?A‚A?A?A?A‚A»A?a€?A…A?A?a€?A?a‚¬A?A?A?A‚AµA?A?A‚A?A?A?A‚A?A?a€?A‚A? A?A?A‚A?A?A?A‚A°A?a€?A‚A?A?a€?A?a‚¬A? A?A?A‚A?A?A?A‚A?A?A?A‚A»A?a€?A…a€™A?A?A‚A•A?A?A‚A?A?A?A‚A?A?A?A‚A°A?a€?A?a‚¬A?A?A?A‚AµA?A?A‚A»A?a€?A…A? A?A?A‚A?A?A?A‚A?A?a€?A?a‚¬A?A?A?A‚A?A?a€?A?a€sA¬A?A?A‚A?A?A?A‚A°A?a€?A?a‚¬ A?A?A‚A?A?a€?A…A?,
                      // A?a€?A?a‚¬A?A?a€?A?a‚¬A?A?A?A‚A? A?A?A‚A?A?A?A‚A?A?a€?A‹a€ A?A?A‚A»A?A?A‚A? A?A?A‚A?A?A?A‚Aµ A?a€?A?a‚¬A?A?A?A‚A°A?A?A‚A?.
                      Console.WriteLine("The file could not be read:");
                      Console.WriteLine(e.Message);
                  }
                  Console.ReadKey();*/
        }
        /*if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {


                if ((hit.collider.name == Obj139.name) & (Obj139.active == (true)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj139.SetActive(false);
                    can_die = false;
                }
                else if ((hit.collider.name == Obj186.name) & (Obj139.active == (false)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj139.SetActive(true);
                    can_die = true;
                }
                if ((hit.collider.name == Obj140.name) & (Obj140.active == (true)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj140.SetActive(false);
                    swim_only_forward = false;
                }
                else if ((hit.collider.name == Obj187.name) & (Obj140.active == (false)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj140.SetActive(true);
                    swim_only_forward = true;
                }
                if ((hit.collider.name == Obj141.name) & (Obj141.active == (true)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj141.SetActive(false);
                    hidden_field = false;
                }
                else if ((hit.collider.name == Obj188.name) & (Obj141.active == (false)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj141.SetActive(true);
                    hidden_field = true;
                }
                if ((hit.collider.name == Obj142.name) & (Obj142.active == (true)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj142.SetActive(false);
                    unlimited_plane = false;
                }
                else if ((hit.collider.name == Obj189.name) & (Obj142.active == (false)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj142.SetActive(true);
                    unlimited_plane = true;
                }
                if ((hit.collider.name == Obj143.name) & (Obj143.active == (true)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj143.SetActive(false);
                    steply_rotation = false;
                }
                else if ((hit.collider.name == Obj190.name) & (Obj143.active == (false)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj143.SetActive(true);
                    steply_rotation = true;
                }
                if ((hit.collider.name == Obj144.name) & (Obj144.active == (true)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj144.SetActive(false);
                    sequence = false;
                }
                if ((hit.collider.name == Obj191.name) & (Obj144.active == (false)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj144.SetActive(true);
                    sequence = true;
                }
                if ((hit.collider.name == Obj145.name) & (Obj145.active == (true)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj145.SetActive(false);
                    unlimited_moving = false;
                }
                else if ((hit.collider.name == Obj192.name) & (Obj145.active == (false)))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj145.SetActive(true);
                    unlimited_moving = true;
                }

                if ((hit.collider.name == Obj130.name) | (hit.collider.name == Obj288.name))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj126.SetActive(true);
                    Obj125.SetActive(false);
                }
                if ((hit.collider.name == Obj131.name) | (hit.collider.name == Obj290.name))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj127.SetActive(true);
                    Obj125.SetActive(false);
                }
                if ((hit.collider.name == Obj129.name) | (hit.collider.name == Obj292.name))
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj128.SetActive(true);
                    Obj125.SetActive(false);
                }
                if (hit.collider.name == Obj146.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj193.SetActive(true);
                }
                if (hit.collider.name == Obj194.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj193.SetActive(false);
                }
                if (hit.collider.name == Obj147.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj195.SetActive(true);
                }
                if (hit.collider.name == Obj196.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj195.SetActive(false);
                }
                if (hit.collider.name == Obj148.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj197.SetActive(true);
                }
                if (hit.collider.name == Obj198.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj197.SetActive(false);
                }
                if (hit.collider.name == Obj149.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj199.SetActive(true);
                }
                if (hit.collider.name == Obj200.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj199.SetActive(false);
                }
                if (hit.collider.name == Obj150.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj201.SetActive(true);
                }
                if (hit.collider.name == Obj202.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj201.SetActive(false);
                }
                if (hit.collider.name == Obj151.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj203.SetActive(true);
                }
                if (hit.collider.name == Obj204.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj203.SetActive(false);
                }
                if (hit.collider.name == Obj152.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj205.SetActive(true);
                }
                if (hit.collider.name == Obj206.name)
                {
                    print(hit.collider.name);
                    audios.Play();
                    Obj205.SetActive(false);
                }
            }
        }*/



        /*  if (Obj28.active == (true))
          {
              p1 = 1;
          }
          if (Obj29.active == (true))
          {
              p2 = 1;
          }
          if (Obj30.active == (true))
          {
              p1 = 1;
          }
          if (Obj31.active == (true))
          {
              p2 = 1;
          }
          if (Obj32.active == (true))
          {
              p3 = 1;
          }
          if (Obj33.active == (true))
          {
              p4 = 1;
          }
          if (Obj34.active == (true))
          {
              p1 = 1;
          }
          if (Obj35.active == (true))
          {
              p2 = 1;
          }
          if (Obj36.active == (true))
          {
              p3 = 1;
          }
          if (Obj37.active == (true))
          {
              p4 = 1;
          }

          if (Obj38.active == (true))
          {
              p1 = -1;
          }
          if (Obj39.active == (true))
          {
              p2 = -1;
          }
          if (Obj40.active == (true))
          {
              p1 = -1;
          }
          if (Obj41.active == (true))
          {
              p2 = -1;
          }
          if (Obj42.active == (true))
          {
              p3 = -1;
          }
          if (Obj43.active == (true))
          {
              p4 = -1;
          }
          if (Obj44.active == (true))
          {
              p1 = -1;
          }
          if (Obj45.active == (true))
          {
              p2 = -1;
          }
          if (Obj46.active == (true))
          {
              p3 = -1;
          }
          if (Obj47.active == (true))
          {
              p4 = -1;
          }*/
        //sumpole = sum - m1 - m2 - m3 - m4 - m5 - m6 - m7 - m8 - m9 - m10;
        
        if (((m1 > m2) | ((m3 > m4) & (m3 > m5) & (m3 > m6)) | ((m7 > m8) & (m7 > m9) & (m7 > m10))) & (Win == false))
        {
            winer = 1f;
        }
        if (((m1 < m2) | ((m4 > m3) & (m4 > m5) & (m4 > m6)) | ((m8 > m7) & (m8 > m9) & (m8 > m10))) & (Win == false))
        {
            winer = 2f;
        }
        if ((((m5 > m4) & (m5 > m3) & (m5 > m6)) | ((m9 > m8) & (m9 > m7) & (m9 > m10))) & (Win==false))
        {
            winer = 3f;
        }
        if ((((m6 > m4) & (m6 > m5) & (m6 > m3)) | ((m10 > m8) & (m10 > m9) & (m10 > m7))) & (Win == false))
        {
            winer = 4f;
        }
        sumpole = 0;
        for (int gg = 0; gg < 37; gg++)
        {
            sumpole += Chest[gg].on_the_field;
        }

        sum = sumpole + m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m10;
        s1 = sum / 2;
        s2 = sum / 4;
        if ((m1 > s1) | (m2 > s2) | (m3 > s2) | (m4 > s2) | (m5 > s2) | (m6 > s2) | (m7 > s2)
            | (m8 > s2) | (m9 > s2) | (m10 > s2))
        {
            Win = true;
        }
        if (((m1 == m2) & (sumpole == 0f))
            | ((sumpole == 0) & ((m3 == m4) | (m3 == m5) | (m3 == m6)))
            | ((sumpole == 0) & ((m4 == m3) | (m4 == m5) | (m4 == m6)))
            | ((sumpole == 0) & ((m5 == m4) | (m5 == m3) | (m5 == m6)))
            | ((sumpole == 0) & ((m6 == m4) | (m6 == m5) | (m6 == m3))))
        {
            Win = true;
            winer = 0f;
        }

        float xPos = xx;
        if (Input.GetKey(KeyCode.D))
        {
            if (xPos > -50 + 65)
            {
                xPos = -5 + xPos;
                xx = xPos;
            }


        }
        if (Input.GetKey(KeyCode.A))
        {
            if (xPos < 50 + 65)
            {
                xPos = +5 + xPos;
                xx = xPos;
            }

        }

        /* float yPos = yy;
         if ((Input.GetKey(KeyCode.M)))
         {
             if (yPos < 70)
             {
                 yPos = 5 + yPos;
                 yy = yPos;
             }


         }
         if (Input.GetKey(KeyCode.N))
         {
             if (yPos > -100)
             {
                 yPos = -5 + yPos;
                 yy = yPos;
             }

         }
        */
        float zPos = zz;
        if (Input.GetKey(KeyCode.W))
        {
            if (zPos > -70 - 55)
            {
                zPos = -5 + zPos;
                zz = zPos;
            }


        }
        if (Input.GetKey(KeyCode.S))
        {
            if (zPos < 70 - 55)
            {
                zPos = +5 + zPos;
                zz = zPos;
            }

        }
        /* float yRat = yyy;
         if ((Input.GetKey(KeyCode.V)))
         {
             if (yRat < 90)
             {
                 yRat = 2 + yRat;
                 yyy = yRat;
             }


         }

         if (Input.GetKey(KeyCode.B))
         {
             if (yRat > 45)
             {
                 yRat = -2 + yRat;
                 yyy = yRat;
             }

         }*/

        //Obj15.transform.rotation = Quaternion.Euler(yRat, Obj15.transform.rotation.y, 0);
        Obj15.transform.position = new Vector3(xPos + 65f, Obj15.transform.position.y, zPos - 55f);
        // Obj15.transform.position = new Vector3(xPos +q1, yPos, zPos +q2);
        /* if (a1 == 1)
         { //Obj15.transform.position = new Vector3(xPos-65f , yPos , zPos+42f);
             //Obj15.transform.rotation = Quaternion.Euler(yRat, Obj15.transform.rotation.y, 0);
             Obj17.transform.rotation = Quaternion.Euler(yRat, 180f, 0f);
             Obj15.transform.position = new Vector3(xPos + 65f, yPos, zPos - 41f);
             //Obj15.transform.position = new Vector3(xPos + q1, yPos, zPos + q2);

         }
         if (a1 == 3)
         { //Obj15.transform.position = new Vector3(xPos+65f, yPos , zPos-95f);
           // Obj15.transform.rotation = Quaternion.Euler(yRat, Obj15.transform.rotation.y, 0);
             Obj17.transform.rotation = Quaternion.Euler(yRat, 360f, 0f);
             Obj15.transform.position = new Vector3(-xPos + 65f, yPos, -zPos - 70f);
             //Obj15.transform.position = new Vector3(xPos + q1, yPos, zPos + q2);
             print("3");
         }
         if (a1 == 2)
         {// Obj15.transform.position = new Vector3(xPos+65f , yPos , zPos+36f);
          // Obj15.transform.rotation = Quaternion.Euler(0, Obj15.transform.rotation.y, yRat);
             Obj17.transform.rotation = Quaternion.Euler(yRat, 270f, 0f);
             Obj15.transform.position = new Vector3(zPos + 80f, yPos, -xPos - 53f);
             // Obj15.transform.position = new Vector3(xPos + q1, yPos, zPos + q2);
             print("2");
         }
         if (a1 == 4)
         { //Obj15.transform.position = new Vector3(xPos-65f, yPos , zPos-88f);
             //Obj15.transform.rotation = Quaternion.Euler(0, Obj15.transform.rotation.y, yRat);
             Obj17.transform.rotation = Quaternion.Euler(yRat, 90f, 0f);
             Obj15.transform.position = new Vector3(-zPos + 50f, yPos, xPos - 55f);
             //Obj15.transform.position = new Vector3(xPos + q1, yPos, zPos + q2);
             print("4");

         }*/



        for (int ii = 0; ii < 15; ii++)
        {
            for (int jj = 0; jj < 15; jj++)
            {
                if (FieldField[ii, jj].type == 41)
                {
                    FieldField[ii, jj].opened = true;
                }
            }
        }
        for (int ii = 0; ii < 4; ii++)
        {
            Pizza[ii, 3].is_ship = true;


            for (int jj = 0; jj < 3; jj++)
            {
                if (FieldField[Pizza[ii, jj].z, Pizza[ii, jj].x].type == 18)
                    Pizza[ii, jj].drunk = true;
                else
                    Pizza[ii, jj].drunk = false;
                if (Pizza[ii, jj].drunk == false)
                    Pizza[ii, jj].mq = MovesQuan;

                FieldField[Pizza[ii, jj].z, Pizza[ii, jj].x].opened = true;
                Pizza[ii, jj].am = 0;

                if ((Pizza[ii, jj].mq <= MovesQuan - 5 && (Mode == 1 || Mode == 2)) || (Pizza[ii, jj].mq <= MovesQuan - 3 && Mode == 0))
                {
                  //  Debug.Log("CCCCCC");
                    Pizza[ii, jj].drunk = false;
                }
                //feature//

                if (can_die)
                {
                    if (FieldField[Pizza[ii, jj].z, Pizza[ii, jj].x].type == 30)
                    {

                        Pizza[ii, jj].dead = true;
                        Pizza[ii, jj].tapped = false;
                        Pizza[ii, jj].Death();
                        Pizza[ii, jj].QuanToGo = -1;

                    }
                }
                if (Pizza[ii, jj].tapped)
                {

                    int i = Pizza[ii, jj].z;
                    int j = Pizza[ii, jj].x;

                    switch (FieldField[i, j].type)
                    {
                        case 5:
                            if (FieldField[Pizza[ii, jj].z1, Pizza[ii, jj].x1].type != 31 && FieldField[Pizza[ii, jj].z1, Pizza[ii, jj].x1].type != 29)
                                Lightn[i + (i - Pizza[ii, jj].z1), j + (j - Pizza[ii, jj].x1)].SetActive(true);
                            if (FieldField[Pizza[ii, jj].z1, Pizza[ii, jj].x1].type == 31)
                                goto koni;
                            if (FieldField[Pizza[ii, jj].z1, Pizza[ii, jj].x1].type == 29)
                                goto samolet;
                            break;

                        case 6:

                            switch (FieldField[i, j].orintation)
                            {
                                case 3: Lightn[i + 1, j].SetActive(true); break;
                                case 0: Lightn[i, j - 1].SetActive(true); break;
                                case 1: Lightn[i - 1, j].SetActive(true); break;
                                case 2: Lightn[i, j + 1].SetActive(true); break;
                            }
                            Pizza[ii, jj].am++;
                            break;
                        case 7:
                            switch (FieldField[i, j].orintation)
                            {
                                case 3: Lightn[i + 1, j + 1].SetActive(true); break;
                                case 0: Lightn[i + 1, j - 1].SetActive(true); break;
                                case 1: Lightn[i - 1, j - 1].SetActive(true); break;
                                case 2: Lightn[i - 1, j + 1].SetActive(true); break;
                            }
                            Pizza[ii, jj].am++;
                            break;
                        case 8:
                            switch (FieldField[i, j].orintation)
                            {
                                case 1:
                                    Lightn[i + 1, j].SetActive(true);
                                    Lightn[i - 1, j].SetActive(true);
                                    break;

                                case 3:
                                    Lightn[i + 1, j].SetActive(true);
                                    Lightn[i - 1, j].SetActive(true);
                                    break;

                                case 2:
                                    Lightn[i, j - 1].SetActive(true);
                                    Lightn[i, j + 1].SetActive(true);
                                    break;
                                case 0:
                                    Lightn[i, j - 1].SetActive(true);
                                    Lightn[i, j + 1].SetActive(true);
                                    break;

                            }
                            Pizza[ii, jj].am += 2;
                            break;
                        case 9:
                            switch (FieldField[i, j].orintation)
                            {
                                case 1:
                                    Lightn[i + 1, j + 1].SetActive(true);
                                    Lightn[i - 1, j - 1].SetActive(true);
                                    break;
                                case 3:
                                    Lightn[i + 1, j + 1].SetActive(true);
                                    Lightn[i - 1, j - 1].SetActive(true);
                                    break;

                                case 2:
                                    Lightn[i + 1, j - 1].SetActive(true);
                                    Lightn[i - 1, j + 1].SetActive(true);
                                    break;
                                case 0:
                                    Lightn[i + 1, j - 1].SetActive(true);
                                    Lightn[i - 1, j + 1].SetActive(true);
                                    break;

                            }
                            Pizza[ii, jj].am += 2;
                            break;

                        case 10:
                            switch (FieldField[i, j].orintation)
                            {
                                case 3:
                                    Lightn[i - 1, j + 1].SetActive(true);
                                    Lightn[i + 1, j].SetActive(true);
                                    Lightn[i, j - 1].SetActive(true);
                                    break;
                                case 0:
                                    Lightn[i + 1, j + 1].SetActive(true);
                                    Lightn[i - 1, j].SetActive(true);
                                    Lightn[i, j - 1].SetActive(true);
                                    break;
                                case 1:
                                    Lightn[i + 1, j - 1].SetActive(true);
                                    Lightn[i - 1, j].SetActive(true);
                                    Lightn[i, j + 1].SetActive(true);
                                    break;
                                case 2:
                                    Lightn[i - 1, j - 1].SetActive(true);
                                    Lightn[i + 1, j].SetActive(true);
                                    Lightn[i, j + 1].SetActive(true);
                                    break;
                            }
                            Pizza[ii, jj].am += 3;
                            break;
                        case 11:
                            Lightn[i + 1, j].SetActive(true);
                            Lightn[i - 1, j].SetActive(true);
                            Lightn[i, j + 1].SetActive(true);
                            Lightn[i, j - 1].SetActive(true);
                            Pizza[ii, jj].am += 4;
                            break;
                        case 12:
                            Lightn[i + 1, j + 1].SetActive(true);
                            Lightn[i - 1, j + 1].SetActive(true);
                            Lightn[i + 1, j - 1].SetActive(true);
                            Lightn[i - 1, j - 1].SetActive(true);
                            Pizza[ii, jj].am += 4;
                            break;
                        case 13:
                            if (Pizza[ii, jj].frsttime == true && Pizza[ii, jj].untrapped == false)
                                Pizza[ii, jj].trapped = true;
                            Pizza[ii, jj].frsttime = false;
                            for (int kkk = 0; kkk < 4; kkk++)
                            {
                                for (int mm = 0; mm < 4; mm++)
                                {
                                    if (Pizza[ii, kkk].z == Pizza[ii, mm].z && Pizza[ii, kkk].x == Pizza[ii, mm].x && kkk != mm)
                                    {
                                        Pizza[ii, kkk].trapped = false;
                                        Pizza[ii, mm].trapped = false;
                                    }
                                }
                            }
                            if (Pizza[ii, jj].trapped == false)
                            {
                                goto def;
                            }
                            break;
                        case 14:
                            Pizza[ii, jj].QuanToGo = 1;
                            if (Pizza[ii, jj].timespent == Pizza[ii, jj].QuanToGo)
                                goto def;
                            else
                                Lightn[i, j].SetActive(true);
                            break;
                        case 15:
                            Pizza[ii, jj].QuanToGo = 2;
                            if (Pizza[ii, jj].timespent == Pizza[ii, jj].QuanToGo)
                                goto def;
                            else
                                Lightn[i, j].SetActive(true);
                            break;
                        case 16:
                            Pizza[ii, jj].QuanToGo = 3;
                            if (Pizza[ii, jj].timespent == Pizza[ii, jj].QuanToGo)
                                goto def;
                            else
                                Lightn[i, j].SetActive(true);
                            break;
                        case 17:
                            Pizza[ii, jj].QuanToGo = 4;
                            if (Pizza[ii, jj].timespent == Pizza[ii, jj].QuanToGo)
                                goto def;
                            else
                                Lightn[i, j].SetActive(true);
                            break;
                        case 18:

                            // if (can_die)
                            // {
                            //     Pizza[ii, jj].drunk = true;
                            // }
                            if (!Pizza[ii, jj].drunk)
                            {

                                goto def;

                            }
                            break;
                        case 19:
                            {
                                Lightn[Pizza[ii, jj].z1, Pizza[ii, jj].x1].SetActive(true);
                                break;
                            }
                        case 21:
                            switch (FieldField[i, j].orintation)
                            {
                                case 0: Lightn[13, j].SetActive(true); break;
                                case 1: Lightn[i, 1].SetActive(true); break;
                                case 2: Lightn[1, j].SetActive(true); break;
                                case 3: Lightn[i, 13].SetActive(true); break;
                            }
                            break;
                        case 28:
                            Pizza[ii, jj].shadowpriest = true;
                            goto def;
                            break;
                        case 31:

                        koni:
                            Lightn[i + 2, j + 1].SetActive(true);
                            Lightn[i + 2, j - 1].SetActive(true);
                            Lightn[i - 2, j + 1].SetActive(true);
                            Lightn[i - 2, j - 1].SetActive(true);
                            Lightn[i + 1, j + 2].SetActive(true);
                            Lightn[i - 1, j + 2].SetActive(true);
                            Lightn[i - 1, j - 2].SetActive(true);
                            Lightn[i + 1, j - 2].SetActive(true);
                            break;






                        case 29:
                        samolet:
                            if (planeisused == false)
                            {
                                for (int k1 = 0; k1 < 11; k1++)
                                {
                                    for (int k2 = 0; k2 < 11; k2++)
                                    {

                                        Lightn[k1 + 2, k2 + +2].SetActive(true);
                                        if ((k2 == 0 && k1 == 0) || (k2 == 0 && k1 == 10) || (k2 == 10 && k1 == 0) || (k2 == 10 && k1 == 10))
                                            Lightn[k1 + 2, k2 + +2].SetActive(false);

                                    }
                                }
                            }
                            else
                                goto def;
                            break;
                        case 20:

                            Lightn[Pizza[ii, 3].z, Pizza[ii, 3].x].SetActive(true);

                            break;
                        case 41:
                            if (j == 0)
                            {
                                Lightn[i + 1, j + 1].SetActive(true);
                                Lightn[i - 1, j + 1].SetActive(true);
                                Lightn[i, j + 1].SetActive(true);
                            }
                            if (j == 14)
                            {
                                Lightn[i + 1, j - 1].SetActive(true);
                                Lightn[i - 1, j - 1].SetActive(true);
                                Lightn[i, j - 1].SetActive(true);
                            }
                            if (i == 0)
                            {
                                Lightn[i + 1, j + 1].SetActive(true);
                                Lightn[i + 1, j - 1].SetActive(true);
                                Lightn[i + 1, j].SetActive(true);
                            }
                            if (i == 14)
                            {
                                Lightn[i - 1, j - 1].SetActive(true);
                                Lightn[i - 1, j + 1].SetActive(true);
                                Lightn[i - 1, j].SetActive(true);
                            }
                            if (!(i == Pizza[ii, 3].z) || !(j == Pizza[ii, 3].x))
                            {
                                for (int iii = 0; iii < 4; iii++)
                                {
                                    if (j == 1 || j == 13)
                                    {
                                        if (i + 1 <= 11)
                                            Lightn[i + 1, j].SetActive(true);
                                        if (i - 1 >= 3)
                                            Lightn[i - 1, j].SetActive(true);
                                        if (i == 11 && j == 1)
                                            Lightn[i + 1, j + 1].SetActive(true);
                                        if (i == 3 && j == 1)
                                            Lightn[i - 1, j + 1].SetActive(true);
                                        if (i == 11 && j == 13)
                                            Lightn[i + 1, j - 1].SetActive(true);
                                        if (i == 3 && j == 13)
                                            Lightn[i - 1, j - 1].SetActive(true);

                                        if ((((i == Pizza[iii, 3].z + 1) && (j == Pizza[iii, 3].x)) ||
                                            ((i == Pizza[iii, 3].z - 1) && (j == Pizza[iii, 3].x))) &&
                                            ArseniyIsALazyDumbStubbornBitch &&
                                            !(swim_only_forward)) //pirates can swim  round the ship
                                        {

                                            if (j == 1)
                                            {
                                                Lightn[Pizza[iii, 3].z, Pizza[iii, 3].x - 1].SetActive(true);

                                            }
                                            if (j == 13)
                                                Lightn[Pizza[iii, 3].z, Pizza[iii, 3].x + 1].SetActive(true);
                                        }
                                    }
                                    if (i == 1 || i == 13)
                                    {
                                        if (j + 1 <= 11)
                                            Lightn[i, j + 1].SetActive(true);
                                        if (j - 1 >= 3)
                                            Lightn[i, j - 1].SetActive(true);
                                        if (i == 1 && j == 11)
                                            Lightn[i + 1, j + 1].SetActive(true);
                                        if (i == 1 && j == 3)
                                            Lightn[i + 1, j - 1].SetActive(true);
                                        if (i == 13 && j == 11)
                                            Lightn[i - 1, j + 1].SetActive(true);
                                        if (i == 13 && j == 3)
                                            Lightn[i - 1, j - 1].SetActive(true);
                                        if ((((j == Pizza[iii, 3].x + 1) && (i == Pizza[iii, 3].z)) ||
                                            ((j == Pizza[iii, 3].x - 1) && (i == Pizza[iii, 3].z))) &&
                                            ArseniyIsALazyDumbStubbornBitch &&
                                            !(swim_only_forward))//pirates can swim  round the ship
                                        {

                                            if (i == 1)
                                                Lightn[Pizza[iii, 3].z - 1, Pizza[iii, 3].x].SetActive(true);
                                            else
                                                Lightn[Pizza[iii, 3].z + 1, Pizza[iii, 3].x].SetActive(true);
                                        }
                                    }
                                    if (i == 2 && j == 2)
                                    {
                                        Lightn[i + 1, j - 1].SetActive(true);
                                        Lightn[i - 1, j + 1].SetActive(true);
                                    }
                                    if (i == 12 && j == 2)
                                    {
                                        Lightn[i + 1, j + 1].SetActive(true);
                                        Lightn[i - 1, j - 1].SetActive(true);
                                    }
                                    if (i == 2 && j == 12)
                                    {
                                        Lightn[i + 1, j + 1].SetActive(true);
                                        Lightn[i - 1, j - 1].SetActive(true);
                                    }
                                    if (i == 12 && j == 12)
                                    {
                                        Lightn[i + 1, j - 1].SetActive(true);
                                        Lightn[i - 1, j + 1].SetActive(true);
                                    }
                                }
                            }

                            else
                            {
                                if (j == 1)
                                {
                                    if (i <= 10)
                                        Lightn[i + 1, j].SetActive(true);
                                    if (i >= 4)
                                        Lightn[i - 1, j].SetActive(true);
                                    Lightn[i, j + 1].SetActive(true);
                                    Pizza[ii, 3].is_ship = false;
                                    Pizza[ii, 3].tapped = true;

                                }
                                if (j == 13)
                                {
                                    if (i <= 10)
                                        Lightn[i + 1, j].SetActive(true);
                                    if (i >= 4)
                                        Lightn[i - 1, j].SetActive(true);
                                    Lightn[i, j - 1].SetActive(true);
                                    Pizza[ii, 3].is_ship = false;
                                    Pizza[ii, 3].tapped = true;
                                    /*  for (int m = 0; m < 3; m++)
                                      {
                                          if (Pizza[ii, m].z == Pizza[ii, 3].z && Pizza[ii, m].x == Pizza[ii, 3].x)
                                              Pizza[ii, m].tapped = true;
                                      }*/
                                }

                                if (i == 1)
                                {
                                    if (j <= 10)
                                        Lightn[i, j + 1].SetActive(true);
                                    if (j >= 4)
                                        Lightn[i, j - 1].SetActive(true);
                                    Lightn[i + 1, j].SetActive(true);
                                    Pizza[ii, 3].is_ship = false;
                                    Pizza[ii, 3].tapped = true;
                                    /*for (int m = 0; m < 3; m++)
                                    {
                                        if (Pizza[ii, m].z == Pizza[ii, 3].z && Pizza[ii, m].x == Pizza[ii, 3].x)
                                            Pizza[ii, m].tapped = true;
                                    }*/
                                }
                                if (i == 13)
                                {
                                    if (j <= 10)
                                        Lightn[i, j + 1].SetActive(true);
                                    if (j >= 4)
                                        Lightn[i, j - 1].SetActive(true);
                                    Lightn[i - 1, j].SetActive(true);
                                    Pizza[ii, 3].is_ship = false;
                                    Pizza[ii, 3].tapped = true;
                                    /* for (int m = 0; m < 3; m++)
                                      {
                                          if (Pizza[ii, m].z == Pizza[ii, 3].z && Pizza[ii, m].x == Pizza[ii, 3].x)
                                              Pizza[ii, m].tapped = true;
                                      }*/
                                }


                            }
                            break;
                        default:
                        def:
                            for (int _ = -1; _ < 2; _++)
                            {
                                for (int __ = -1; __ < 2; __++)
                                {
                                    if (!((__ == 0) && (_ == 0)))
                                    {
                                        if ((i + _ < 15) && (i + _ >= 0) &&
                                            (j + __ < 15) && (j + __ >= 0))
                                        {
                                            if (FieldField[i + _, j + __].type != 41 || ((Pizza[ii, 3].z == i + _) && (Pizza[ii, 3].x == j + __)))
                                                Lightn[i + _, j + __].SetActive(true);
                                           
                                        }
                                    }
                                }
                            }

                            break;
                    }
                    for (int kk = 0; kk < 15; kk++)
                    {
                        for (int kkk = 0; kkk < 15; kkk++)
                        {
                            //if (FieldField[kk, kkk].type == 19 && FieldField[kk, kkk].opened == true && FieldField[Pizza[ii, jj].z, Pizza[ii, jj].x].is_arrow == false)
                            //  Lightn[kk, kkk].SetActive(false);
                            /*
                            if (Pizza[ii, jj].has_coin == true && 
                                FieldField[kk, kkk].opened == false)
                            {
                                Debug.Log("Logloglpg");
                                Lightn[kk, kkk].SetActive(false);
                            }*/

                            if (Pizza[ii, jj].has_coin &&
                                FieldField[kk, kkk].opened == false)
                            {
                                Lightn[kk, kkk].SetActive(false);
                            }

                            if (FieldField[kk, kkk].type == 27 || FieldField[kk, kkk].type == 28)
                            {

                                for (int ll = 0; ll < 4; ll++)
                                {
                                    for (int lll = 0; lll < 4; lll++)
                                    {
                                        if ((Pizza[ll, lll].z == kk && Pizza[ll, lll].x == kkk && ii != ll) || Pizza[ii, jj].has_coin == true)
                                            Lightn[kk, kkk].SetActive(false);
                                    }
                                }
                            }
                        }
                    }
                    if (FieldField[Pizza[ii, jj].z, Pizza[ii, jj].x].is_arrow == true && Pizza[ii, jj].has_coin == true)
                    {
                        for (int p = 0; p < 15; p++)
                        {
                            for (int pp = 0; pp < 15; pp++)
                            {
                                if (Lightn[p, pp].active == true)
                                {
                                    goto point2;
                                }
                            }
                        }
                        //Pizza[ii, jj].Death();
                        //Pizza[ii, jj].dead = true;
                        for (int asd = 0; asd < 37; asd++)
                        {
                            if (Chest[asd].chosen == true)
                            {
                                Chest[asd].coin.transform.position = Chest[asd].CoinStartPosition;
                                Chest[asd].ci = Chest[asd].Startci;
                                Chest[asd].cj = Chest[asd].Startcj;
                            }
                        }
                        MovesQuan++;
                        Pizza[ii, jj].has_coin = false;
                        Pizza[ii, jj].tapped = false;
                        for (int ppp = 0; ppp < 37; ppp++)
                        {
                            if (Chest[ppp].ci == Pizza[ii, jj].z && Chest[ppp].cj == Pizza[ii, jj].x)
                            {
                                Chest[ppp].coin.GetComponent<Renderer>().material
                                                        = mat36;
                                Chest[ppp].chosen = false;
                                Chest[ppp].coin.transform.position =
                                                new Vector3(FieldField[Pizza[ii, jj].zbeg, Pizza[ii, jj].xbeg].obj.transform.position.x, Chest[ppp].level * 0.3f,
                                                FieldField[Pizza[ii, jj].zbeg, Pizza[ii, jj].xbeg].obj.transform.position.z);
                                Chest[ppp].ci = Pizza[ii, jj].zbeg;
                                Chest[ppp].cj = Pizza[ii, jj].xbeg;
                                Chest[ppp].coin.transform.position = new Vector3(Chest[ppp].cj * 10f, Chest[ppp].level * 0.3f, Chest[ppp].ci * (-10f));
                            }
                        }
                    }
                point2: print(' ');



                    //}
                }

                /**/
                /*  if (Pizza[ii, jj].am == 0)
                  {
                      Pizza[ii, jj].dead = true;
                      Pizza[ii, jj].Death();
                          }*/
                if (Pizza[ii, jj].dead)
                {
                    if (Mode == 0)
                    {
                        if (ii == 0)
                        {
                            if (jj == 0)
                            {
                                Obj156.SetActive(true);
                            }
                            if (jj == 1)
                            {
                                Obj157.SetActive(true);
                            }
                            if (jj == 2)
                            {
                                Obj158.SetActive(true);
                            }
                        }
                        if (ii == 2)
                        {
                            if (jj == 0)
                            {
                                Obj159.SetActive(true);
                            }
                            if (jj == 1)
                            {
                                Obj160.SetActive(true);
                            }
                            if (jj == 2)
                            {
                                Obj161.SetActive(true);
                            }
                        }
                    }
                    if (Mode == 1)
                    {
                        if (ii == 0)
                        {
                            if (jj == 0)
                            {
                                Obj162.SetActive(true);
                            }
                            if (jj == 1)
                            {
                                Obj163.SetActive(true);
                            }
                            if (jj == 2)
                            {
                                Obj164.SetActive(true);
                            }
                        }
                        if (ii == 2)
                        {
                            if (jj == 0)
                            {
                                Obj165.SetActive(true);
                            }
                            if (jj == 1)
                            {
                                Obj166.SetActive(true);
                            }
                            if (jj == 2)
                            {
                                Obj167.SetActive(true);
                            }
                        }
                        if (ii == 1)
                        {
                            if (jj == 0)
                            {
                                Obj168.SetActive(true);
                            }
                            if (jj == 1)
                            {
                                Obj169.SetActive(true);
                            }
                            if (jj == 2)
                            {
                                Obj170.SetActive(true);
                            }
                        }
                        if (ii == 3)
                        {
                            if (jj == 0)
                            {
                                Obj171.SetActive(true);
                            }
                            if (jj == 1)
                            {
                                Obj172.SetActive(true);
                            }
                            if (jj == 2)
                            {
                                Obj173.SetActive(true);
                            }
                        }
                    }

                }
            }
        }

        if ((Pizza[0, 0].dead == true || Pizza[0, 0].trapped == true ||
            Pizza[0, 0].drunk == true) && (Pizza[0, 1].dead == true || 
            Pizza[0, 1].trapped == true || Pizza[0, 1].drunk == true) &&
            (Pizza[0, 2].dead == true || Pizza[0, 2].trapped == true || Pizza[0, 2].drunk == true))
        {
            allwhitedied = true;
            if (Pizza[0, 0].drunk != true && Pizza[0, 1].drunk != true && Pizza[0, 2].drunk != true)
            {
                whiteeliminated = true;
            }
            //else
                whiteeliminated = true;
            // Debug.Log("minusbelie");
        }
        else
            allwhitedied = false;
        if ((Pizza[1, 0].dead == true || Pizza[1, 0].trapped == true || Pizza[1, 0].drunk == true) && (Pizza[1, 1].dead == true || Pizza[1, 1].trapped == true || Pizza[1, 1].drunk == true) && (Pizza[1, 2].dead == true || Pizza[1, 2].trapped == true || Pizza[1, 2].drunk == true))
        {
            allreddied = true;
            if (Pizza[1, 0].drunk != true && Pizza[1, 1].drunk != true && Pizza[1, 2].drunk != true)
            {
                redeliminated = true;
            }
            //else
                redeliminated = true;
            // Debug.Log("minusbelie");
        }
        else
            allreddied = false;
        if ((Pizza[2, 0].dead == true || Pizza[2, 0].trapped == true || Pizza[2, 0].drunk == true) && (Pizza[2, 1].dead == true || Pizza[2, 1].trapped == true || Pizza[2, 1].drunk == true) && (Pizza[2, 2].dead == true || Pizza[2, 2].trapped == true || Pizza[2, 2].drunk == true))
        {
            allblackdied = true;
            if (Pizza[2, 0].drunk != true && Pizza[2, 1].drunk != true && Pizza[2, 2].drunk != true)
            {
                blackeliminated = true;
            }
            //else
                blackeliminated = true;
            // Debug.Log("minusbelie");
        }
        else
            allblackdied = false;
        if ((Pizza[3, 0].dead == true || Pizza[3, 0].trapped == true || Pizza[3, 0].drunk == true) && (Pizza[3, 1].dead == true || Pizza[3, 1].trapped == true || Pizza[3, 1].drunk == true) && (Pizza[3, 2].dead == true || Pizza[3, 2].trapped == true || Pizza[3, 2].drunk == true))
        {
            allyellowdied = true;
            if (Pizza[3, 0].drunk != true && Pizza[3, 1].drunk != true && Pizza[3, 2].drunk != true)
            {
                yelloweliminated = true;
            }
            //else
                yelloweliminated = true;
            // Debug.Log("minusbelie");
        }
        else
            allyellowdied = false;


        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                for (int ii = 0; ii < 4; ii++)
                {
                    if (whiteeliminated == true && Mode == 0)
                    {
                        Win = true;
                        winer = 2;
                    }
                    if (blackeliminated == true && Mode == 0)
                    {
                        Win = true;
                        winer = 1;

                    }
                    if (blackeliminated == true && redeliminated == true && yelloweliminated == true && (Mode == 1 || Mode == 2))
                    {
                        Win = true;
                        winer = 1;
                    }
                    if (whiteeliminated == true && redeliminated == true && yelloweliminated == true && (Mode == 1 || Mode == 2))
                    {
                        Win = true;
                        winer = 3;
                    }
                    if (whiteeliminated == true && blackeliminated == true && yelloweliminated == true && (Mode == 1 || Mode == 2))
                    {
                        Win = true;
                        winer = 2;
                    }
                    if (whiteeliminated == true && redeliminated == true && blackeliminated == true && (Mode == 1 || Mode == 2))
                    {
                        Win = true;
                        winer = 4;
                    }
                    if (allwhitedied == true && ii == 0 && MovesQuan % 4 == 0)
                    {
                        MovesQuan++;
                        ii++;
                    }
                    if (allreddied == true && ii == 1 && MovesQuan % 4 == 1)
                    {
                        MovesQuan++;
                        ii++;
                    }
                    if (allblackdied == true && ii == 2 && MovesQuan % 4 == 2)
                    {
                        MovesQuan++;
                        ii++;
                    }
                    if (allyellowdied == true && ii == 3 && MovesQuan % 4 == 3)
                    {
                        MovesQuan++;
                        ii = 0;
                    }

                    //here must be a checkplace for moving order
                    if ((ii == MovesQuan % 4 && (Mode == 2 || Mode == 1)) || (ii / 2 == MovesQuan % 2 && Mode == 0) || !(sequence))
                    {


                        for (int jj = 0; jj < 4; jj++)
                        {
                            if (hit.collider.name == Pizza[ii, jj].Pirate.name)
                            {

                              //  Debug.Log(ii);
                                //cheking if the pirate is tapped
                                for (int n = 0; n < 4; n++)
                                {
                                    for (int nn = 0; nn < 3; nn++)
                                    {
                                        if (Pizza[n, nn].tapped == true)
                                            goto skip;
                                    }
                                }
                                Pizza[ii, jj].tap();
                            skip:
                                for (int k1 = 0; k1 < 15; k1++)
                                {
                                    for (int k2 = 0; k2 < 15; k2++)
                                    {

                                        Lightn[k1, k2].SetActive(false);

                                    }
                                }


                                //untapping other tapped pirates

                                for (int _i = 0; _i < 4; _i++)
                                {
                                    for (int _j = 0; _j < 3; _j++)
                                    {
                                        if ((_i != ii) || (_j != jj) && FieldField[Pizza[_i, _j].z, Pizza[_i, _j].x].is_arrow == false)
                                        {
                                            Pizza[_i, _j].tapped = false;
                                        }
                                    }
                                }


                            }
                        }
                    }
                }
                for (int ll = 0; ll < 4; ll++)
                {
                    for (int lll = 0; lll < 4; lll++)
                    {
                        if (Pizza[ll, lll].shadowpriest == true)
                        {
                            Pizza[ll, lll].shadowpriest = false;
                            if (Pizza[ll, lll].tapped == true)
                            {
                                if (blok2 == false && blok3 == false)
                                {
                                    cre_1x1_1 = crest_1x1_1.re;
                                    cre_1x1_2 = crest_1x1_2.re;
                                    cre_1x1_3 = crest_1x1_3.re;
                                    cre_1x1_4 = crest_1x1_4.re;
                                    cre_1x1_5 = crest_1x1_5.re;
                                    cre_1x1_6 = crest_1x1_6.re;
                                    cre_1x1x1x1_1 = crest_1x1x1x1_1.re;
                                    cre_1x1x1x1_2 = crest_1x1x1x1_2.re;
                                    cre_1x1x1x1_3 = crest_1x1x1x1_3.re;
                                    cre_1x1x1x1_4 = crest_1x1x1x1_4.re;
                                    cre_1x1x1x1_5 = crest_1x1x1x1_5.re;
                                    cre_1x1x1x1_6 = crest_1x1x1x1_6.re;
                                    cre_1x1x1x1_7 = crest_1x1x1x1_7.re;
                                    cre_1x1x1x1_8 = crest_1x1x1x1_8.re;
                                    cre_1x1x1x1_9 = crest_1x1x1x1_9.re;
                                    cre_1x1x1x1_10 = crest_1x1x1x1_10.re;
                                    cre_1x1x1x1_11 = crest_1x1x1x1_11.re;
                                    cre_1x1x1x1_12 = crest_1x1x1x1_12.re;


                                    if ((cre_1x1_1) && ll == 0)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[0, 0].ressurect();
                                        Pizza[0, 0].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        Pizza[0, 0].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj156.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        if (lll == 1)
                                        {
                                            Pizza[0, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[0, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1_2) && ll == 0)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[0, 1].ressurect();
                                        Pizza[0, 1].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[0, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[0, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[0, 1].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj157.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1_3) && ll == 0)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[0, 2].ressurect();
                                        Pizza[0, 2].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[0, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        if (lll == 1)
                                        {
                                            Pizza[0, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        Pizza[0, 2].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj158.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1_4) && ll == 2)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[2, 0].ressurect();
                                        Pizza[2, 0].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 1)
                                        {
                                            Pizza[2, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[2, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[2, 0].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj159.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1_5) && ll == 2)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[2, 1].ressurect();
                                        Pizza[2, 1].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[2, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[2, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[2, 1].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj160.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1_6) && ll == 2)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[2, 2].ressurect();
                                        Pizza[2, 2].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[2, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        if (lll == 1)
                                        {
                                            Pizza[2, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        Pizza[2, 2].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj161.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1x1x1_1) && ll == 0)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[0, 0].ressurect();
                                        Pizza[0, 0].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 1)
                                        {
                                            Pizza[0, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[0, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[0, 0].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj162.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1x1x1_2) && ll == 0)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[0, 1].ressurect();
                                        Pizza[0, 1].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[0, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[0, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[0, 1].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj163.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1x1x1_3) && ll == 0)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[0, 2].ressurect();
                                        Pizza[0, 2].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[0, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        if (lll == 1)
                                        {
                                            Pizza[0, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        Pizza[0, 2].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj164.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1x1x1_4) && ll == 2)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[2, 0].ressurect();
                                        Pizza[2, 0].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 1)
                                        {
                                            Pizza[2, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[2, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[ll, lll].tapped = false;
                                        Obj165.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }

                                    if ((cre_1x1x1x1_5) && ll == 2)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[2, 1].ressurect();
                                        Pizza[2, 1].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[2, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[2, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[2, 1].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj166.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }

                                    if ((cre_1x1x1x1_6) && ll == 2)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[2, 2].ressurect();
                                        Pizza[2, 2].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[2, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        if (lll == 1)
                                        {
                                            Pizza[2, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        Pizza[2, 2].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj167.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1x1x1_7) && ll == 1)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[1, 0].ressurect();
                                        Pizza[1, 0].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 1)
                                        {
                                            Pizza[1, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[1, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[1, 0].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj168.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1x1x1_8) && ll == 1)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[1, 1].ressurect();
                                        Pizza[1, 1].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[1, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[1, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[1, 1].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj169.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1x1x1_9) && ll == 1)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[1, 2].ressurect();
                                        Pizza[1, 2].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[1, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        if (lll == 1)
                                        {
                                            Pizza[1, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        Pizza[1, 2].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj170.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1x1x1_10) && ll == 3)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[3, 0].ressurect();
                                        Pizza[3, 0].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 1)
                                        {
                                            Pizza[3, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[3, 0].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x - 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[3, 0].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj171.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1x1x1_11) && ll == 3)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[3, 1].ressurect();
                                        Pizza[3, 1].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[3, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z);
                                        }
                                        if (lll == 2)
                                        {
                                            Pizza[3, 1].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z - 7f);
                                        }
                                        Pizza[3, 1].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj172.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }
                                    if ((cre_1x1x1x1_12) && ll == 3)
                                    {
                                        crest_1x1_1.re = false;
                                        crest_1x1_2.re = false;
                                        crest_1x1_3.re = false;
                                        crest_1x1_4.re = false;
                                        crest_1x1_5.re = false;
                                        crest_1x1_6.re = false;
                                        crest_1x1x1x1_1.re = false;
                                        crest_1x1x1x1_2.re = false;
                                        crest_1x1x1x1_3.re = false;
                                        crest_1x1x1x1_4.re = false;
                                        crest_1x1x1x1_5.re = false;
                                        crest_1x1x1x1_6.re = false;
                                        crest_1x1x1x1_7.re = false;
                                        crest_1x1x1x1_8.re = false;
                                        crest_1x1x1x1_9.re = false;
                                        crest_1x1x1x1_10.re = false;
                                        crest_1x1x1x1_11.re = false;
                                        crest_1x1x1x1_12.re = false;
                                        Debug.Log("nanananan");
                                        Pizza[3, 2].ressurect();
                                        Pizza[3, 2].move(Pizza[ll, lll].x, Pizza[ll, lll].z);
                                        if (lll == 0)
                                        {
                                            Pizza[3, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x + 7f, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        if (lll == 1)
                                        {
                                            Pizza[3, 2].Pirate.transform.position =
                                                       new Vector3(Pizza[ll, lll].Pirate.transform.position.x, 0,
                                                       Pizza[ll, lll].Pirate.transform.position.z + 7f);
                                        }
                                        Pizza[3, 2].dead = false;
                                        Pizza[ll, lll].tapped = false;
                                        Obj173.SetActive(false);
                                        MovesQuan++;
                                        for (int k1 = 0; k1 < 15; k1++)
                                        {
                                            for (int k2 = 0; k2 < 15; k2++)
                                            {

                                                Lightn[k1, k2].SetActive(false);

                                            }
                                        }
                                        goto point1;
                                    }

                                }
                            }
                        }
                    }
                }

            point1:

                for (int ii = 0; ii < 15; ii++)
                {
                    for (int jj = 0; jj < 15; jj++)
                    {
                        if (hit.collider.name == Lightn[ii, jj].name)
                        {
                            for (int iii = 3; iii >= 0; iii--)
                            {
                                for (int jjj = 3; jjj >= 0; jjj--)
                                {


                                    if (Pizza[iii, jjj].tapped == true && Pizza[iii, jjj].is_ship == false)
                                    {
                                        if ((jjj == 3 && (jj == 1 || jj == 13 || ii == 1 || ii == 13)) || jjj != 3)
                                        {

                                            if (jjj == 3 && (jj == 1 || jj == 13 || ii == 1 || ii == 13))
                                            {
                                                for (int m = 0; m < 3; m++)
                                                {
                                                    if (Pizza[iii, m].z == Pizza[iii, 3].z && Pizza[iii, m].x == Pizza[iii, 3].x)
                                                    {
                                                        Pizza[iii, m].tapped = true;
                                                        MovesQuan--;
                                                    }
                                                }
                                            }

                                            if (FieldField[Pizza[iii, jjj].z, Pizza[iii, jjj].x].type == 29)
                                            {
                                                planeisused = true;
                                            }
                                            FieldField[ii, jj].open();
                                            int i = Pizza[iii, jjj].z;
                                            int j = Pizza[iii, jjj].x;



                                            for (int k1 = 0; k1 < 15; k1++)
                                            {
                                                for (int k2 = 0; k2 < 15; k2++)
                                                {

                                                    Lightn[k1, k2].SetActive(false);

                                                }
                                            }

                                            if (FieldField[ii, jj].first_tap)
                                            {

                                                FieldField[ii, jj].obj.transform.Rotate(0,
                                                 90 * FieldField[ii, jj].orintation, 0);

                                                FieldField[ii, jj].first_tap = false;

                                            }

                                            //"opening" the field 

                                            // FieldField[ii, jj].open();

                                            FieldField[ii, jj].obj.GetComponent<Renderer>().material =
                                                matfield[field[ii, jj] - 1];

                                            Vector3 dest = new Vector3(Lightn[ii, jj].transform.position.x, 0,
                                                Lightn[ii, jj].transform.position.z);
                                            t = 0.0f;
                                            FieldField[i, j].obj.transform.rotation = Quaternion.Euler(0, FieldField[i, j].orintation * 90, 0);
                                            /* while(Pizza[iii, jjj].Pirate.transform.position!=dest)
                                             {
                                                 if (Pizza[iii, jjj].Pirate.transform.position.x<dest.x)
                                                 {
                                                     Pizza[iii, jjj].Pirate.transform.position = new Vector3(Pizza[iii, jjj].Pirate.transform.position.x + 0.01f, 0, Pizza[iii, jjj].Pirate.transform.position.z);
                                                 }
                                                 if (Pizza[iii, jjj].Pirate.transform.position.x > dest.x)
                                                 {
                                                     Pizza[iii, jjj].Pirate.transform.position = new Vector3(Pizza[iii, jjj].Pirate.transform.position.x - 0.01f, 0, Pizza[iii, jjj].Pirate.transform.position.z);
                                                 }
                                                 if (Pizza[iii, jjj].Pirate.transform.position.z < dest.z)
                                                 {
                                                     Pizza[iii, jjj].Pirate.transform.position = new Vector3(Pizza[iii, jjj].Pirate.transform.position.x, 0, Pizza[iii, jjj].Pirate.transform.position.z + 0.01f);
                                                 }
                                                 if (Pizza[iii, jjj].Pirate.transform.position.z > dest.z)
                                                 {
                                                     Pizza[iii, jjj].Pirate.transform.position = new Vector3(Pizza[iii, jjj].Pirate.transform.position.x, 0, Pizza[iii, jjj].Pirate.transform.position.z - 0.01f);
                                                 }
                                                 Thread.Sleep(5);

                                             }*/
                                            float curtime = 0.0f;
                                            float time = 2.0f;

                                            //Vector3 def = Pizza[iii, jjj].Pirate.transform.position;
                                            Pizza[iii, jjj].Pirate.transform.position = dest;
                                            //while (curtime < time)
                                            //{
                                            //  Pizza[iii, jjj].Pirate.transform.position = Vector3.Lerp(def, dest, curtime / time);
                                            // curtime += Time.deltaTime;
                                            //Thread.Sleep(10);
                                            // }
                                            //Debug.Log("loh)");
                                            //StartCoroutine(SmoothMove(Pizza[iii, jjj].Pirate.transform.position, dest, 2));
                                            if (ii == i && jj == j)
                                                Pizza[iii, jjj].timespent++;
                                            else Pizza[iii, jjj].timespent = 0;
                                           // Debug.Log(Pizza[iii, jjj].timespent);

                                            // normal standing of pirates
                                            switch (field[ii, jj])
                                            {
                                                case 14:
                                                    if (Pizza[iii, jjj].timespent == 0)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+3.5f, 0, +3.5f);

                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+2.25f, 0, +1.335f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+1.0f, 0, +3.5f);
                                                                break;
                                                        }
                                                    }
                                                    if (Pizza[iii, jjj].timespent == 1)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-3.5f, 0, -3.5f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-2.25f, 0, -1.335f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-1.0f, 0, -3.5f);
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case 15:
                                                    if (Pizza[iii, jjj].timespent == 0)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-3.5f, 0, +3.5f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-2.25f, 0, +1.335f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-1.0f, 0, +3.5f);
                                                                break;
                                                        }
                                                    }
                                                    if (Pizza[iii, jjj].timespent == 1)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+2.7f, 0, +1.25f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+1.45f, 0, -0.915f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+0.2f, 0, +1.25f);
                                                                break;
                                                        }
                                                    }
                                                    if (Pizza[iii, jjj].timespent == 2)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-3.75f, 0, -3.75f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-2.5f, 0, -1.585f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-1.25f, 0, -3.75f);
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case 16:
                                                    if (Pizza[iii, jjj].timespent == 0)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-0.5f, 0, +3.5f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(0.75f, 0, +1.335f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(2.0f, 0, +3.5f);
                                                                break;
                                                        }
                                                    }
                                                    if (Pizza[iii, jjj].timespent == 1)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+4.0f, 0, +0.5f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+2.75f, 0, -1.665f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+1.5f, 0, +0.5f);
                                                                break;
                                                        }
                                                    }
                                                    if (Pizza[iii, jjj].timespent == 2)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(1.5f, 0, -3.5f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(0.25f, 0, -1.335f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-1.0f, 0, -3.5f);
                                                                break;
                                                        }
                                                    }
                                                    if (Pizza[iii, jjj].timespent == 3)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-3.75f, 0, -1f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-2.5f, 0, -3.165f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-1.25f, 0, -1f);
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case 17:
                                                    if (Pizza[iii, jjj].timespent == 0)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-3.5f, 0, +3.5f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-2.25f, 0, +1.335f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-1.0f, 0, +3.5f);
                                                                break;
                                                        }
                                                    }
                                                    if (Pizza[iii, jjj].timespent == 1)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(0.5f, 0, +3.5f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(1.75f, 0, +1.335f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(3.0f, 0, +3.5f);
                                                                break;
                                                        }
                                                    }
                                                    if (Pizza[iii, jjj].timespent == 2)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+4.0f, 0, +0.5f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+2.75f, 0, -1.665f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(+1.5f, 0, +0.5f);
                                                                break;
                                                        }
                                                    }
                                                    if (Pizza[iii, jjj].timespent == 3)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(1.5f, 0, -3.5f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(0.25f, 0, -1.335f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-1.0f, 0, -3.5f);
                                                                break;
                                                        }
                                                    }
                                                    if (Pizza[iii, jjj].timespent == 4)
                                                    {
                                                        switch (jjj)
                                                        {
                                                            case 0:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-3.75f, 0, -1f);
                                                                break;
                                                            case 1:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-2.5f, 0, -3.165f);
                                                                break;
                                                            case 2:
                                                                Pizza[iii, jjj].Pirate.transform.Translate(-1.25f, 0, -1f);
                                                                break;
                                                        }
                                                    }
                                                    break;
                                                case 41:
                                                    switch (iii)
                                                    {
                                                        case 0:
                                                            switch (jjj)
                                                            {
                                                                case 0:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(0, 0, -3.3f);
                                                                    break;
                                                                case 1:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(0, 0, -1.2f);
                                                                    break;
                                                                case 2:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(0, 0, 0.9f);
                                                                    break;
                                                            }
                                                            break;
                                                        case 1:
                                                            switch (jjj)
                                                            {
                                                                case 0:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(-3.3f, 0, 0);
                                                                    break;
                                                                case 1:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(-1.2f, 0, 0);
                                                                    break;
                                                                case 2:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(0.9f, 0, 0);
                                                                    break;
                                                            }
                                                            break;
                                                        case 2:
                                                            switch (jjj)
                                                            {
                                                                case 0:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(0, 0, 3.3f);
                                                                    break;
                                                                case 1:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(0, 0, 1.2f);
                                                                    break;
                                                                case 2:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(0, 0, -0.9f);
                                                                    break;
                                                            }
                                                            break;
                                                        case 3:
                                                            switch (jjj)
                                                            {
                                                                case 0:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(3.3f, 0, 0);
                                                                    break;
                                                                case 1:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(1.2f, 0, 0);
                                                                    break;
                                                                case 2:
                                                                    Pizza[iii, jjj].Pirate.transform.Translate(-0.9f, 0, 0);
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;

                                                default:
                                                    switch (jjj)
                                                    {
                                                        case 0:
                                                            Pizza[iii, jjj].Pirate.transform.Translate(-3.5f, 0, -3.5f);
                                                            break;
                                                        case 1:
                                                            Pizza[iii, jjj].Pirate.transform.Translate(+3.5f, 0, -3.5f);
                                                            break;
                                                        case 2:
                                                            Pizza[iii, jjj].Pirate.transform.Translate(+3.5f, 0, +3.5f);
                                                            break;
                                                    }
                                                    break;

                                            }

                                            //Debug.Log("hm");
                                            // checking if he had a coin
                                            if (Pizza[iii, jjj].has_coin)
                                            {
                                               // Debug.Log($"ye{MovesQuan}");
                                                for (int asd = 0; asd < 37; asd++)
                                                {
                                                    if (Chest[asd].chosen)
                                                    {

                                                        Chest[asd].level = FieldField[ii, jj].RemainingCoins + 1;
                                                       // Debug.Log($"yep {Chest[asd].level}   {MovesQuan}  {FieldField[ii, jj].RemainingCoins}");
                                                        FieldField[Chest[asd].ci, Chest[asd].cj].RemainingCoins -= 1;
                                                        FieldField[ii, jj].RemainingCoins += 1;
                                                        Chest[asd].coin.transform.position =
                                                new Vector3(Lightn[ii, jj].transform.position.x, Chest[asd].level * 0.3f,
                                                Lightn[ii, jj].transform.position.z);
                                                        //Chest[asd].chosen = false;
                                                        //Chest[asd].coin.GetComponent<Renderer>().material
                                                        //= mat36;
                                                        

                                                        Chest[asd].ci = ii;
                                                        Chest[asd].cj = jj;
                                                        Chest[asd].cointimespent = Pizza[iii, jjj].timespent;

                                                        Chest[asd].startposx = Lightn[ii, jj].transform.position.x;
                                                        Chest[asd].startposz = Lightn[ii, jj].transform.position.z;
                                                        // Debug.Log($"yerp {Chest[asd].ci} {ii} {Chest[asd].cj} {jj}");
                                                        /*
                                                       Chest[asd].coin.transform.position =
                                               new Vector3(Lightn[ii, jj].transform.position.x, 0,
                                               Lightn[ii, jj].transform.position.z);
                                                       break;*/
                                                    }
                                                }
                                            }

                                            for (int gg = 0; gg < 37; gg++)
                                            {



                                                int ccii = Chest[gg].ci;
                                                int ccjj = Chest[gg].cj;


                                                if ((ccii == ii) && (ccjj == jj))
                                                {

                                                    if (Chest[gg].on_the_field == 1)
                                                    {
                                                        Chest[gg].coin.SetActive(true);
                                                    }
                                                }


                                                //to the ships or 
                                                //into the water



                                                if (CoinCondi[gg] == 0)
                                                {
                                                    if (ccjj == Pizza[0, 3].x)
                                                    {
                                                        Chest[gg].coin.SetActive(false);
                                                        Chest[gg].on_the_field = 0;
                                                        CoinCondi[gg] = 1;

                                                        if (ccii == Pizza[0, 3].z)
                                                        {
                                                            CoinsQuan[Mode][0] += 1;
                                                            Debug.Log('W');
                                                        }
                                                        //white
                                                    }

                                                    if (ccjj == Pizza[2, 3].x)
                                                    {
                                                        Chest[gg].coin.SetActive(false);
                                                        Chest[gg].on_the_field = 0;
                                                        CoinCondi[gg] = 1;

                                                        if (ccii == Pizza[2, 3].z)
                                                        {
                                                            CoinsQuan[Mode][1] += 1;
                                                            Debug.Log('B');
                                                        }
                                                        //black
                                                    }

                                                    if (ccii == Pizza[1, 3].z)
                                                    {
                                                        Chest[gg].coin.SetActive(false);
                                                        Chest[gg].on_the_field = 0;
                                                        CoinCondi[gg] = 1;
                                                        Debug.Log($"{gg} coin red  {ccii}");

                                                        if (ccjj == Pizza[1, 3].x)
                                                        {
                                                            CoinsQuan[Mode][2] += 1;
                                                            Debug.Log('R');
                                                        }
                                                        //red
                                                    }

                                                    if (ccii == Pizza[3, 3].z)
                                                    {
                                                        Chest[gg].coin.SetActive(false);
                                                        CoinCondi[gg] = 1;
                                                        Chest[gg].on_the_field = 0;

                                                        if (ccjj == Pizza[3, 3].x)
                                                        {
                                                            CoinsQuan[Mode][3] += 1;
                                                            Debug.Log('Y');
                                                        }
                                                        //yellow
                                                    }

                                                }
                                            }


                                            // if (!(jjj == 3 && FieldField[Pizza[iii, 3].z, Pizza[iii, 3].x].type != 41))

                                            //moving a Pirate to a new Field
                                            Pizza[iii, jjj].frsttime = true;



                                            Pizza[iii, jjj].move(jj, ii);

                                            FieldField[jj, ii].repeatedmoves++;
                                            if (FieldField[jj, ii].repeatedmoves == 8)
                                            {
                                                Pizza[iii, jjj].dead = true;
                                                Pizza[iii, jjj].Death();

                                            }
                                            if (FieldField[jj, ii].is_arrow == false)
                                            {
                                             //   Debug.Log(Pizza[iii, jjj].xbeg);
                                                Pizza[iii, jjj].lastmove(jj, ii);
                                            }

                                            Pizza[iii, jjj].untrapped = false;
                                            // Pizza[iii, jjj].drunk = false;
                                            for (int mm = 0; mm < 4; mm++)
                                            {
                                                if (Pizza[iii, jjj].z == Pizza[iii, mm].z && Pizza[iii, jjj].x == Pizza[iii, mm].x && jjj != mm)
                                                {
                                                    Pizza[iii, jjj].untrapped = true;
                                                    Pizza[iii, mm].untrapped = true;
                                                }
                                            }


                                            for (int kk = 0; kk < 4; kk++)
                                            {
                                                for (int kkk = 0; kkk < 4; kkk++)
                                                {

                                                    if (Pizza[iii, jjj].z == Pizza[kk, kkk].z && Pizza[iii, jjj].x == Pizza[kk, kkk].x && iii != kk && jjj != 3)
                                                    {

                                                        if (FieldField[Pizza[kk, kkk].z, Pizza[kk, kkk].x].type == 41)
                                                        {
                                                            if ((Pizza[kk, 3].z != Pizza[kk, kkk].z || Pizza[kk, 3].x != Pizza[kk, kkk].x) && kkk != 3)
                                                            {
                                                                if (can_die)
                                                                {
                                                                    Pizza[kk, kkk].dead = true;
                                                                    Pizza[kk, kkk].Death();
                                                                }
                                                            }
                                                            if (kkk == 3)
                                                            {
                                                                if (can_die)
                                                                {
                                                                    if (Mode == 1 || kk == 0 || kk == 2)
                                                                    {

                                                                        Pizza[iii, jjj].dead = true;
                                                                        Pizza[iii, jjj].Death();
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        else if (Pizza[iii, jjj].timespent == Pizza[kk, kkk].timespent)
                                                        {
                                                            Lightn[Pizza[kk, 3].z, Pizza[kk, 3].x].SetActive(true);
                                                            Pizza[kk, kkk].tapped = false;

                                                            Pizza[kk, kkk].Pirate.transform.position =
                                                       new Vector3(Lightn[Pizza[kk, 3].z, Pizza[kk, 3].x].transform.position.x, 0,
                                                       Lightn[Pizza[kk, 3].z, Pizza[kk, 3].x].transform.position.z);

                                                            Lightn[Pizza[kk, 3].z, Pizza[kk, 3].x].SetActive(false);

                                                            Pizza[kk, kkk].move(Pizza[kk, 3].x, Pizza[kk, 3].z);
                                                            Pizza[kk, kkk].trapped = false;
                                                            /*
                                                            Debug.Log("loh)");
                                                            switch (kkk)
                                                            {
                                                                case 0:
                                                                    Pizza[kk, kkk].Pirate.transform.Translate(-3.5f, 0, -3.5f);
                                                                    break;
                                                                case 1:
                                                                    Pizza[kk, kkk].Pirate.transform.Translate(+3.5f, 0, -3.5f);
                                                                    break;
                                                                case 2:
                                                                    Pizza[kk, kkk].Pirate.transform.Translate(+3.5f, 0, +3.5f);
                                                                    break;
                                                            }*/

                                                        }


                                                    }

                                                }
                                            }
                                            for (int asd=0;asd<37;asd++)
                                            {
                                                if (Chest[asd].chosen==true)
                                                {
                                                    if (Pizza[iii, jjj].dead == true)
                                                    {
                                                        Chest[asd].coin.transform.position = Chest[asd].CoinStartPosition;
                                                        Chest[asd].ci = Chest[asd].Startci;
                                                        Chest[asd].cj = Chest[asd].Startcj;
                                                    }
                                                    if (FieldField[ii, jj].is_arrow == false)
                                                    {
                                                        Chest[asd].CoinStartPosition = new Vector3(Chest[asd].startposx, Chest[asd].level * 0.3f,
                                            Chest[asd].startposz);

                                                        Chest[asd].Startci = ii;
                                                        Chest[asd].Startcj = jj;
                                                    }
                                                }
                                            }
                                            if ((FieldField[ii, jj].is_arrow == false) || Pizza[iii, jjj].dead == true)
                                            {
                                                for (int mm = 0; mm < 15; mm++)
                                                {
                                                    for (int mmm = 0; mmm < 15; mmm++)
                                                    {
                                                        FieldField[mm, mmm].repeatedmoves = 0;
                                                    }
                                                }
                                                // Pizza[iii, jjj].xbeg = Pizza[iii, jjj].x;
                                                // Pizza[iii, jjj].zbeg = Pizza[iii, jjj].z;
                                                Pizza[iii, jjj].tapped = false;


                                                MovesQuan++;
                                                for (int fgh = 0; fgh < 37; fgh++)
                                                {
                                                    Chest[fgh].chosen = false;
                                                    Chest[fgh].coin.GetComponent<Renderer>().material
                                                        = mat36;
                                                }

                                                for (int yu = 0; yu < 4; yu++)
                                                {
                                                    for (int ty = 0; ty < 3; ty++)
                                                    {
                                                        if (FieldField[Pizza[yu, ty].z, Pizza[yu, ty].x].is_arrow == false)
                                                        {
                                                            Pizza[yu, ty].has_coin = false;
                                                            switch (yu)
                                                            {
                                                                case 0:
                                                                    HandCoinWh.SetActive(false);
                                                                    break;
                                                                case 1:
                                                                    HandCoinRe.SetActive(false);
                                                                    break;
                                                                case 2:
                                                                    HandCoinBl.SetActive(false);
                                                                    break;
                                                                case 3:
                                                                    HandCoinYe.SetActive(false);
                                                                    break;
                                                            }
                                                        }
                                                    }
                                                }

                                            }

                                        }
                                    }
                                }
                            }

                        }

                    }

                }


                for (int ii = 0; ii < 37; ii++)
                {
                    if (hit.collider.name == Chest[ii].coin.name && FieldField[Chest[ii].ci, Chest[ii].cj].is_arrow == false)
                    {
                        Debug.Log(hit.collider.name);
                        if (Chest[ii].chosen)
                        {
                            Chest[ii].chosen = false;
                            Chest[ii].owner.has_coin = false;
                            Chest[ii].coin.GetComponent<Renderer>().material
                                = mat36;
                            /*
                            switch (Chest[ii].owner.team)
                            {
                                case 0:
                                    HandCoinWh.SetActive(false);
                                    break;
                                case 1:
                                    HandCoinRe.SetActive(false);
                                    break;
                                case 2:
                                    HandCoinBl.SetActive(false);
                                    break;
                                case 3:
                                    HandCoinYe.SetActive(false);
                                    break;
                            }*/
                        }
                        else
                        {
                            //choosing not looking at pirate

                            //.death
                            for (int sii = 0; sii < 4; sii++)
                            {
                                for (int sjj = 0; sjj < 3; sjj++)
                                {
                                    /* if (Pizza[sii, sjj].tapped&&((Coin1.ci==Pizza[sii, sjj].z&& Coin1.cj == Pizza[sii, sjj].x)|| (Coin2.ci == Pizza[sii, sjj].z && Coin2.cj == Pizza[sii, sjj].x) ||
                                         (Coin3.ci == Pizza[sii, sjj].z && Coin3.cj == Pizza[sii, sjj].x) || (Coin4.ci == Pizza[sii, sjj].z && Coin4.cj == Pizza[sii, sjj].x) ||
                                         (Coin5.ci == Pizza[sii, sjj].z && Coin5.cj == Pizza[sii, sjj].x) || (Coin6.ci == Pizza[sii, sjj].z && Coin6.cj == Pizza[sii, sjj].x) ||
                                         (Coin7.ci == Pizza[sii, sjj].z && Coin7.cj == Pizza[sii, sjj].x) || (Coin8.ci == Pizza[sii, sjj].z && Coin8.cj == Pizza[sii, sjj].x) ||
                                         (Coin9.ci == Pizza[sii, sjj].z && Coin9.cj == Pizza[sii, sjj].x) || (Coin10.ci == Pizza[sii, sjj].z && Coin10.cj == Pizza[sii, sjj].x) ||
                                         (Coin11.ci == Pizza[sii, sjj].z && Coin11.cj == Pizza[sii, sjj].x) || (Coin12.ci == Pizza[sii, sjj].z && Coin12.cj == Pizza[sii, sjj].x) ||
                                         (Coin13.ci == Pizza[sii, sjj].z && Coin13.cj == Pizza[sii, sjj].x) || (Coin14.ci == Pizza[sii, sjj].z && Coin14.cj == Pizza[sii, sjj].x) ||
                                         (Coin15.ci == Pizza[sii, sjj].z && Coin15.cj == Pizza[sii, sjj].x) || (Coin16.ci == Pizza[sii, sjj].z && Coin16.cj == Pizza[sii, sjj].x) ||
                                         (Coin17.ci == Pizza[sii, sjj].z && Coin17.cj == Pizza[sii, sjj].x) || (Coin18.ci == Pizza[sii, sjj].z && Coin18.cj == Pizza[sii, sjj].x) ||
                                         (Coin19.ci == Pizza[sii, sjj].z && Coin19.cj == Pizza[sii, sjj].x) || (Coin20.ci == Pizza[sii, sjj].z && Coin20.cj == Pizza[sii, sjj].x) ||
                                         (Coin21.ci == Pizza[sii, sjj].z && Coin21.cj == Pizza[sii, sjj].x) || (Coin22.ci == Pizza[sii, sjj].z && Coin22.cj == Pizza[sii, sjj].x) ||
                                         (Coin23.ci == Pizza[sii, sjj].z && Coin23.cj == Pizza[sii, sjj].x) || (Coin24.ci == Pizza[sii, sjj].z && Coin24.cj == Pizza[sii, sjj].x) ||
                                         (Coin25.ci == Pizza[sii, sjj].z && Coin25.cj == Pizza[sii, sjj].x) || (Coin26.ci == Pizza[sii, sjj].z && Coin26.cj == Pizza[sii, sjj].x) ||
                                         (Coin27.ci == Pizza[sii, sjj].z && Coin27.cj == Pizza[sii, sjj].x) || (Coin28.ci == Pizza[sii, sjj].z && Coin28.cj == Pizza[sii, sjj].x) ||
                                         (Coin29.ci == Pizza[sii, sjj].z && Coin29.cj == Pizza[sii, sjj].x) || (Coin30.ci == Pizza[sii, sjj].z && Coin30.cj == Pizza[sii, sjj].x) ||
                                         (Coin31.ci == Pizza[sii, sjj].z && Coin31.cj == Pizza[sii, sjj].x) || (Coin32.ci == Pizza[sii, sjj].z && Coin32.cj == Pizza[sii, sjj].x) ||
                                         (Coin33.ci == Pizza[sii, sjj].z && Coin33.cj == Pizza[sii, sjj].x) || (Coin34.ci == Pizza[sii, sjj].z && Coin34.cj == Pizza[sii, sjj].x) ||
                                         (Coin35.ci == Pizza[sii, sjj].z && Coin35.cj == Pizza[sii, sjj].x) || (Coin36.ci == Pizza[sii, sjj].z && Coin36.cj == Pizza[sii, sjj].x) ||
                                         (Coin37.ci == Pizza[sii, sjj].z && Coin37.cj == Pizza[sii, sjj].x)))*/
                                    if (Pizza[sii, sjj].tapped && Chest[ii].ci == Pizza[sii, sjj].z && Chest[ii].cj == Pizza[sii, sjj].x && Chest[ii].cointimespent == Pizza[sii, sjj].timespent)
                                    {
                                        Chest[ii].chosen = true;
                                        Chest[ii].coin.GetComponent<Renderer>().material
                                            = mat35;
                                        //
                                        for (int jj = 0; jj < 37; jj++)
                                        {
                                            if (jj != ii)
                                            {
                                                Chest[jj].chosen = false;

                                                Chest[jj].coin.GetComponent<Renderer>().material
                                            = mat36;
                                            }
                                        }
                                        Chest[ii].Chose(Pizza[sii, sjj]);
                                        Chest[ii].coin.GetComponent<Renderer>().material
                                             = mat35;
                                        Pizza[sii, sjj].has_coin = true;
                                        Debug.Log($"here, {MovesQuan}");
                                        Debug.Log("';lllllll')");
                                        switch (sii)
                                        {
                                            case 0:
                                                HandCoinWh.SetActive(true);
                                                break;
                                            case 1:
                                                HandCoinRe.SetActive(true);
                                                break;
                                            case 2:
                                                HandCoinBl.SetActive(true);
                                                break;
                                            case 3:
                                                HandCoinYe.SetActive(true);
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                        Debug.Log(Chest[ii].chosen);

                        if (Chest[ii].chosen == false)
                        {
                            HandCoinWh.SetActive(false);
                            HandCoinBl.SetActive(false);
                            HandCoinRe.SetActive(false);
                            HandCoinYe.SetActive(false);

                        }
                    }
                }
            }
        }

        m1 = CoinsQuan[0][0];
        m3 = CoinsQuan[1][0];
        m4 = CoinsQuan[1][1];
        m2 = CoinsQuan[0][1];
        m5 = CoinsQuan[1][2];
        m6 = CoinsQuan[1][3];
        m7 = CoinsQuan[2][0];
        m8 = CoinsQuan[2][1];
        m9 = CoinsQuan[2][2];
        m10 = CoinsQuan[2][3];
    }

    //RVPos Position;

    public RVPos CEmpty()
    {

        if (true)
        {
            Field1 = new CField(obj1);
            Field2 = new CField(obj2);
            Field3 = new CField(obj3);
            Field4 = new CField(obj4);
            Field5 = new CField(obj5);
            Field6 = new CField(obj6);
            Field7 = new CField(obj7);
            Field8 = new CField(obj8);
            Field9 = new CField(obj9);
            Field10 = new CField(obj10);
            Field11 = new CField(obj11);
            Field12 = new CField(obj12);
            Field13 = new CField(obj13);
            Field14 = new CField(obj14);
            Field15 = new CField(obj15);
            Field16 = new CField(obj16);
            Field17 = new CField(obj17);
            Field18 = new CField(obj18);
            Field19 = new CField(obj19);
            Field20 = new CField(obj20);
            Field21 = new CField(obj21);
            Field22 = new CField(obj22);
            Field23 = new CField(obj23);
            Field24 = new CField(obj24);
            Field25 = new CField(obj25);
            Field26 = new CField(obj26);
            Field27 = new CField(obj27);
            Field28 = new CField(obj28);
            Field29 = new CField(obj29);
            Field30 = new CField(obj30);
            Field31 = new CField(obj31);
            Field32 = new CField(obj32);
            Field33 = new CField(obj33);
            Field34 = new CField(obj34);
            Field35 = new CField(obj35);
            Field36 = new CField(obj36);
            Field37 = new CField(obj37);
            Field38 = new CField(obj38);
            Field39 = new CField(obj39);
            Field40 = new CField(obj40);
            Field41 = new CField(obj41);
            Field42 = new CField(obj42);
            Field43 = new CField(obj43);
            Field44 = new CField(obj44);
            Field45 = new CField(obj45);
            Field46 = new CField(obj46);
            Field47 = new CField(obj47);
            Field48 = new CField(obj48);
            Field49 = new CField(obj49);
            Field50 = new CField(obj50);
            Field51 = new CField(obj51);
            Field52 = new CField(obj52);
            Field53 = new CField(obj53);
            Field54 = new CField(obj54);
            Field55 = new CField(obj55);
            Field56 = new CField(obj56);
            Field57 = new CField(obj57);
            Field58 = new CField(obj58);
            Field59 = new CField(obj59);
            Field60 = new CField(obj60);
            Field61 = new CField(obj61);
            Field62 = new CField(obj62);
            Field63 = new CField(obj63);
            Field64 = new CField(obj64);
            Field65 = new CField(obj65);
            Field66 = new CField(obj66);
            Field67 = new CField(obj67);
            Field68 = new CField(obj68);
            Field69 = new CField(obj69);
            Field70 = new CField(obj70);
            Field71 = new CField(obj71);
            Field72 = new CField(obj72);
            Field73 = new CField(obj73);
            Field74 = new CField(obj74);
            Field75 = new CField(obj75);
            Field76 = new CField(obj76);
            Field77 = new CField(obj77);
            Field78 = new CField(obj78);
            Field79 = new CField(obj79);
            Field80 = new CField(obj80);
            Field81 = new CField(obj81);
            Field82 = new CField(obj82);
            Field83 = new CField(obj83);
            Field84 = new CField(obj84);
            Field85 = new CField(obj85);
            Field86 = new CField(obj86);
            Field87 = new CField(obj87);
            Field88 = new CField(obj88);
            Field89 = new CField(obj89);
            Field90 = new CField(obj90);
            Field91 = new CField(obj91);
            Field92 = new CField(obj92);
            Field93 = new CField(obj93);
            Field94 = new CField(obj94);
            Field95 = new CField(obj95);
            Field96 = new CField(obj96);
            Field97 = new CField(obj97);
            Field98 = new CField(obj98);
            Field99 = new CField(obj99);
            Field100 = new CField(obj100);
            Field101 = new CField(obj101);
            Field102 = new CField(obj102);
            Field103 = new CField(obj103);
            Field104 = new CField(obj104);
            Field105 = new CField(obj105);
            Field106 = new CField(obj106);
            Field107 = new CField(obj107);
            Field108 = new CField(obj108);
            Field109 = new CField(obj109);
            Field110 = new CField(obj110);
            Field111 = new CField(obj111);
            Field112 = new CField(obj112);
            Field113 = new CField(obj113);
            Field114 = new CField(obj114);
            Field115 = new CField(obj115);
            Field116 = new CField(obj116);
            Field117 = new CField(obj117);
            Field118 = new CField(obj118);
            Field119 = new CField(obj119);
            Field120 = new CField(obj120);
            Field121 = new CField(obj121);
            Field122 = new CField(obj122);
            Field123 = new CField(obj123);
            Field124 = new CField(obj124);
            Field125 = new CField(obj125);
            Field126 = new CField(obj126);
            Field127 = new CField(obj127);
            Field128 = new CField(obj128);
            Field129 = new CField(obj129);
            Field130 = new CField(obj130);
            Field131 = new CField(obj131);
            Field132 = new CField(obj132);
            Field133 = new CField(obj133);
            Field134 = new CField(obj134);
            Field135 = new CField(obj135);
            Field136 = new CField(obj136);
            Field137 = new CField(obj137);
            Field138 = new CField(obj138);
            Field139 = new CField(obj139);
            Field140 = new CField(obj140);
            Field141 = new CField(obj141);
            Field142 = new CField(obj142);
            Field143 = new CField(obj143);
            Field144 = new CField(obj144);
            Field145 = new CField(obj145);
            Field146 = new CField(obj146);
            Field147 = new CField(obj147);
            Field148 = new CField(obj148);
            Field149 = new CField(obj149);
            Field150 = new CField(obj150);
            Field151 = new CField(obj151);
            Field152 = new CField(obj152);
            Field153 = new CField(obj153);
            Field154 = new CField(obj154);
            Field155 = new CField(obj155);
            Field156 = new CField(obj156);
            Field157 = new CField(obj157);
            Field158 = new CField(obj158);
            Field159 = new CField(obj159);
            Field160 = new CField(obj160);
            Field161 = new CField(obj161);
            Field162 = new CField(obj162);
            Field163 = new CField(obj163);
            Field164 = new CField(obj164);
            Field165 = new CField(obj165);
            Field166 = new CField(obj166);
            Field167 = new CField(obj167);
            Field168 = new CField(obj168);
            Field169 = new CField(obj169);
            Field170 = new CField(obj170);
            Field171 = new CField(obj171);
            Field172 = new CField(obj172);
            Field173 = new CField(obj173);
            Field174 = new CField(obj174);
            Field175 = new CField(obj175);
            Field176 = new CField(obj176);
            Field177 = new CField(obj177);
            Field178 = new CField(obj178);
            Field179 = new CField(obj179);
            Field180 = new CField(obj180);
            Field181 = new CField(obj181);
            Field182 = new CField(obj182);
            Field183 = new CField(obj183);
            Field184 = new CField(obj184);
            Field185 = new CField(obj185);
            Field186 = new CField(obj186);
            Field187 = new CField(obj187);
            Field188 = new CField(obj188);
            Field189 = new CField(obj189);
            Field190 = new CField(obj190);
            Field191 = new CField(obj191);
            Field192 = new CField(obj192);
            Field193 = new CField(obj193);
            Field194 = new CField(obj194);
            Field195 = new CField(obj195);
            Field196 = new CField(obj196);
            Field197 = new CField(obj197);
            Field198 = new CField(obj198);
            Field199 = new CField(obj199);
            Field200 = new CField(obj200);
            Field201 = new CField(obj201);
            Field202 = new CField(obj202);
            Field203 = new CField(obj203);
            Field204 = new CField(obj204);
            Field205 = new CField(obj205);
            Field206 = new CField(obj206);
            Field207 = new CField(obj207);
            Field208 = new CField(obj208);
            Field209 = new CField(obj209);
            Field210 = new CField(obj210);
            Field211 = new CField(obj211);
            Field212 = new CField(obj212);
            Field213 = new CField(obj213);
            Field214 = new CField(obj214);
            Field215 = new CField(obj215);
            Field216 = new CField(obj216);
            Field217 = new CField(obj217);
            Field218 = new CField(obj218);
            Field219 = new CField(obj219);
            Field220 = new CField(obj220);
            Field221 = new CField(obj221);
            Field222 = new CField(obj222);
            Field223 = new CField(obj223);
            Field224 = new CField(obj224);
            Field225 = new CField(obj225);


            Pie1 = new CPirate(1, 7, 0, Obj90);
            Pie2 = new CPirate(1, 7, 0, Obj91);
            Pie3 = new CPirate(1, 7, 0, Obj92);
            Pie4 = new CPirate(13, 7, 1, Obj94);
            Pie5 = new CPirate(13, 7, 1, Obj95);
            Pie6 = new CPirate(13, 7, 1, Obj96);
            Pie7 = new CPirate(7, 1, 2, Obj98);
            Pie8 = new CPirate(7, 1, 2, Obj99);
            Pie9 = new CPirate(7, 1, 2, Obj100);
            Pie10 = new CPirate(7, 13, 3, Obj102);
            Pie11 = new CPirate(7, 13, 3, Obj103);
            Pie12 = new CPirate(7, 13, 3, Obj104);
            ShipWhi = new CPirate(1, 7, 0, Obj93);
            ShipBla = new CPirate(13, 7, 1, Obj97);
            ShipYel = new CPirate(7, 13, 3, Obj105);
            ShipRed = new CPirate(7, 1, 2, Obj101);


            //Coin object

            Coin1 = new CCoin(Coi1, 0);
            Coin2 = new CCoin(Coi2, 0);
            Coin3 = new CCoin(Coi3, 0);
            Coin4 = new CCoin(Coi4, 0);
            Coin5 = new CCoin(Coi5, 0);
            Coin6 = new CCoin(Coi6, 0);
            Coin7 = new CCoin(Coi7, 0);
            Coin8 = new CCoin(Coi8, 0);
            Coin9 = new CCoin(Coi9, 0);
            Coin10 = new CCoin(Coi10, 0);
            Coin11 = new CCoin(Coi11, 0);
            Coin12 = new CCoin(Coi12, 0);
            Coin13 = new CCoin(Coi13, 0);
            Coin14 = new CCoin(Coi14, 0);
            Coin15 = new CCoin(Coi15, 0);
            Coin16 = new CCoin(Coi16, 0);
            Coin17 = new CCoin(Coi17, 0);
            Coin18 = new CCoin(Coi18, 0);
            Coin19 = new CCoin(Coi19, 0);
            Coin20 = new CCoin(Coi20, 0);
            Coin21 = new CCoin(Coi21, 0);
            Coin22 = new CCoin(Coi22, 0);
            Coin23 = new CCoin(Coi23, 0);
            Coin24 = new CCoin(Coi24, 0);
            Coin25 = new CCoin(Coi25, 0);
            Coin26 = new CCoin(Coi26, 0);
            Coin27 = new CCoin(Coi27, 0);
            Coin28 = new CCoin(Coi28, 0);
            Coin29 = new CCoin(Coi29, 0);
            Coin30 = new CCoin(Coi30, 0);
            Coin31 = new CCoin(Coi31, 0);
            Coin32 = new CCoin(Coi32, 0);
            Coin33 = new CCoin(Coi33, 0);
            Coin34 = new CCoin(Coi34, 0);
            Coin35 = new CCoin(Coi35, 0);
            Coin36 = new CCoin(Coi36, 0);
            Coin37 = new CCoin(Coi37, 0);
        }
        //massive of coins

        Chest = new CCoin[37] {Coin1, Coin2, Coin3, Coin4,
                Coin5, Coin6, Coin7, Coin8,
                Coin9, Coin10, Coin11, Coin12,
                Coin13, Coin14, Coin15, Coin16,
                Coin17, Coin18, Coin19, Coin20,
                Coin21, Coin22, Coin23, Coin24,
                Coin25, Coin26, Coin27, Coin28,
                Coin29, Coin30, Coin31, Coin32,
                Coin33, Coin34, Coin35, Coin36,
                Coin37};

        //massive of pirates and their own ships

        Pizza = new CPirate[4, 4] { { Pie1,Pie2,Pie3, ShipWhi },
            {Pie7,Pie8,Pie9, ShipRed },
            {Pie4,Pie5,Pie6, ShipBla },
            {Pie10,Pie11,Pie12, ShipYel }};


        for (int qqq = 0; qqq < 4; qqq++)
        {
            Pizza[qqq, 3].is_ship = true;
        }


        /*CoinsQuan = new int[3, 4] { { 0, 0, -1, -1},
                                    { 0, 0, 0, 0 },
                                    { 0, 0, 0, 0 } };*/
        CoinsQuan = new int[3][];
        CoinsQuan[0] = new int[2] { 0, 0 };
        CoinsQuan[1] = new int[4] { 0, 0, 0, 0 };
        CoinsQuan[2] = new int[4] { 0, 0, 0, 0 };


        CoinCondi = new int[37] { 0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0, 0, 0, 0,
                                      0, 0};



        int k;
        System.Random rand = new System.Random();
        CField[,] FieldField = new CField[15, 15] {{Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10, Field11, Field12, Field13, Field14, Field15 },
                                                    { Field16, Field17, Field18, Field19, Field20, Field21, Field22, Field23, Field24, Field25, Field26, Field27, Field28, Field29, Field30 },
                                                    { Field31, Field32, Field33, Field34, Field35, Field36, Field37, Field38, Field39, Field40, Field41, Field42, Field43, Field44, Field45 },
                                                    { Field46, Field47, Field48, Field49, Field50, Field51, Field52, Field53, Field54, Field55, Field56, Field57, Field58, Field59, Field60 },
                                                    { Field61, Field62, Field63, Field64, Field65, Field66, Field67, Field68, Field69, Field70, Field71, Field72, Field73, Field74, Field75 },
                                                    { Field76, Field77, Field78, Field79, Field80, Field81, Field82, Field83, Field84, Field85, Field86, Field87, Field88, Field89, Field90 },
                                                    { Field91, Field92, Field93, Field94, Field95, Field96, Field97, Field98, Field99, Field100, Field101, Field102, Field103, Field104, Field105 },
                                                    { Field106, Field107, Field108, Field109, Field110, Field111, Field112, Field113, Field114, Field115, Field116, Field117, Field118, Field119, Field120 },
                                                    { Field121, Field122, Field123, Field124, Field125, Field126, Field127, Field128, Field129, Field130, Field131, Field132, Field133, Field134, Field135 },
                                                    { Field136, Field137, Field138, Field139, Field140, Field141, Field142, Field143, Field144, Field145, Field146, Field147, Field148, Field149, Field150 },
                                                    { Field151, Field152, Field153, Field154, Field155, Field156, Field157, Field158, Field159, Field160, Field161, Field162, Field163, Field164, Field165 },
                                                    { Field166, Field167, Field168, Field169, Field170, Field171, Field172, Field173, Field174, Field175, Field176, Field177, Field178, Field179, Field180 },
                                                    { Field181, Field182, Field183, Field184, Field185, Field186, Field187, Field188, Field189, Field190, Field191, Field192, Field193, Field194, Field195 },
                                                    { Field196, Field197, Field198, Field199, Field200, Field201, Field202, Field203, Field204, Field205, Field206, Field207, Field208, Field209, Field210 },
                                                    { Field211, Field212, Field213, Field214, Field215, Field216, Field217, Field218, Field219, Field220, Field221, Field222, Field223, Field224, Field225 } };

        Beginning func = new Beginning();
        field = new int[15, 15];
        field = func.RecreatingUP();
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                FieldField[i, j].first = true;
                FieldField[i, j].type = field[i, j];


                if ((field[i, j] == 6) | (field[i, j] == 7) | (field[i, j] == 8) |
                    (field[i, j] == 9) | (field[i, j] == 10) | (field[i, j] == 21))
                {
                    k = rand.Next(4);

                    FieldField[i, j].orintation = k;

                }
                FieldField[i, j].open1();

                //Debug.Log($"{FieldField[i, j].obj.name}   {FieldField[i, j].coins}");

                Vobla = FieldField[i, j].coins;
                while (Vobla != 0)
                {
                    Arseniy %= 37;
                    Chest[Arseniy].ci = i;
                    Chest[Arseniy].cj = j;
                    Chest[Arseniy].level = (Vobla - 1);

                    Arseniy++;
                    Vobla--;
                }

            }
        }


        Position = new RVPos();
        Position.Create(FieldField, Pizza, Chest, 0, CoinsQuan, CoinCondi);


        return Position;
    }

}
