using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using static InsuranceAnalytics;

[Serializable]
public class Report
{
    public string version = "0.0.6";
    public string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    public double epoch = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    public string eventKey;
    public string eventValue;
    public string userId;

    public int year;
    public static int currentMoney;
    public static int totalMoneySpent;
    public static int numLosses;
    public static int totalNumLosses;
    public static int losses;
    public static int totalLosses;
    public static int lossesCovered;
    public static int totalLossesCovered;
    public static int revenue;
    public static int totalRevenue;
    public static ArrayList buildingsPurchased;
    public static ArrayList buildTypePurchased;
    public static ArrayList insurancePurchased;
    public static ArrayList historyOfInsurancePurchased;


    public int building;

    public Report(string userId, string eventKey, string eventValue)
    {
        this.userId = userId;
        this.eventKey = eventKey;
        this.eventValue = eventValue;
    }
}

public static class InsuranceAnalytics
{
    private const string path = "UserLogs/userLogs.json";
    private static readonly StreamWriter Writer = new(path, true);

    public static void ReportEvent(string userId, string eventKey, string eventValue)
    {
        Writer.WriteLine(JsonUtility.ToJson(new Report(userId, eventKey, eventValue)));
        Writer.Flush();
    }
    
    public static void ReportPurchase(string userId, int pBuilding, int pYear)
    {
        var report = new Report(userId, "Add Building", "PlayerEvent")
        {
            building = pBuilding,
            year = pYear
        };
        Writer.WriteLine(JsonUtility.ToJson(report));
        Writer.Flush();
    }    


    
    public static void Close() => Writer.Close();
}