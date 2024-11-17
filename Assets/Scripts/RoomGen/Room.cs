using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    public GameObject room;
    public string[] doorways = new string[4];
    public bool hasDoors;

    public Room(GameObject room, string[] doorways)
    {
        this.room = room;
        this.doorways = doorways;
        hasDoors = false;
    }
}
