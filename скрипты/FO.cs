using UnityEngine;
using System.Threading;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using System.Collections.Specialized;

public class FO : MonoBehaviourPunCallbacks
{
    public MasterServer MS;
    public PUN pun;
    public bool JOR = false;
    public int win_menu = 0;

    public bool whiteeliminated = false;
    public bool blackeliminated = false;
    public bool redeliminated = false;
    public bool yelloweliminated = false;
    public int trophy = 0;
    public int money = 0;
    public int win1 = 0;
    public int win2 = 0;
    public int n_win = 0;
    public string name = "Name";
    public int musss;
    public int souuu;
    public int lannn;

    public bool blok = false;
    public bool blok2 = false;
    public bool blok3 = false;
    public bool save = false;
    public bool obzor = false;
    public int l = 1; //true- not the first enter    false- first enter

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

    public float t = 0.0f;
    public bool planeisused = false;
    public bool ArseniyIsALazyDumbStubbornBitch = true;
    public bool allwhitedied = false;
    public bool allreddied = false;
    public bool allblackdied = false;
    public bool allyellowdied = false;
    public int MovesQuan;
    public GameObject[,] Lightn;
    public const int Mode = 0;
    public int[][] CoinsQuan;
    public int[] CoinCondi;
    public int Vobla;
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

    public int Arseniy = 0;

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
    public bool iz2 = true;

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



    //public FormU FormUu;
    public AudioSource audios;
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
    public float q1 = 0f;
    public float q2 = 0f;
    public float q3 = 0f;
    public float q4 = 0f;

    float xx = 0f;
    float yy = 0f;
    float zz = 0f;
    float yyy = 0f;

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
    public bool a = false;
    public bool z = true;
    int r = 0;
    // public bool[] t = new bool[10];
    int n = 7;

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


    bool z0 = true;

    public float thickth = 0.3f;

    public bool Indic = false;

    public int[,] field;



