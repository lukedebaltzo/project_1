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
        public static int Mission_Code_Count;
        // GET: Mission
        public ActionResult MissionChoices()
        {
            if (lstMission.Count == 0)
            {
            var mission1 = new Mission();
            mission1.Mission_Code = 1;
            mission1.Mission_Name = "Fiji Suva Mission";
            mission1.Name_First_President = "John";
            mission1.Name_Last_President = "Higgins";
            mission1.Street_Address = "2-24 Lakeba Street";
            mission1.City = "Suva";
            mission1.State = "Rewa";
            mission1.Country = "Fiji";
            mission1.Zip = "N/A";
            mission1.Main_Religion = "Methodist";
            mission1.Language = "Fijian";
            mission1.Climate = "Temperate";
            lstMission.Add(mission1);
            var mission2 = new Mission();
            mission2.Mission_Code = 2;
            mission2.Mission_Name = "Argentina Rosario Mission";
            mission2.Name_First_President = "Nicholas";
            mission2.Name_Last_President = "Zanni";
            mission2.Street_Address = "37 yawtah";
            mission2.City = "Chicharones";
            mission2.State = "Rosario";
            mission2.Country = "Argentina";
            mission2.Zip = "2000";
            mission2.Main_Religion = "Catholic";
            mission2.Language = "Castellano";
            mission2.Climate = "Cold";
            lstMission.Add(mission2);
            var mission3 = new Mission();
            mission3.Mission_Code = 3;
            mission3.Mission_Name = "Dominican Republic Santo Domingo West Mission";
            mission3.Name_First_President = "Jim";
            mission3.Name_Last_President = "Nuckols";
            mission3.Street_Address = "C/ Hatuey # 73";
            mission3.City = "Urb. Los Cacicazgos";
            mission3.State = "Santo Domingo";
            mission3.Country = "Dominican Republic";
            mission3.Zip = "N/A";
            mission3.Main_Religion = "Catholic";
            mission3.Language = "Dominican Spanish";
            mission3.Climate = "Hot and Tropical";
            lstMission.Add(mission3);
            var mission4 = new Mission();
            mission4.Mission_Code = 4;
            mission4.Mission_Name = "Portugal Porto Mission";
            mission4.Name_First_President = "Manoel";
            mission4.Name_Last_President = "Amorim";
            mission4.Street_Address = "Rua de Amália Luazes Nº 23 Sala I";
            mission4.City = "Porto";
            mission4.State = "N/A";
            mission4.Country = "Portugal";
            mission4.Zip = "4200-052";
            mission4.Main_Religion = "Catholic";
            mission4.Language = "Portuguese";
            mission4.Climate = "Moderate temperatures. Very rainy winter season.";
            lstMission.Add(mission4);
            ViewBag.Mission = lstMission;
            }
            return View();
        }

        public ActionResult MissionFAQ()
        {
            return View(lstMission.Where(x => x.Mission_Code == Mission_Code_Count));
        }

      





        public ActionResult FijiFAQ()
        {
            //ViewBag.FijiMission = lstMission.Find(p => p.Mission_Code == 1);
            Mission_Code_Count = 1;

            return RedirectToAction("MissionFAQ");
        }

        public ActionResult ArgentinaFAQ()
        {
            //ViewBag.FijiMission = lstMission.Find(p => p.Mission_Code == 1);
            Mission_Code_Count = 2;

            return RedirectToAction("MissionFAQ");
        }

        public ActionResult DominicanRepublicFAQ()
        {
            //ViewBag.FijiMission = lstMission.Find(p => p.Mission_Code == 1);
            Mission_Code_Count = 3;

            return RedirectToAction("MissionFAQ");
        }

        public ActionResult PortugalFAQ()
        {
            //ViewBag.FijiMission = lstMission.Find(p => p.Mission_Code == 1);
            Mission_Code_Count = 4;

            return RedirectToAction("MissionFAQ");
        }
    }
}