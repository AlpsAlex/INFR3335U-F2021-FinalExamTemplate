using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;
    public Text error;

    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(createInput.text))
            return;
        PhotonNetwork.CreateRoom(createInput.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public void Start()
    {
        if (createInput.text != null)
            CreateRoom();
        else if (joinInput.text != null)
            JoinRoom();
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Arena"); //**
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        error.text = message;
        Debug.Log("Error creating room! " + message);
    }

}
