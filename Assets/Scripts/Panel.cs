using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public GameObject room;
    public GameObject menu;
    public void togglePanel()
    {
        bool isActiveRoom = room.activeSelf;
        bool isActiveMenu = menu.activeSelf;
        room.SetActive(!isActiveRoom);
        menu.SetActive(!isActiveMenu);
    }
}
