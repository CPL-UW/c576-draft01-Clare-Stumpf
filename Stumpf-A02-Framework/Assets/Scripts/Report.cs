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
    public Vector3Int[] board = null;
    public Vector3Int[] piece = null;
    public Vector3Int delta = Vector3Int.zero;
    public Report(string userId, string eventKey, string eventValue)
    {
        this.userId = userId;
        this.eventKey = eventKey;
        this.eventValue = eventValue;
    }
}

public static class InsuranceAnalytics
{
    private const string path = "Assets/Logs/userLog.json";
    private static readonly StreamWriter Writer = new(path, true);

    public static void ReportEvent(string userId, string eventKey, string eventValue)
    {
        Writer.WriteLine(JsonUtility.ToJson(new Report(userId, eventKey, eventValue)));
        Writer.Flush();
    }
    
    public static void ReportPurchase(string userId, Vector3Int pDelta, Vector3Int[] pBoard, Vector3Int[] pPiece)
    {
        var report = new Report(userId, "MOVE", "PlayerEvent")
        {
            delta = pDelta,
            board = pBoard,
            piece = pPiece
        };
        Writer.WriteLine(JsonUtility.ToJson(report));
        Writer.Flush();
    }
    
    public static void ReportResults(string userId, Vector3Int[] pBoard, Vector3Int[] pPiece)
    {
        var report = new Report(userId, "ROTATE", "PlayerEvent")
        {
            board = pBoard,
            piece = pPiece
        };
        Writer.WriteLine(JsonUtility.ToJson(report));
        Writer.Flush();
    }
    
    public static void ReportState(string userId, Vector3Int[] pBoard, Vector3Int[] pPiece)
    {
        var report = new Report(userId, "STATE", "KeyFrame")
        {
            board = pBoard,
            piece = pPiece
        };
        Writer.WriteLine(JsonUtility.ToJson(report));
        Writer.Flush();
    }
    
    public static void Close() => Writer.Close();
}