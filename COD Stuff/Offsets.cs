﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCUN
{
    class Offsets
    {  // dvar, fov, fps, fullbright, specular, movie, fog, glow, bullet, camo1, camo2, allies_feed, ennemies_feed
       public static int[,] All_FPS_Offsets = new int[,] 
        {
            { 0xC, 0x8C13D8, 0x146EEF8, 0xD560A7C, 0xD560A60, 0xD560984, 0xD560BF4, 0xD560A8C, 0x740644, 0xD560A78, 0x1, 0x565C80, 0x565E60}, // cod4 // lenght 13        // 0
            { 0xC, 0xAAC278, 0x1B907B0, 0x695DA48, 0x695DA2C, 0x695D918, 0x695DB98, 0x695DA50, 0x88E28C, 0x695DA44, 0x695D8E0, 0x1A85A30, 0x1B0E178 }, // mw2         // 1
            { 0xC, 0xB0C738, 0x1CF0B84, 0x5FC07C8, 0x5FC07A8, 0x5FC0698, 0x5FC091C, 0x5FC07D4, 0x8FC90C, 0x5FC07C4, 0x5FC0654, 0x8FC9D8, 0x8FC950}, //mw3 // get the fov for mw3 All_Offsets[2,1]        // 2
             { 0xC, 0xB0A7A8, 0x1CE77A4, 0x5F96B38, 0x5F96B18, 0x5F96A08, 0x5F96C8C, 0x5F96B44, 0x8FAA8C, 0x5F96B34, 0x5F969C4, 0x8FAAD0, 0x8FAB58}, // tekno MW3        // 3
            { 0x1, 0x1, 0x1, 0x1, 0x1, 0x1, 0x1, 0x1, 0x1, 0x1, 0x1, 0x1, 0x1}, //bo1         // 4
            { 0x18, 0x114227C, 0x25E45B0, 0x3455900, 0x3455890, 0x1, 0x34559B4, 0x1, 0x1 , 0x1, 0x1, 0x1, 0x1} // bo2         // 5 
           
        } ;


        // cod4MP  All_Offsets[0,X]
        // mw2MP All_Offsets[1,X]
        // mw3MP All_Offsets[2,X]

    }
}