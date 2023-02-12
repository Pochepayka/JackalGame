using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class FPos : MonoBehaviour
{
    CField[,] FieldField;
    CPirate[,] Pizza;
    CCoin[] Chest;

    int[][] CoinsQuan;
    int[] CoinCondi;
    int FMQuan;
    int Arseniy = 0;
    int[,] field;
    int Vobla;

    bool can_die = false;
    bool swim_only_forward = false;
    bool hidden_field = false;
    bool unlimited_plane = false;
    bool steply_rotation = false;
    bool sequence = false;
    bool unlimited_moving = false;

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


    //public CPirate[,] Pizza;

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

    RVPos Position;

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
                                    { 0, 0, 0, 0 } };*//*
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
                FieldField[i, j].open1();*/
                                                       //Debug.Log($"{FieldField[i, j].obj.name}   {FieldField[i, j].coins}");/*
                                                       /*
                                                       Vobla = FieldField[i, j].coins;
                                                       while (Vobla != 0)
                                                       {
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

                                           public RVPos LoadIn()
                                           {
                                               return Position;
                                           }

                                           public void LoadOut(string name)
                                           {

                                           }

                                       }/*
                                       */
