﻿using System;
using System.Collections.Generic;
using System.Text;
using BL.Models;
namespace BL.Interfaces
{

    public interface IRoomsService
    {
        string CheckGameState(string playername);
        RoomsList GetInfoRooms(string playername);
        string[] CreateRoom(string roomName, string playername);
        string[] EnterTheRoom(string roomname, string playername);
    }
}