    private PhotonView photonView;
    public GameObject pir_w;
    public GameObject pir_b;
    public GameObject boat_w;
    public GameObject boat_b;
    public GameObject pir_y;
    public GameObject pir_r;
    public GameObject boat_y;
    public GameObject boat_r;
    public GameObject pir_w_1;
    public GameObject pir_w_2;
    public GameObject pir_w_3;
    public GameObject boat_w_1;
    public GameObject pir_b_1;
    public GameObject pir_b_2;
    public GameObject pir_b_3;
    public GameObject boat_b_1;
    public GameObject pir_y_1;
    public GameObject pir_y_2;
    public GameObject pir_y_3;
    public GameObject boat_y_1;
    public GameObject pir_r_1;
    public GameObject pir_r_2;
    public GameObject pir_r_3;
    public GameObject boat_r_1;
    public GameObject down_p;
    public GameObject light_p;
    private const string roomName = "RoomName";
    private RoomInfo[] roomsList;
    private bool IsSpawning = false;
    private bool costumProp = false;
    public string NickName;
    //public PUN pun;
    private string RoomName = " ";
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
        NickName = PhotonNetwork.NickName;
        print(NickName);
    }
    public void PoP()// когда подключились
    {

        Debug.Log("OnJoinedRoom" + NickName);
        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
            bool down = true;
            if (down)
            {
                obj1 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, 15f), Quaternion.identity);
                obj2 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, 15f), Quaternion.identity);
                obj3 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, 15f), Quaternion.identity);
                obj4 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, 15f), Quaternion.identity);
                obj5 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, 15f), Quaternion.identity);
                obj6 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, 15f), Quaternion.identity);
                obj7 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, 15f), Quaternion.identity);
                obj8 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, 15f), Quaternion.identity);
                obj9 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, 15f), Quaternion.identity);
                obj10 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, 15f), Quaternion.identity);
                obj11 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, 15f), Quaternion.identity);
                obj12 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, 15f), Quaternion.identity);
                obj13 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, 15f), Quaternion.identity);
                obj14 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, 15f), Quaternion.identity);
                obj15 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, 15f), Quaternion.identity);
                obj16 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, 5f), Quaternion.identity);
                obj17 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, 5f), Quaternion.identity);
                obj18 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, 5f), Quaternion.identity);
                obj19 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, 5f), Quaternion.identity);
                obj20 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, 5f), Quaternion.identity);
                obj21 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, 5f), Quaternion.identity);
                obj22 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, 5f), Quaternion.identity);
                obj23 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, 5f), Quaternion.identity);
                obj24 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, 5f), Quaternion.identity);
                obj25 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, 5f), Quaternion.identity);
                obj26 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, 5f), Quaternion.identity);
                obj27 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, 5f), Quaternion.identity);
                obj28 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, 5f), Quaternion.identity);
                obj29 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, 5f), Quaternion.identity);
                obj30 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, 5f), Quaternion.identity);
                obj31 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -5f), Quaternion.identity);
                obj32 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -5f), Quaternion.identity);
                obj33 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -5f), Quaternion.identity);
                obj34 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -5f), Quaternion.identity);
                obj35 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -5f), Quaternion.identity);
                obj36 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -5f), Quaternion.identity);
                obj37 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -5f), Quaternion.identity);
                obj38 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -5f), Quaternion.identity);
                obj39 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -5f), Quaternion.identity);
                obj40 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -5f), Quaternion.identity);
                obj41 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -5f), Quaternion.identity);
                obj42 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -5f), Quaternion.identity);
                obj43 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -5f), Quaternion.identity);
                obj44 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -5f), Quaternion.identity);
                obj45 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -5f), Quaternion.identity);
                obj46 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -15f), Quaternion.identity);
                obj47 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -15f), Quaternion.identity);
                obj48 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -15f), Quaternion.identity);
                obj49 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -15f), Quaternion.identity);
                obj50 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -15f), Quaternion.identity);
                obj51 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -15f), Quaternion.identity);
                obj52 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -15f), Quaternion.identity);
                obj53 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -15f), Quaternion.identity);
                obj54 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -15f), Quaternion.identity);
                obj55 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -15f), Quaternion.identity);
                obj56 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -15f), Quaternion.identity);
                obj57 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -15f), Quaternion.identity);
                obj58 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -15f), Quaternion.identity);
                obj59 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -15f), Quaternion.identity);
                obj60 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -15f), Quaternion.identity);
                obj61 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -25f), Quaternion.identity);
                obj62 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -25f), Quaternion.identity);
                obj63 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -25f), Quaternion.identity);
                obj64 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -25f), Quaternion.identity);
                obj65 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -25f), Quaternion.identity);
                obj66 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -25f), Quaternion.identity);
                obj67 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -25f), Quaternion.identity);
                obj68 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -25f), Quaternion.identity);
                obj69 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -25f), Quaternion.identity);
                obj70 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -25f), Quaternion.identity);
                obj71 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -25f), Quaternion.identity);
                obj72 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -25f), Quaternion.identity);
                obj73 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -25f), Quaternion.identity);
                obj74 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -25f), Quaternion.identity);
                obj75 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -25f), Quaternion.identity);
                obj76 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -35f), Quaternion.identity);
                obj77 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -35f), Quaternion.identity);
                obj78 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -35f), Quaternion.identity);
                obj79 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -35f), Quaternion.identity);
                obj80 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -35f), Quaternion.identity);
                obj81 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -35f), Quaternion.identity);
                obj82 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -35f), Quaternion.identity);
                obj83 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -35f), Quaternion.identity);
                obj84 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -35f), Quaternion.identity);
                obj85 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -35f), Quaternion.identity);
                obj86 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -35f), Quaternion.identity);
                obj87 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -35f), Quaternion.identity);
                obj88 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -35f), Quaternion.identity);
                obj89 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -35f), Quaternion.identity);
                obj90 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -35f), Quaternion.identity);
                obj91 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -45f), Quaternion.identity);
                obj92 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -45f), Quaternion.identity);
                obj93 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -45f), Quaternion.identity);
                obj94 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -45f), Quaternion.identity);
                obj95 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -45f), Quaternion.identity);
                obj96 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -45f), Quaternion.identity);
                obj97 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -45f), Quaternion.identity);
                obj98 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -45f), Quaternion.identity);
                obj99 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -45f), Quaternion.identity);
                obj100 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -45f), Quaternion.identity);
                obj101 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -45f), Quaternion.identity);
                obj102 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -45f), Quaternion.identity);
                obj103 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -45f), Quaternion.identity);
                obj104 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -45f), Quaternion.identity);
                obj105 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -45f), Quaternion.identity);
                obj106 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -55f), Quaternion.identity);
                obj107 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -55f), Quaternion.identity);
                obj108 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -55f), Quaternion.identity);
                obj109 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -55f), Quaternion.identity);
                obj110 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -55f), Quaternion.identity);
                obj111 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -55f), Quaternion.identity);
                obj112 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -55f), Quaternion.identity);
                obj113 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -55f), Quaternion.identity);
                obj114 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -55f), Quaternion.identity);
                obj115 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -55f), Quaternion.identity);
                obj116 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -55f), Quaternion.identity);
                obj117 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -55f), Quaternion.identity);
                obj118 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -55f), Quaternion.identity);
                obj119 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -55f), Quaternion.identity);
                obj120 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -55f), Quaternion.identity);
                obj121 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -65f), Quaternion.identity);
                obj122 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -65f), Quaternion.identity);
                obj123 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -65f), Quaternion.identity);
                obj124 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -65f), Quaternion.identity);
                obj125 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -65f), Quaternion.identity);
                obj126 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -65f), Quaternion.identity);
                obj127 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -65f), Quaternion.identity);
                obj128 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -65f), Quaternion.identity);
                obj129 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -65f), Quaternion.identity);
                obj130 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -65f), Quaternion.identity);
                obj131 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -65f), Quaternion.identity);
                obj132 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -65f), Quaternion.identity);
                obj133 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -65f), Quaternion.identity);
                obj134 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -65f), Quaternion.identity);
                obj135 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -65f), Quaternion.identity);
                obj136 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -75f), Quaternion.identity);
                obj137 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -75f), Quaternion.identity);
                obj138 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -75f), Quaternion.identity);
                obj139 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -75f), Quaternion.identity);
                obj140 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -75f), Quaternion.identity);
                obj141 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -75f), Quaternion.identity);
                obj142 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -75f), Quaternion.identity);
                obj143 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -75f), Quaternion.identity);
                obj144 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -75f), Quaternion.identity);
                obj145 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -75f), Quaternion.identity);
                obj146 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -75f), Quaternion.identity);
                obj147 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -75f), Quaternion.identity);
                obj148 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -75f), Quaternion.identity);
                obj149 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -75f), Quaternion.identity);
                obj150 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -75f), Quaternion.identity);
                obj151 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -85f), Quaternion.identity);
                obj152 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -85f), Quaternion.identity);
                obj153 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -85f), Quaternion.identity);
                obj154 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -85f), Quaternion.identity);
                obj155 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -85f), Quaternion.identity);
                obj156 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -85f), Quaternion.identity);
                obj157 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -85f), Quaternion.identity);
                obj158 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -85f), Quaternion.identity);
                obj159 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -85f), Quaternion.identity);
                obj160 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -85f), Quaternion.identity);
                obj161 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -85f), Quaternion.identity);
                obj162 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -85f), Quaternion.identity);
                obj163 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -85f), Quaternion.identity);
                obj164 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -85f), Quaternion.identity);
                obj165 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -85f), Quaternion.identity);
                obj166 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -95f), Quaternion.identity);
                obj167 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -95f), Quaternion.identity);
                obj168 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -95f), Quaternion.identity);
                obj169 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -95f), Quaternion.identity);
                obj170 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -95f), Quaternion.identity);
                obj171 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -95f), Quaternion.identity);
                obj172 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -95f), Quaternion.identity);
                obj173 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -95f), Quaternion.identity);
                obj174 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -95f), Quaternion.identity);
                obj175 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -95f), Quaternion.identity);
                obj176 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -95f), Quaternion.identity);
                obj177 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -95f), Quaternion.identity);
                obj178 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -95f), Quaternion.identity);
                obj179 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -95f), Quaternion.identity);
                obj180 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -95f), Quaternion.identity);
                obj181 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -105f), Quaternion.identity);
                obj182 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -105f), Quaternion.identity);
                obj183 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -105f), Quaternion.identity);
                obj184 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -105f), Quaternion.identity);
                obj185 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -105f), Quaternion.identity);
                obj186 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -105f), Quaternion.identity);
                obj187 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -105f), Quaternion.identity);
                obj188 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -105f), Quaternion.identity);
                obj189 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -105f), Quaternion.identity);
                obj190 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -105f), Quaternion.identity);
                obj191 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -105f), Quaternion.identity);
                obj192 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -105f), Quaternion.identity);
                obj193 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -105f), Quaternion.identity);
                obj194 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -105f), Quaternion.identity);
                obj195 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -105f), Quaternion.identity);
                obj196 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -115f), Quaternion.identity);
                obj197 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -115f), Quaternion.identity);
                obj198 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -115f), Quaternion.identity);
                obj199 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -115f), Quaternion.identity);
                obj200 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -115f), Quaternion.identity);
                obj201 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -115f), Quaternion.identity);
                obj202 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -115f), Quaternion.identity);
                obj203 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -115f), Quaternion.identity);
                obj204 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -115f), Quaternion.identity);
                obj205 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -115f), Quaternion.identity);
                obj206 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -115f), Quaternion.identity);
                obj207 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -115f), Quaternion.identity);
                obj208 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -115f), Quaternion.identity);
                obj209 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -115f), Quaternion.identity);
                obj210 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -115f), Quaternion.identity);
                obj211 = PhotonNetwork.Instantiate(down_p.name, new Vector3(-5f, 0.1f, -125f), Quaternion.identity);
                obj212 = PhotonNetwork.Instantiate(down_p.name, new Vector3(5f, 0.1f, -125f), Quaternion.identity);
                obj213 = PhotonNetwork.Instantiate(down_p.name, new Vector3(15f, 0.1f, -125f), Quaternion.identity);
                obj214 = PhotonNetwork.Instantiate(down_p.name, new Vector3(25f, 0.1f, -125f), Quaternion.identity);
                obj215 = PhotonNetwork.Instantiate(down_p.name, new Vector3(35f, 0.1f, -125f), Quaternion.identity);
                obj216 = PhotonNetwork.Instantiate(down_p.name, new Vector3(45f, 0.1f, -125f), Quaternion.identity);
                obj217 = PhotonNetwork.Instantiate(down_p.name, new Vector3(55f, 0.1f, -125f), Quaternion.identity);
                obj218 = PhotonNetwork.Instantiate(down_p.name, new Vector3(65f, 0.1f, -125f), Quaternion.identity);
                obj219 = PhotonNetwork.Instantiate(down_p.name, new Vector3(75f, 0.1f, -125f), Quaternion.identity);
                obj220 = PhotonNetwork.Instantiate(down_p.name, new Vector3(85f, 0.1f, -125f), Quaternion.identity);
                obj221 = PhotonNetwork.Instantiate(down_p.name, new Vector3(95f, 0.1f, -125f), Quaternion.identity);
                obj222 = PhotonNetwork.Instantiate(down_p.name, new Vector3(105f, 0.1f, -125f), Quaternion.identity);
                obj223 = PhotonNetwork.Instantiate(down_p.name, new Vector3(115f, 0.1f, -125f), Quaternion.identity);
                obj224 = PhotonNetwork.Instantiate(down_p.name, new Vector3(125f, 0.1f, -125f), Quaternion.identity);
                obj225 = PhotonNetwork.Instantiate(down_p.name, new Vector3(135f, 0.1f, -125f), Quaternion.identity);

                obj1.name = "down(1)";
                obj2.name = "down(2)";
                obj3.name = "down(3)";
                obj4.name = "down(4)";
                obj5.name = "down(5)";
                obj6.name = "down(6)";
                obj7.name = "down(7)";
                obj8.name = "down(8)";
                obj9.name = "down(9)";
                obj10.name = "down(10)";
                obj11.name = "down(11)";
                obj12.name = "down(12)";
                obj13.name = "down(13)";
                obj14.name = "down(14)";
                obj15.name = "down(15)";
                obj16.name = "down(16)";
                obj17.name = "down(17)";
                obj18.name = "down(18)";
                obj19.name = "down(19)";
                obj20.name = "down(20)";
                obj21.name = "down(21)";
                obj22.name = "down(22)";
                obj23.name = "down(23)";
                obj24.name = "down(24)";
                obj25.name = "down(25)";
                obj26.name = "down(26)";
                obj27.name = "down(27)";
                obj28.name = "down(28)";
                obj29.name = "down(29)";
                obj30.name = "down(30)";
                obj31.name = "down(31)";
                obj32.name = "down(32)";
                obj33.name = "down(33)";
                obj34.name = "down(34)";
                obj35.name = "down(35)";
                obj36.name = "down(36)";
                obj37.name = "down(37)";
                obj38.name = "down(38)";
                obj39.name = "down(39)";
                obj40.name = "down(40)";
                obj41.name = "down(41)";
                obj42.name = "down(42)";
                obj43.name = "down(43)";
                obj44.name = "down(44)";
                obj45.name = "down(45)";
                obj46.name = "down(46)";
                obj47.name = "down(47)";
                obj48.name = "down(48)";
                obj49.name = "down(49)";
                obj50.name = "down(50)";
                obj51.name = "down(51)";
                obj52.name = "down(52)";
                obj53.name = "down(53)";
                obj54.name = "down(54)";
                obj55.name = "down(55)";
                obj56.name = "down(56)";
                obj57.name = "down(57)";
                obj58.name = "down(58)";
                obj59.name = "down(59)";
                obj60.name = "down(60)";
                obj61.name = "down(61)";
                obj62.name = "down(62)";
                obj63.name = "down(63)";
                obj64.name = "down(64)";
                obj65.name = "down(65)";
                obj66.name = "down(66)";
                obj67.name = "down(67)";
                obj68.name = "down(68)";
                obj69.name = "down(69)";
                obj70.name = "down(70)";
                obj71.name = "down(71)";
                obj72.name = "down(72)";
                obj73.name = "down(73)";
                obj74.name = "down(74)";
                obj75.name = "down(75)";
                obj76.name = "down(76)";
                obj77.name = "down(77)";
                obj78.name = "down(78)";
                obj79.name = "down(79)";
                obj80.name = "down(80)";
                obj81.name = "down(81)";
                obj82.name = "down(82)";
                obj83.name = "down(83)";
                obj84.name = "down(84)";
                obj85.name = "down(85)";
                obj86.name = "down(86)";
                obj87.name = "down(87)";
                obj88.name = "down(88)";
                obj89.name = "down(89)";
                obj90.name = "down(90)";
                obj91.name = "down(91)";
                obj92.name = "down(92)";
                obj93.name = "down(93)";
                obj94.name = "down(94)";
                obj95.name = "down(95)";
                obj96.name = "down(96)";
                obj97.name = "down(97)";
                obj98.name = "down(98)";
                obj99.name = "down(99)";
                obj100.name = "down(100)";
                obj101.name = "down(101)";
                obj102.name = "down(102)";
                obj103.name = "down(103)";
                obj104.name = "down(104)";
                obj105.name = "down(105)";
                obj106.name = "down(106)";
                obj107.name = "down(107)";
                obj108.name = "down(108)";
                obj109.name = "down(109)";
                obj110.name = "down(110)";
                obj111.name = "down(111)";
                obj112.name = "down(112)";
                obj113.name = "down(113)";
                obj114.name = "down(114)";
                obj115.name = "down(115)";
                obj116.name = "down(116)";
                obj117.name = "down(117)";
                obj118.name = "down(118)";
                obj119.name = "down(119)";
                obj120.name = "down(120)";
                obj121.name = "down(121)";
                obj122.name = "down(122)";
                obj123.name = "down(123)";
                obj124.name = "down(124)";
                obj125.name = "down(125)";
                obj126.name = "down(126)";
                obj127.name = "down(127)";
                obj128.name = "down(128)";
                obj129.name = "down(129)";
                obj130.name = "down(130)";
                obj131.name = "down(131)";
                obj132.name = "down(132)";
                obj133.name = "down(133)";
                obj134.name = "down(134)";
                obj135.name = "down(135)";
                obj136.name = "down(136)";
                obj137.name = "down(137)";
                obj138.name = "down(138)";
                obj139.name = "down(139)";
                obj140.name = "down(140)";
                obj141.name = "down(141)";
                obj142.name = "down(142)";
                obj143.name = "down(143)";
                obj144.name = "down(144)";
                obj145.name = "down(145)";
                obj146.name = "down(146)";
                obj147.name = "down(147)";
                obj148.name = "down(148)";
                obj149.name = "down(149)";
                obj150.name = "down(150)";
                obj151.name = "down(151)";
                obj152.name = "down(152)";
                obj153.name = "down(153)";
                obj154.name = "down(154)";
                obj155.name = "down(155)";
                obj156.name = "down(156)";
                obj157.name = "down(157)";
                obj158.name = "down(158)";
                obj159.name = "down(159)";
                obj160.name = "down(160)";
                obj161.name = "down(161)";
                obj162.name = "down(162)";
                obj163.name = "down(163)";
                obj164.name = "down(164)";
                obj165.name = "down(165)";
                obj166.name = "down(166)";
                obj167.name = "down(167)";
                obj168.name = "down(168)";
                obj169.name = "down(169)";
                obj170.name = "down(170)";
                obj171.name = "down(171)";
                obj172.name = "down(172)";
                obj173.name = "down(173)";
                obj174.name = "down(174)";
                obj175.name = "down(175)";
                obj176.name = "down(176)";
                obj177.name = "down(177)";
                obj178.name = "down(178)";
                obj179.name = "down(179)";
                obj180.name = "down(180)";
                obj181.name = "down(181)";
                obj182.name = "down(182)";
                obj183.name = "down(183)";
                obj184.name = "down(184)";
                obj185.name = "down(185)";
                obj186.name = "down(186)";
                obj187.name = "down(187)";
                obj188.name = "down(188)";
                obj189.name = "down(189)";
                obj190.name = "down(190)";
                obj191.name = "down(191)";
                obj192.name = "down(192)";
                obj193.name = "down(193)";
                obj194.name = "down(194)";
                obj195.name = "down(195)";
                obj196.name = "down(196)";
                obj197.name = "down(197)";
                obj198.name = "down(198)";
                obj199.name = "down(199)";
                obj200.name = "down(200)";
                obj201.name = "down(201)";
                obj202.name = "down(202)";
                obj203.name = "down(203)";
                obj204.name = "down(204)";
                obj205.name = "down(205)";
                obj206.name = "down(206)";
                obj207.name = "down(207)";
                obj208.name = "down(208)";
                obj209.name = "down(209)";
                obj210.name = "down(210)";
                obj211.name = "down(211)";
                obj212.name = "down(212)";
                obj213.name = "down(213)";
                obj214.name = "down(214)";
                obj215.name = "down(215)";
                obj216.name = "down(216)";
                obj217.name = "down(217)";
                obj218.name = "down(218)";
                obj219.name = "down(219)";
                obj220.name = "down(220)";
                obj221.name = "down(221)";
                obj222.name = "down(222)";
                obj223.name = "down(223)";
                obj224.name = "down(224)";
                obj225.name = "down(225)";

            }
            bool light = true;
            if (light)
            {
                L1 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L2 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L3 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L4 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L5 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L6 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L7 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L8 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L9 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L10 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L11 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L12 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L13 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L14 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L15 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, 15f), Quaternion.Euler(90f, 0f, 0f));
                L16 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L17 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L18 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L19 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L20 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L21 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L22 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L23 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L24 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L25 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L26 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L27 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L28 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L29 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L30 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, 5f), Quaternion.Euler(90f, 0f, 0f));
                L31 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L32 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L33 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L34 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L35 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L36 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L37 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L38 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L39 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L40 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L41 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L42 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L43 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L44 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L45 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -5f), Quaternion.Euler(90f, 0f, 0f));
                L46 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L47 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L48 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L49 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L50 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L51 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L52 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L53 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L54 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L55 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L56 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L57 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L58 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L59 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L60 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -15f), Quaternion.Euler(90f, 0f, 0f));
                L61 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L62 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L63 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L64 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L65 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L66 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L67 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L68 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L69 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L70 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L71 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L72 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L73 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L74 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L75 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -25f), Quaternion.Euler(90f, 0f, 0f));
                L76 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L77 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L78 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L79 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L80 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L81 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L82 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L83 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L84 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L85 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L86 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L87 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L88 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L89 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L90 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -35f), Quaternion.Euler(90f, 0f, 0f));
                L91 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L92 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L93 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L94 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L95 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L96 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L97 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L98 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L99 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L100 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L101 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L102 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L103 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L104 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L105 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -45f), Quaternion.Euler(90f, 0f, 0f));
                L106 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L107 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L108 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L109 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L110 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L111 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L112 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L113 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L114 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L115 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L116 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L117 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L118 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L119 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L120 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -55f), Quaternion.Euler(90f, 0f, 0f));
                L121 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L122 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L123 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L124 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L125 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L126 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L127 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L128 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L129 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L130 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L131 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L132 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L133 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L134 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L135 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -65f), Quaternion.Euler(90f, 0f, 0f));
                L136 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L137 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L138 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L139 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L140 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L141 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L142 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L143 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L144 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L145 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L146 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L147 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L148 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L149 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L150 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -75f), Quaternion.Euler(90f, 0f, 0f));
                L151 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L152 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L153 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L154 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L155 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L156 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L157 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L158 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L159 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L160 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L161 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L162 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L163 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L164 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L165 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -85f), Quaternion.Euler(90f, 0f, 0f));
                L166 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L167 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L168 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L169 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L170 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L171 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L172 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L173 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L174 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L175 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L176 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L177 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L178 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L179 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L180 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -95f), Quaternion.Euler(90f, 0f, 0f));
                L181 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L182 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L183 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L184 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L185 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L186 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L187 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L188 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L189 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L190 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L191 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L192 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L193 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L194 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L195 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -105f), Quaternion.Euler(90f, 0f, 0f));
                L196 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L197 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L198 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L199 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L200 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L201 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L202 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L203 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L204 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L205 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L206 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L207 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L208 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L209 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L210 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -115f), Quaternion.Euler(90f, 0f, 0f));
                L211 = PhotonNetwork.Instantiate(light_p.name, new Vector3(-5f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L212 = PhotonNetwork.Instantiate(light_p.name, new Vector3(5f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L213 = PhotonNetwork.Instantiate(light_p.name, new Vector3(15f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L214 = PhotonNetwork.Instantiate(light_p.name, new Vector3(25f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L215 = PhotonNetwork.Instantiate(light_p.name, new Vector3(35f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L216 = PhotonNetwork.Instantiate(light_p.name, new Vector3(45f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L217 = PhotonNetwork.Instantiate(light_p.name, new Vector3(55f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L218 = PhotonNetwork.Instantiate(light_p.name, new Vector3(65f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L219 = PhotonNetwork.Instantiate(light_p.name, new Vector3(75f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L220 = PhotonNetwork.Instantiate(light_p.name, new Vector3(85f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L221 = PhotonNetwork.Instantiate(light_p.name, new Vector3(95f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L222 = PhotonNetwork.Instantiate(light_p.name, new Vector3(105f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L223 = PhotonNetwork.Instantiate(light_p.name, new Vector3(115f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L224 = PhotonNetwork.Instantiate(light_p.name, new Vector3(125f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L225 = PhotonNetwork.Instantiate(light_p.name, new Vector3(135f, 0.1f, -125f), Quaternion.Euler(90f, 0f, 0f));
                L1.name = "light(1)";
                L2.name = "light(2)";
                L3.name = "light(3)";
                L4.name = "light(4)";
                L5.name = "light(5)";
                L6.name = "light(6)";
                L7.name = "light(7)";
                L8.name = "light(8)";
                L9.name = "light(9)";
                L10.name = "light(10)";
                L11.name = "light(11)";
                L12.name = "light(12)";
                L13.name = "light(13)";
                L14.name = "light(14)";
                L15.name = "light(15)";
                L16.name = "light(16)";
                L17.name = "light(17)";
                L18.name = "light(18)";
                L19.name = "light(19)";
                L20.name = "light(20)";
                L21.name = "light(21)";
                L22.name = "light(22)";
                L23.name = "light(23)";
                L24.name = "light(24)";
                L25.name = "light(25)";
                L26.name = "light(26)";
                L27.name = "light(27)";
                L28.name = "light(28)";
                L29.name = "light(29)";
                L30.name = "light(30)";
                L31.name = "light(31)";
                L32.name = "light(32)";
                L33.name = "light(33)";
                L34.name = "light(34)";
                L35.name = "light(35)";
                L36.name = "light(36)";
                L37.name = "light(37)";
                L38.name = "light(38)";
                L39.name = "light(39)";
                L40.name = "light(40)";
                L41.name = "light(41)";
                L42.name = "light(42)";
                L43.name = "light(43)";
                L44.name = "light(44)";
                L45.name = "light(45)";
                L46.name = "light(46)";
                L47.name = "light(47)";
                L48.name = "light(48)";
                L49.name = "light(49)";
                L50.name = "light(50)";
                L51.name = "light(51)";
                L52.name = "light(52)";
                L53.name = "light(53)";
                L54.name = "light(54)";
                L55.name = "light(55)";
                L56.name = "light(56)";
                L57.name = "light(57)";
                L58.name = "light(58)";
                L59.name = "light(59)";
                L60.name = "light(60)";
                L61.name = "light(61)";
                L62.name = "light(62)";
                L63.name = "light(63)";
                L64.name = "light(64)";
                L65.name = "light(65)";
                L66.name = "light(66)";
                L67.name = "light(67)";
                L68.name = "light(68)";
                L69.name = "light(69)";
                L70.name = "light(70)";
                L71.name = "light(71)";
                L72.name = "light(72)";
                L73.name = "light(73)";
                L74.name = "light(74)";
                L75.name = "light(75)";
                L76.name = "light(76)";
                L77.name = "light(77)";
                L78.name = "light(78)";
                L79.name = "light(79)";
                L80.name = "light(80)";
                L81.name = "light(81)";
                L82.name = "light(82)";
                L83.name = "light(83)";
                L84.name = "light(84)";
                L85.name = "light(85)";
                L86.name = "light(86)";
                L87.name = "light(87)";
                L88.name = "light(88)";
                L89.name = "light(89)";
                L90.name = "light(90)";
                L91.name = "light(91)";
                L92.name = "light(92)";
                L93.name = "light(93)";
                L94.name = "light(94)";
                L95.name = "light(95)";
                L96.name = "light(96)";
                L97.name = "light(97)";
                L98.name = "light(98)";
                L99.name = "light(99)";
                L100.name = "light(100)";
                L101.name = "light(101)";
                L102.name = "light(102)";
                L103.name = "light(103)";
                L104.name = "light(104)";
                L105.name = "light(105)";
                L106.name = "light(106)";
                L107.name = "light(107)";
                L108.name = "light(108)";
                L109.name = "light(109)";
                L110.name = "light(110)";
                L111.name = "light(111)";
                L112.name = "light(112)";
                L113.name = "light(113)";
                L114.name = "light(114)";
                L115.name = "light(115)";
                L116.name = "light(116)";
                L117.name = "light(117)";
                L118.name = "light(118)";
                L119.name = "light(119)";
                L120.name = "light(120)";
                L121.name = "light(121)";
                L122.name = "light(122)";
                L123.name = "light(123)";
                L124.name = "light(124)";
                L125.name = "light(125)";
                L126.name = "light(126)";
                L127.name = "light(127)";
                L128.name = "light(128)";
                L129.name = "light(129)";
                L130.name = "light(130)";
                L131.name = "light(131)";
                L132.name = "light(132)";
                L133.name = "light(133)";
                L134.name = "light(134)";
                L135.name = "light(135)";
                L136.name = "light(136)";
                L137.name = "light(137)";
                L138.name = "light(138)";
                L139.name = "light(139)";
                L140.name = "light(140)";
                L141.name = "light(141)";
                L142.name = "light(142)";
                L143.name = "light(143)";
                L144.name = "light(144)";
                L145.name = "light(145)";
                L146.name = "light(146)";
                L147.name = "light(147)";
                L148.name = "light(148)";
                L149.name = "light(149)";
                L150.name = "light(150)";
                L151.name = "light(151)";
                L152.name = "light(152)";
                L153.name = "light(153)";
                L154.name = "light(154)";
                L155.name = "light(155)";
                L156.name = "light(156)";
                L157.name = "light(157)";
                L158.name = "light(158)";
                L159.name = "light(159)";
                L160.name = "light(160)";
                L161.name = "light(161)";
                L162.name = "light(162)";
                L163.name = "light(163)";
                L164.name = "light(164)";
                L165.name = "light(165)";
                L166.name = "light(166)";
                L167.name = "light(167)";
                L168.name = "light(168)";
                L169.name = "light(169)";
                L170.name = "light(170)";
                L171.name = "light(171)";
                L172.name = "light(172)";
                L173.name = "light(173)";
                L174.name = "light(174)";
                L175.name = "light(175)";
                L176.name = "light(176)";
                L177.name = "light(177)";
                L178.name = "light(178)";
                L179.name = "light(179)";
                L180.name = "light(180)";
                L181.name = "light(181)";
                L182.name = "light(182)";
                L183.name = "light(183)";
                L184.name = "light(184)";
                L185.name = "light(185)";
                L186.name = "light(186)";
                L187.name = "light(187)";
                L188.name = "light(188)";
                L189.name = "light(189)";
                L190.name = "light(190)";
                L191.name = "light(191)";
                L192.name = "light(192)";
                L193.name = "light(193)";
                L194.name = "light(194)";
                L195.name = "light(195)";
                L196.name = "light(196)";
                L197.name = "light(197)";
                L198.name = "light(198)";
                L199.name = "light(199)";
                L200.name = "light(200)";
                L201.name = "light(201)";
                L202.name = "light(202)";
                L203.name = "light(203)";
                L204.name = "light(204)";
                L205.name = "light(205)";
                L206.name = "light(206)";
                L207.name = "light(207)";
                L208.name = "light(208)";
                L209.name = "light(209)";
                L210.name = "light(210)";
                L211.name = "light(211)";
                L212.name = "light(212)";
                L213.name = "light(213)";
                L214.name = "light(214)";
                L215.name = "light(215)";
                L216.name = "light(216)";
                L217.name = "light(217)";
                L218.name = "light(218)";
                L219.name = "light(219)";
                L220.name = "light(220)";
                L221.name = "light(221)";
                L222.name = "light(222)";
                L223.name = "light(223)";
                L224.name = "light(224)";
                L225.name = "light(225)";



            }




            //bool sss = true;

            // /*
            /*if (sss)
            {
                pir_w_1 = Instantiate(pir_w, new Vector3(+5f, 0f, -58.3f), Quaternion.identity);
                pir_w_2 = Instantiate(pir_w, new Vector3(+5f, 0f, -56.2f), Quaternion.identity);
                pir_w_3 = Instantiate(pir_w, new Vector3(+5f, 0f, -54.1f), Quaternion.identity);
                boat_w_1 = Instantiate(boat_w, new Vector3(+5f, 0.3f, -55f), Quaternion.Euler(90f, -90f, 0f));
                pir_b_1 = Instantiate(pir_b, new Vector3(+125f, 0f, -55.9f), Quaternion.identity);
                pir_b_2 = Instantiate(pir_b, new Vector3(+125f, 0f, -53.8f), Quaternion.identity);
                pir_b_3 = Instantiate(pir_b, new Vector3(+125f, 0f, -51.7f), Quaternion.identity);
                boat_b_1 = Instantiate(boat_b, new Vector3(+125f, 0.3f, -55f), Quaternion.Euler(90f, 90f, 0f));
                pir_y_1 = Instantiate(pir_y, new Vector3(+65f - 3.3f, 0f, 5f), Quaternion.identity);
                pir_y_2 = Instantiate(pir_y, new Vector3(+65f - 1.2f, 0f, 5f), Quaternion.identity);
                pir_y_3 = Instantiate(pir_y, new Vector3(+65f + 0.9f, 0f, 5f), Quaternion.identity);
                boat_y_1 = Instantiate(boat_y, new Vector3(+65f, 0.3f, 5f), Quaternion.Euler(90f, 0f, 0f));
                pir_r_1 = Instantiate(pir_r, new Vector3(+65f + 0.9f, 0f, -115f), Quaternion.identity);
                pir_r_2 = Instantiate(pir_r, new Vector3(+65f + 1.2f, 0f, -115f), Quaternion.identity);
                pir_r_3 = Instantiate(pir_r, new Vector3(+65f - 0.9f, 0f, -115f), Quaternion.identity);
                boat_r_1 = Instantiate(boat_r, new Vector3(+65f, 0.3f, -115f), Quaternion.Euler(90f, 180f, 0f));
           

            pir_w_1 = PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -58.3f), Quaternion.identity);
            pir_w_2 = PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -56.2f), Quaternion.identity);
            pir_w_3 = PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -54.1f), Quaternion.identity);
            boat_w_1 = PhotonNetwork.Instantiate(boat_w.name, new Vector3(+5f, 0.3f, -55f), Quaternion.Euler(90f, -90f, 0f));
            pir_b_1 = PhotonNetwork.Instantiate(pir_b.name, new Vector3(+125f, 0f, -55.9f), Quaternion.identity);
            pir_b_2 = PhotonNetwork.Instantiate(pir_b.name, new Vector3(+125f, 0f, -53.8f), Quaternion.identity);
            pir_b_3 = PhotonNetwork.Instantiate(pir_b.name, new Vector3(+125f, 0f, -51.7f), Quaternion.identity);
            boat_b_1 = PhotonNetwork.Instantiate(boat_b.name, new Vector3(+125f, 0.3f, -55f), Quaternion.Euler(90f, 90f, 0f));
            pir_y_1 = PhotonNetwork.Instantiate(pir_y.name, new Vector3(+65f - 3.3f, 0f, 5f), Quaternion.identity);
            pir_y_2 = PhotonNetwork.Instantiate(pir_y.name, new Vector3(+65f - 1.2f, 0f, 5f), Quaternion.identity);
            pir_y_3 = PhotonNetwork.Instantiate(pir_y.name, new Vector3(+65f + 0.9f, 0f, 5f), Quaternion.identity);
            boat_y_1 = PhotonNetwork.Instantiate(boat_y.name, new Vector3(+65f, 0.3f, 5f), Quaternion.Euler(90f, 0f, 0f));
            pir_r_1 = PhotonNetwork.Instantiate(pir_r.name, new Vector3(+65f + 0.9f, 0f, -115f), Quaternion.identity);
            pir_r_2 = PhotonNetwork.Instantiate(pir_r.name, new Vector3(+65f + 1.2f, 0f, -115f), Quaternion.identity);
            pir_r_3 = PhotonNetwork.Instantiate(pir_r.name, new Vector3(+65f - 0.9f, 0f, -115f), Quaternion.identity);
            boat_r_1 = PhotonNetwork.Instantiate(boat_r.name, new Vector3(+65f, 0.3f, -115f), Quaternion.Euler(90f, 180f, 0f));
            pir_w_1.name = "pir_w_1";
            pir_w_2.name = "pir_w_2";
            pir_w_3.name = "pir_w_3";
            boat_w_1.name = "boat_w_1";
            pir_b_1.name = "pir_b_1";
            pir_b_2.name = "pir_b_2";
            pir_b_3.name = "pir_b_3";
            boat_b_1.name = "boat_b_1";
            pir_y_1.name = "pir_y_1";
            pir_y_2.name = "pir_y_2";
            pir_y_3.name = "pir_y_3";
            boat_y_1.name = "boat_y_1";
            pir_r_1.name = "pir_r_1";
            pir_r_2.name = "pir_r_2";
            pir_r_3.name = "pir_r_3";
            boat_r_1.name = "boat_r_1";*/
            /*  Obj90 = pir_w_1;
              Obj91 = pir_w_2;
              Obj92 = pir_w_3;
              Obj93 = boat_w_1;
              Obj94 = pir_b_1;
              Obj95 = pir_b_2;
              Obj96 = pir_b_3;
              Obj97 = boat_b_1;
              Obj98 = pir_r_1;
              Obj99 = pir_r_2;
              Obj100 = pir_r_3;
              Obj101 = pir_r_1;
              Obj102 = pir_y_1;
              Obj103 = pir_y_2;
              Obj104 = pir_y_3;
              Obj105 = boat_y_1;*/
            //sss = false;

            //pir_b_1.SetActive(false);
            //pir_b_2.SetActive(false);
            //pir_b_3.SetActive(false);
            //boat_b_1.SetActive(false); 
            pir_y_1.SetActive(false);
            pir_y_2.SetActive(false);
            pir_y_3.SetActive(false);
            boat_y_1.SetActive(false);
            pir_r_1.SetActive(false);
            pir_r_2.SetActive(false);
            pir_r_3.SetActive(false);
            boat_r_1.SetActive(false);

            Debug.Log("Pir and boat created (Player1)");
            ToT();
            //Indic = true;





            //.SetActive(false);
            // pir_w_1 = Player1.pir_w_1;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -58.3f), Quaternion.identity);
            // pir_w_2 = ;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -56.2f), Quaternion.identity);
            // pir_w_3 = ;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -54.1f), Quaternion.identity);
            // boat_w_1 = ;//PhotonNetwork.Instantiate(boat_w.name, new Vector3(+5f, 0.3f, -55f), Quaternion.Euler(90f, -90f, 0f));
            // Debug.Log("Pir and boat created (Player2)");
            // pir_w_1 = Player1.pir_w_1;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -58.3f), Quaternion.identity);
            // pir_w_2 = ;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -56.2f), Quaternion.identity);
            // pir_w_3 = ;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -54.1f), Quaternion.identity);
            // boat_w_1 = ;//PhotonNetwork.Instantiate(boat_w.name, new Vector3(+5f, 0.3f, -55f), Quaternion.Euler(90f, -90f, 0f));
            //Debug.Log("Pir and boat created (Player2)");
            //*/
        }
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            //  pir_b_1 = PhotonNetwork.Instantiate(pir_b.name, new Vector3(+125f, 0f, -55.9f), Quaternion.identity);
            // pir_b_2 = PhotonNetwork.Instantiate(pir_b.name, new Vector3(+125f, 0f, -53.8f), Quaternion.identity);
            // pir_b_3 = PhotonNetwork.Instantiate(pir_b.name, new Vector3(+125f, 0f, -51.7f), Quaternion.identity);
            // boat_b_1 = PhotonNetwork.Instantiate(boat_b.name, new Vector3(+125f, 0.3f, -55f), Quaternion.Euler(90f, 90f, 0f));
            // pir_w_1 = Player1.pir_w_1;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -58.3f), Quaternion.identity);
            // pir_w_2 = ;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -56.2f), Quaternion.identity);
            // pir_w_3 = ;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -54.1f), Quaternion.identity);
            // boat_w_1 = ;//PhotonNetwork.Instantiate(boat_w.name, new Vector3(+5f, 0.3f, -55f), Quaternion.Euler(90f, -90f, 0f));
            // pir_b_1.name = "pir_b_1";
            // pir_b_2.name = "pir_b_2";
            // pir_b_3.name = "pir_b_3";
            // boat_b_1.name = "boat_b_1";
            // Debug.Log("Pir and boat created (Player2)");
        }
        /* Obj93.transform.position = new Vector3(+5f, 0.3f, -55f);
            Obj97.transform.position = new Vector3(+125f, 0.3f, -55f);
            Obj101.transform.position = new Vector3(+65f, 0.3f, 5f);
            Obj105.transform.position = new Vector3(+65f, 0.3f, -115f);
            Obj90.transform.position = new Vector3(+5f, 0f, -58.3f);
            Obj91.transform.position = new Vector3(+5f, 0f, -56.2f);
            Obj92.transform.position = new Vector3(+5f, 0f, -54.1f);
           // Obj94.transform.position = new Vector3(+125f, 0f, -55.9f);
           // Obj95.transform.position = new Vector3(+125f, 0f, -53.8f);
            //Obj96.transform.position = new Vector3(+125f, 0f, -51.7f);
            Obj98.transform.position = new Vector3(+65f - 3.3f, 0, 5f);
            Obj99.transform.position = new Vector3(+65f - 1.2f, 0, 5f);
            Obj100.transform.position = new Vector3(+65f + 0.9f, 0, 5f);
            Obj102.transform.position = new Vector3(+65f + 3.3f, 0, -115f);
            Obj103.transform.position = new Vector3(+65f + 1.2f, 0, -115f);
            Obj104.transform.position = new Vector3(+65f - 0.9f, 0, -115f);*/
        if (PhotonNetwork.CurrentRoom.PlayerCount == 3)
        {
            // pir_y_1 = PhotonNetwork.Instantiate(pir_y.name, new Vector3(+65f - 3.3f, 0f, 5f), Quaternion.identity);
            // pir_y_2 = PhotonNetwork.Instantiate(pir_y.name, new Vector3(+65f - 1.2f, 0f, 5f), Quaternion.identity);
            // pir_y_3 = PhotonNetwork.Instantiate(pir_y.name, new Vector3(+65f + 0.9f, 0f, 5f), Quaternion.identity);
            // boat_y_1 = PhotonNetwork.Instantiate(boat_y.name, new Vector3(+65f, 0.3f, 5f), Quaternion.Euler(90f, 0f, 0f));
            // pir_w_1 = Player1.pir_w_1;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -58.3f), Quaternion.identity);
            // pir_w_2 = ;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -56.2f), Quaternion.identity);
            // pir_w_3 = ;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -54.1f), Quaternion.identity);
            // boat_w_1 = ;//PhotonNetwork.Instantiate(boat_w.name, new Vector3(+5f, 0.3f, -55f), Quaternion.Euler(90f, -90f, 0f));
            // Debug.Log("Pir and boat created (Player3)");

            // pir_y_1.name = "pir_y_1";
            // pir_y_2.name = "pir_y_2";
            // pir_y_3.name = "pir_y_3";
            // boat_y_1.name = "boat_y_1";
        }
        if (PhotonNetwork.CurrentRoom.PlayerCount == 4)
        {
            // pir_r_1 = PhotonNetwork.Instantiate(pir_r.name, new Vector3(+65f + 0.9f, 0f, -115f), Quaternion.identity);
            // pir_r_2 = PhotonNetwork.Instantiate(pir_r.name, new Vector3(+65f + 1.2f, 0f, -115f), Quaternion.identity);
            // pir_r_3 = PhotonNetwork.Instantiate(pir_r.name, new Vector3(+65f - 0.9f, 0f, -115f), Quaternion.identity);
            // boat_r_1 = PhotonNetwork.Instantiate(boat_r.name, new Vector3(+65f, 0.3f, -115f), Quaternion.Euler(90f, 180f, 0f));
            // pir_w_1 = Player1.pir_w_1;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -58.3f), Quaternion.identity);
            // pir_w_2 = ;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -56.2f), Quaternion.identity);
            // pir_w_3 = ;//PhotonNetwork.Instantiate(pir_w.name, new Vector3(+5f, 0f, -54.1f), Quaternion.identity);
            // boat_w_1 = ;//PhotonNetwork.Instantiate(boat_w.name, new Vector3(+5f, 0.3f, -55f), Quaternion.Euler(90f, -90f, 0f));
            // Debug.Log("Pir and boat created (Player4)");
            //   pir_r_1.name = "pir_r_1";
            //  pir_r_2.name = "pir_r_2";
            //  pir_r_3.name = "pir_r_3";
            //   boat_r_1.name = "boat_r_1";

        }
        JOR = true;
    }
    /*public void LeaveRoom()// покидаем комнату
    {
        PhotonNetwork.LeaveRoom();
        Debug.Log("LeaveRoom");
    }
    public override void OnLeftRoom()//наш игрок ливнул в лобби
    {
        SceneManager.LoadScene(0);
        Debug.Log("OnLeftRoom");
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)// игрок присоединился
    {
        Debug.Log("Other player entred room - " + newPlayer.NickName);
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)// игрок ливнул
    {
        Debug.Log("Other player left room - " + otherPlayer.NickName);
    }
    */
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
        if (JOR)
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
                Position = new RVPos();
                //HPosition = new FPos();
                z = false;
                //Indic = false;
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
                // Obj73.SetActive(false);
                //Obj74.SetActive(false);
                //Obj75.SetActive(false);
                //Obj76.SetActive(false);
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
                Obj15.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                Obj15.transform.position = new Vector3(+65f, 0f, -55f);
                Obj17.transform.rotation = Quaternion.Euler(90, 0, 180f);
                Obj17.transform.position = new Vector3(0, 160, 0);
                yyy = 90f;

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


                //OnLoad();
            }



            //massive of illumination

            //ToF();
            Field1 = new CField(obj1);
            Field1 = new CField(obj2);
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
            Pir1 = pir_w_1;
            Pir2 = pir_w_2;
            Pir3 = pir_w_3;
            Pir4 = pir_b_1;
            Pir5 = pir_b_2;
            Pir6 = pir_b_3;
            Pir7 = pir_r_1;
            Pir8 = pir_r_2;
            Pir9 = pir_r_3;
            Pir10 = pir_y_1;
            Pir11 = pir_y_2;
            Pir12 = pir_y_3;
            Pie1 = new CPirate(1, 7, 0, pir_w_1);
            Pie2 = new CPirate(1, 7, 0, pir_w_2);
            Pie3 = new CPirate(1, 7, 0, pir_w_3);
            Pie4 = new CPirate(13, 7, 1, pir_b_1);
            Pie5 = new CPirate(13, 7, 1, pir_b_2);
            Pie6 = new CPirate(13, 7, 1, pir_b_3);
            Pie7 = new CPirate(7, 1, 2, pir_y_1);
            Pie8 = new CPirate(7, 1, 2, pir_y_2);
            Pie9 = new CPirate(7, 1, 2, pir_y_3);
            Pie10 = new CPirate(7, 13, 3, pir_r_1);
            Pie11 = new CPirate(7, 13, 3, pir_r_2);
            Pie12 = new CPirate(7, 13, 3, pir_r_3);
            ShipWhi = new CPirate(1, 7, 0, boat_w_1);
            ShipBla = new CPirate(13, 7, 1, boat_b_1);
            ShipYel = new CPirate(7, 13, 3, boat_y_1);
            ShipRed = new CPirate(7, 1, 2, boat_r_1);
            // Pie4 = new CPirate(13, 7, 1, MS.pir_b_1);
            // Pie5 = new CPirate(13, 7, 1, MS.pir_b_2);
            // Pie6 = new CPirate(13, 7, 1, MS.pir_w_3);
            //Pie7 = new CPirate(7, 1, 2, Obj98);
            //Pie8 = new CPirate(7, 1, 2, Obj99);
            //Pie9 = new CPirate(7, 1, 2, Obj100);
            //Pie10 = new CPirate(7, 13, 3, Obj102);
            //Pie11 = new CPirate(7, 13, 3, Obj103);
            //Pie12 = new CPirate(7, 13, 3, Obj104);

            // ShipBla = new CPirate(13, 7, 1, MS.boat_b_1);
            //ShipYel = new CPirate(7, 13, 3, Obj105);
            //ShipRed = new CPirate(7, 1, 2, Obj101);


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
            Pizza = new CPirate[4, 4] { {new CPirate(1, 7, 0, pir_w_1),new CPirate(1, 7, 0, pir_w_2),new CPirate(1, 7, 0, pir_w_3), new CPirate(1, 7, 0, boat_w_1) },
             {new CPirate(13, 7, 1, pir_b_1),new CPirate(13, 7, 1, pir_b_2),new CPirate(13, 7, 1, pir_b_3), new CPirate(13, 7, 1, boat_b_1) },
            {new CPirate(7, 13, 3, pir_r_1),new CPirate(7, 13, 3, pir_r_2),new CPirate(7, 13, 3, pir_r_3), new CPirate(7, 13, 3, boat_y_1) },
                {new CPirate(7, 1, 2, pir_y_1),new CPirate(7, 1, 2, pir_y_2),new CPirate(7, 1, 2, pir_y_3), new CPirate(7, 1, 2, boat_r_1) }};

            for (int qqq = 0; qqq < 4; qqq++)
            {

                Pizza[qqq, 3].is_ship = true;
            }
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
            CField[,] FieldField = new CField[15, 15] {{new CField(obj1),new CField(obj2),new CField(obj3),new CField(obj4),new CField(obj5),new CField(obj6),new CField(obj7),new CField(obj8),new CField(obj9),new CField(obj10),new CField(obj11),new CField(obj12),new CField(obj13),new CField(obj14),new CField(obj15)},
{new CField(obj16),new CField(obj17),new CField(obj18),new CField(obj19),new CField(obj20),new CField(obj21),new CField(obj22),new CField(obj23),new CField(obj24),new CField(obj25),new CField(obj26),new CField(obj27),new CField(obj28),new CField(obj29),new CField(obj30)},
{new CField(obj31),new CField(obj32),new CField(obj33),new CField(obj34),new CField(obj35),new CField(obj36),new CField(obj37),new CField(obj38),new CField(obj39),new CField(obj40),new CField(obj41),new CField(obj42),new CField(obj43),new CField(obj44),new CField(obj45)},
{new CField(obj46),new CField(obj47),new CField(obj48),new CField(obj49),new CField(obj50),new CField(obj51),new CField(obj52),new CField(obj53),new CField(obj54),new CField(obj55),new CField(obj56),new CField(obj57),new CField(obj58),new CField(obj59),new CField(obj60)},
{new CField(obj61),new CField(obj62),new CField(obj63),new CField(obj64),new CField(obj65),new CField(obj66),new CField(obj67),new CField(obj68),new CField(obj69),new CField(obj70),new CField(obj71),new CField(obj72),new CField(obj73),new CField(obj74),new CField(obj75)},
{new CField(obj76),new CField(obj77),new CField(obj78),new CField(obj79),new CField(obj80),new CField(obj81),new CField(obj82),new CField(obj83),new CField(obj84),new CField(obj85),new CField(obj86),new CField(obj87),new CField(obj88),new CField(obj89),new CField(obj90)},
{new CField(obj91),new CField(obj92),new CField(obj93),new CField(obj94),new CField(obj95),new CField(obj96),new CField(obj97),new CField(obj98),new CField(obj99),new CField(obj100),new CField(obj101),new CField(obj102),new CField(obj103),new CField(obj104),new CField(obj105)},
{new CField(obj106),new CField(obj107),new CField(obj108),new CField(obj109),new CField(obj110),new CField(obj111),new CField(obj112),new CField(obj113),new CField(obj114),new CField(obj115),new CField(obj116),new CField(obj117),new CField(obj118),new CField(obj119),new CField(obj120)},
{new CField(obj121),new CField(obj122),new CField(obj123),new CField(obj124),new CField(obj125),new CField(obj126),new CField(obj127),new CField(obj128),new CField(obj129),new CField(obj130),new CField(obj131),new CField(obj132),new CField(obj133),new CField(obj134),new CField(obj135)},
{new CField(obj136),new CField(obj137),new CField(obj138),new CField(obj139),new CField(obj140),new CField(obj141),new CField(obj142),new CField(obj143),new CField(obj144),new CField(obj145),new CField(obj146),new CField(obj147),new CField(obj148),new CField(obj149),new CField(obj150)},
{new CField(obj151),new CField(obj152),new CField(obj153),new CField(obj154),new CField(obj155),new CField(obj156),new CField(obj157),new CField(obj158),new CField(obj159),new CField(obj160),new CField(obj161),new CField(obj162),new CField(obj163),new CField(obj164),new CField(obj165)},
{new CField(obj166),new CField(obj167),new CField(obj168),new CField(obj169),new CField(obj170),new CField(obj171),new CField(obj172),new CField(obj173),new CField(obj174),new CField(obj175),new CField(obj176),new CField(obj177),new CField(obj178),new CField(obj179),new CField(obj180)},
{new CField(obj181),new CField(obj182),new CField(obj183),new CField(obj184),new CField(obj185),new CField(obj186),new CField(obj187),new CField(obj188),new CField(obj189),new CField(obj190),new CField(obj191),new CField(obj192),new CField(obj193),new CField(obj194),new CField(obj195)},
{new CField(obj196),new CField(obj197),new CField(obj198),new CField(obj199),new CField(obj200),new CField(obj201),new CField(obj202),new CField(obj203),new CField(obj204),new CField(obj205),new CField(obj206),new CField(obj207),new CField(obj208),new CField(obj209),new CField(obj210)},
{new CField(obj211),new CField(obj212),new CField(obj213),new CField(obj214),new CField(obj215),new CField(obj216),new CField(obj217),new CField(obj218),new CField(obj219),new CField(obj220),new CField(obj221),new CField(obj222),new CField(obj223),new CField(obj224),new CField(obj225)} };


            Material[] matfield = new Material[41] { mat1, mat2, mat3, mat4, mat5,
                                             mat6, mat7, mat8, mat9, mat10,
                                             mat11, mat12, mat13, mat14, mat15,
                                             mat16, mat17, mat18, mat19, mat20,
                                             mat21, mat22, mat23, mat24, mat25,
                                             mat26, mat27, mat28, mat29, mat30,
                                             mat31, mat32, mat33, mat34, mat35,
                                             mat36, mat37, mat38, mat39, mat40,
                                             mat41};
            Crosses = new GameObject[3][,];
            Crosses[0] = new GameObject[2, 3]{ { Obj156, Obj157, Obj158 },
                                               { Obj159, Obj160, Obj161 } };
            Crosses[1] = new GameObject[4, 3]{ { Obj162, Obj163, Obj164 },
                                               { Obj165, Obj166, Obj167 },
                                               { Obj168, Obj169, Obj170 },
                                               { Obj171, Obj172, Obj173 }};

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

            //Now creating a new randomized gamefield

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
                //menu_fight.SetActive(false);
                //menu.SetActive(true);
                save = false;
                print("ДДАА");
                //in_fight.re=false;
                //in_fight.re = false;
                in_fight.re = false;
                out_fight.re = false;
                home.re = false;
                //save = false;
                home.re = false;
                MS.Exit = true;
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

            if ((Input.GetKey(KeyCode.Q)) | (Win == true) & (win_menu < 1))
            {
                win_on.SetActive(true);
                blok3 = true;
                win_menu++;
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
                //menu_fight.SetActive(false);
                //menu.SetActive(true);
                MS.Exit = true;
                save = true;
                in_fight.re = false;
                out_fight.re = false;
                home.re = false;
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
                MS.Exit = true;
                //menu_fight.SetActive(false);
                //menu.SetActive(true);
                save = false;
                in_fight.re = false;
                out_fight.re = false;
                home.re = false;
            }
            if ((Input.GetKey(KeyCode.U)) | (Indic))

            {


                /* Obj93.transform.position = new Vector3(+5f, 0.3f, -55f);
                 Obj97.transform.position = new Vector3(+125f, 0.3f, -55f);
                 Obj101.transform.position = new Vector3(+65f, 0.3f, 5f);
                 Obj105.transform.position = new Vector3(+65f, 0.3f, -115f);
                 Obj90.transform.position = new Vector3(+5f, 0f, -58.3f);
                 Obj91.transform.position = new Vector3(+5f, 0f, -56.2f);
                 Obj92.transform.position = new Vector3(+5f, 0f, -54.1f);
                 Obj94.transform.position = new Vector3(+125f, 0f, -55.9f);
                 Obj95.transform.position = new Vector3(+125f, 0f, -53.8f);
                 Obj96.transform.position = new Vector3(+125f, 0f, -51.7f);
                 Obj98.transform.position = new Vector3(+65f - 3.3f, 0, 5f);
                 Obj99.transform.position = new Vector3(+65f - 1.2f, 0, 5f);
                 Obj100.transform.position = new Vector3(+65f + 0.9f, 0, 5f);
                 Obj102.transform.position = new Vector3(+65f + 3.3f, 0, -115f);
                 Obj103.transform.position = new Vector3(+65f + 1.2f, 0, -115f);
                 Obj104.transform.position = new Vector3(+65f - 0.9f, 0, -115f);*/
                //z0 = true;
                //z1 = true;
                //iz2 = true;
                pir_y_1.SetActive(false);
                pir_y_2.SetActive(false);
                pir_y_3.SetActive(false);
                boat_y_1.SetActive(false);
                pir_r_1.SetActive(false);
                pir_r_2.SetActive(false);
                pir_r_3.SetActive(false);
                boat_r_1.SetActive(false);
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
                    Chest[i].CoinStartPosition = new Vector3(
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
                print("arseniiiiii");
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
                pir_y_1.SetActive(false);
                pir_y_2.SetActive(false);
                pir_y_3.SetActive(false);
                boat_y_1.SetActive(false);
                pir_r_1.SetActive(false);
                pir_r_2.SetActive(false);
                pir_r_3.SetActive(false);
                boat_r_1.SetActive(false);
            }



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
                        Debug.Log("CCCCCC");
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
                                        // goto point2;
                                    }
                                }
                            }
                            Pizza[ii, jj].Death();
                            Pizza[ii, jj].dead = true;
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
                                    // Chest[ppp].coin.transform.position = new Vector3(Chest[ppp].cj * 10f, Chest[ppp].level * 0.3f, Chest[ppp].ci * (-10f));
                                }
                            }
                        }
                        //point2:

                        // Debug.Log("Dead");

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

            if ((Pizza[0, 0].dead == true || Pizza[0, 0].trapped == true || Pizza[0, 0].drunk == true) && (Pizza[0, 1].dead == true || Pizza[0, 1].trapped == true || Pizza[0, 1].drunk == true) && (Pizza[0, 2].dead == true || Pizza[0, 2].trapped == true || Pizza[0, 2].drunk == true))
            {
                allwhitedied = true;
                if (Pizza[0, 0].drunk != true && Pizza[0, 1].drunk != true && Pizza[0, 2].drunk != true)
                {
                    whiteeliminated = true;
                }
                else
                    whiteeliminated = false;
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
                else
                    redeliminated = false;
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
                else
                    blackeliminated = false;
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
                else
                    yelloweliminated = false;
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
                    Debug.Log(hit.collider.name);
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
                                    Debug.Log(hit.collider.name);
                                    Debug.Log(ii);
                                    print(Pizza[ii, jj].Pirate.name);
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

                                    //Debug.Log(hit.collider.name);
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
                                                Debug.Log(Pizza[iii, jjj].timespent);

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

                                                Debug.Log("hm");
                                                // checking if he had a coin
                                                if (Pizza[iii, jjj].has_coin)
                                                {
                                                    Debug.Log($"ye{MovesQuan}");
                                                    for (int asd = 0; asd < 37; asd++)
                                                    {
                                                        if (Chest[asd].chosen)
                                                        {

                                                            Chest[asd].level = FieldField[ii, jj].RemainingCoins + 1;
                                                            Debug.Log($"yep {Chest[asd].level}   {MovesQuan}  {FieldField[ii, jj].RemainingCoins}");
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
                                                    Debug.Log("lOkim");


                                                    int ccii = Chest[gg].ci;
                                                    int ccjj = Chest[gg].cj;


                                                    if ((ccii == ii) && (ccjj == jj))
                                                    {
                                                        Debug.Log("jj");
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
                                                    Debug.Log(Pizza[iii, jjj].xbeg);
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
                                                for (int asd = 0; asd < 37; asd++)
                                                {
                                                    if (Chest[asd].chosen == true)
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
    }

    //RVPos Position;

    public RVPos CEmpty()
    {

        if (true)
        {
            Field1 = new CField(obj1);
            Field1 = new CField(obj2);
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
            Pir1 = pir_w_1;
            Pir2 = pir_w_2;
            Pir3 = pir_w_3;
            Pir4 = pir_b_1;
            Pir5 = pir_b_2;
            Pir6 = pir_b_3;
            Pir7 = pir_r_1;
            Pir8 = pir_r_2;
            Pir9 = pir_r_3;
            Pir10 = pir_y_1;
            Pir11 = pir_y_2;
            Pir12 = pir_y_3;
            Pie1 = new CPirate(1, 7, 0, pir_w_1);
            Pie2 = new CPirate(1, 7, 0, pir_w_2);
            Pie3 = new CPirate(1, 7, 0, pir_w_3);
            Pie4 = new CPirate(13, 7, 1, pir_b_1);
            Pie5 = new CPirate(13, 7, 1, pir_b_2);
            Pie6 = new CPirate(13, 7, 1, pir_b_3);
            Pie7 = new CPirate(7, 1, 2, pir_y_1);
            Pie8 = new CPirate(7, 1, 2, pir_y_2);
            Pie9 = new CPirate(7, 1, 2, pir_y_3);
            Pie10 = new CPirate(7, 13, 3, pir_r_1);
            Pie11 = new CPirate(7, 13, 3, pir_r_2);
            Pie12 = new CPirate(7, 13, 3, pir_r_3);
            ShipWhi = new CPirate(1, 7, 0, boat_w_1);
            ShipBla = new CPirate(13, 7, 1, boat_b_1);
            ShipYel = new CPirate(7, 13, 3, boat_y_1);
            ShipRed = new CPirate(7, 1, 2, boat_r_1);

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

        Pizza = new CPirate[4, 4] { {new CPirate(1, 7, 0, pir_w_1),new CPirate(1, 7, 0, pir_w_2),new CPirate(1, 7, 0, pir_w_3), new CPirate(1, 7, 0, boat_w_1) },
            {new CPirate(13, 7, 1, pir_b_1),new CPirate(13, 7, 1, pir_b_2),new CPirate(13, 7, 1, pir_b_3), new CPirate(13, 7, 1, boat_b_1) },
             {new CPirate(7, 1, 2, pir_y_1),new CPirate(7, 1, 2, pir_y_2),new CPirate(7, 1, 2, pir_y_3), new CPirate(7, 1, 2, boat_y_1) },
            {new CPirate(7, 13, 3, pir_r_1),new CPirate(7, 13, 3, pir_r_2),new CPirate(7, 13, 3, pir_r_3), new CPirate(7, 13, 3, boat_r_1) }};



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
        CField[,] FieldField = new CField[15, 15] {{new CField(obj1),new CField(obj2),new CField(obj3),new CField(obj4),new CField(obj5),new CField(obj6),new CField(obj7),new CField(obj8),new CField(obj9),new CField(obj10),new CField(obj11),new CField(obj12),new CField(obj13),new CField(obj14),new CField(obj15)},
{new CField(obj16),new CField(obj17),new CField(obj18),new CField(obj19),new CField(obj20),new CField(obj21),new CField(obj22),new CField(obj23),new CField(obj24),new CField(obj25),new CField(obj26),new CField(obj27),new CField(obj28),new CField(obj29),new CField(obj30)},
{new CField(obj31),new CField(obj32),new CField(obj33),new CField(obj34),new CField(obj35),new CField(obj36),new CField(obj37),new CField(obj38),new CField(obj39),new CField(obj40),new CField(obj41),new CField(obj42),new CField(obj43),new CField(obj44),new CField(obj45)},
{new CField(obj46),new CField(obj47),new CField(obj48),new CField(obj49),new CField(obj50),new CField(obj51),new CField(obj52),new CField(obj53),new CField(obj54),new CField(obj55),new CField(obj56),new CField(obj57),new CField(obj58),new CField(obj59),new CField(obj60)},
{new CField(obj61),new CField(obj62),new CField(obj63),new CField(obj64),new CField(obj65),new CField(obj66),new CField(obj67),new CField(obj68),new CField(obj69),new CField(obj70),new CField(obj71),new CField(obj72),new CField(obj73),new CField(obj74),new CField(obj75)},
{new CField(obj76),new CField(obj77),new CField(obj78),new CField(obj79),new CField(obj80),new CField(obj81),new CField(obj82),new CField(obj83),new CField(obj84),new CField(obj85),new CField(obj86),new CField(obj87),new CField(obj88),new CField(obj89),new CField(obj90)},
{new CField(obj91),new CField(obj92),new CField(obj93),new CField(obj94),new CField(obj95),new CField(obj96),new CField(obj97),new CField(obj98),new CField(obj99),new CField(obj100),new CField(obj101),new CField(obj102),new CField(obj103),new CField(obj104),new CField(obj105)},
{new CField(obj106),new CField(obj107),new CField(obj108),new CField(obj109),new CField(obj110),new CField(obj111),new CField(obj112),new CField(obj113),new CField(obj114),new CField(obj115),new CField(obj116),new CField(obj117),new CField(obj118),new CField(obj119),new CField(obj120)},
{new CField(obj121),new CField(obj122),new CField(obj123),new CField(obj124),new CField(obj125),new CField(obj126),new CField(obj127),new CField(obj128),new CField(obj129),new CField(obj130),new CField(obj131),new CField(obj132),new CField(obj133),new CField(obj134),new CField(obj135)},
{new CField(obj136),new CField(obj137),new CField(obj138),new CField(obj139),new CField(obj140),new CField(obj141),new CField(obj142),new CField(obj143),new CField(obj144),new CField(obj145),new CField(obj146),new CField(obj147),new CField(obj148),new CField(obj149),new CField(obj150)},
{new CField(obj151),new CField(obj152),new CField(obj153),new CField(obj154),new CField(obj155),new CField(obj156),new CField(obj157),new CField(obj158),new CField(obj159),new CField(obj160),new CField(obj161),new CField(obj162),new CField(obj163),new CField(obj164),new CField(obj165)},
{new CField(obj166),new CField(obj167),new CField(obj168),new CField(obj169),new CField(obj170),new CField(obj171),new CField(obj172),new CField(obj173),new CField(obj174),new CField(obj175),new CField(obj176),new CField(obj177),new CField(obj178),new CField(obj179),new CField(obj180)},
{new CField(obj181),new CField(obj182),new CField(obj183),new CField(obj184),new CField(obj185),new CField(obj186),new CField(obj187),new CField(obj188),new CField(obj189),new CField(obj190),new CField(obj191),new CField(obj192),new CField(obj193),new CField(obj194),new CField(obj195)},
{new CField(obj196),new CField(obj197),new CField(obj198),new CField(obj199),new CField(obj200),new CField(obj201),new CField(obj202),new CField(obj203),new CField(obj204),new CField(obj205),new CField(obj206),new CField(obj207),new CField(obj208),new CField(obj209),new CField(obj210)},
{new CField(obj211),new CField(obj212),new CField(obj213),new CField(obj214),new CField(obj215),new CField(obj216),new CField(obj217),new CField(obj218),new CField(obj219),new CField(obj220),new CField(obj221),new CField(obj222),new CField(obj223),new CField(obj224),new CField(obj225)} };

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
