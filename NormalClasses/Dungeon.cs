using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dungeon 
{
    private string name;
    private Room startRoom;

    public Dungeon(string name)
    {
        this.name = name;
    }

    public void setStartRoom(Room r)
    {
        this.startRoom= startRoom;
    }



}
