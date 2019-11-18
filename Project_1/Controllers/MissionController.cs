﻿using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    public class MissionController : Controller
    {
        public static List<Mission> lstMission = new List<Mission>();
        // GET: Mission
        public ActionResult MissionChoices()
        {
            var mission1 = new Mission();
            mission1.Mission_Code = 1;
            mission1.Mission_Name = "Fiji Suva Mission";
            mission1.Name_First_President = "John";
            mission1.Name_Last_President = "Higgins";
            mission1.Street_Address = "2-24 Lakeba Street";
            mission1.State = "Rewa";
            mission1.Country = "Fiji";
            mission1.Zip = "N/A";
            mission1.Main_Religion = "Methodist";
            mission1.Language = "Fijian";
            mission1.Climate = "Temperate";
            lstMission.Add(mission1);
            var mission2 = new Mission();
            mission2.Mission_Code = 2;
            mission2.Mission_Name = "Fiji Suva Mission";
            mission2.Name_First_President = "John";
            mission2.Name_Last_President = "Higgins";
            mission2.Street_Address = "2-24 Lakeba Street";
            mission2.State = "Rewa";
            mission2.Country = "Fiji";
            mission2.Zip = "N/A";
            mission2.Main_Religion = "Methodist";
            mission2.Language = "Fijian";
            mission2.Climate = "Temperate";
            lstMission.Add(mission2);
            var mission3 = new Mission();
            mission3.Mission_Code = 3;
            mission3.Mission_Name = "Dominican Republic Santo Domingo West Mission";
            mission3.Name_First_President = "Jim";
            mission3.Name_Last_President = "Nuckols";
            mission3.Street_Address = "C/ Hatuey # 73 Urb. Los Cacicazgos";
            mission3.State = "Santo Domingo";
            mission3.Country = "Dominican Republic";
            mission3.Zip = "N/A";
            mission3.Main_Religion = "Catholic";
            mission3.Language = "Dominican Spanish";
            mission3.Climate = "Hot and Tropical";
            lstMission.Add(mission3);
            ViewBag.Mission = lstMission;



            return View(lstMission);
        }
    }
}