using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Pun.Demo.Cockpit;

public class PUN : MonoBehaviourPunCallbacks
{
    public FormU_3 FU;
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.NickName = "Playern";
    }
    public class Players
    {
        public string Name = "nameFU";//ник из FormU_3
        public string GameNomber = "Player";//порядковый номер игрока
        public int DopMoney = 0;//заработанные монеты
        public int Place = 0;//призовое место

    }
    public override void OnConnectedToMaster()// когда подключились к мастерсерверу
    {
        Debug.Log("Connected to Master");
    }
    public void jr()//подключение к комнате
    {
        PhotonNetwork.NickName = "Player2";
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("trying to join");
        Players Player2 = new Players();
        Player2.Name = FU.name;
        Player2.GameNomber = "Player2";
    }
    public override void OnJoinedRoom()// когда подключились
    {
        Debug.Log("Joined the room " + PhotonNetwork.NickName);
    }
    public void CreateRoom()// создание комнаты
    {
        PhotonNetwork.NickName = "Player1";
        PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions { MaxPlayers = 2 });
        Debug.Log("created");
        PhotonNetwork.LoadLevel("FIGHT_ONLINE");
        Players Player1 = new Players();
        Player1.Name = FU.name;
        Player1.GameNomber = "Player1";
    }
    public override void OnJoinRandomFailed(short returnCode, string message) //подключение не удалось
    {
        Debug.Log("failed; creating");
        {
            CreateRoom();
        }
    }
}

