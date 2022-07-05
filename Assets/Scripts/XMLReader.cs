using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using UnityEngine;

public static class XMLReader
{
    public static void LoadWeapons(){
        XmlNodeList weaponNodeList = GetNodeList("XML/Weapons.xml", "WEAPON"); 
        CreateWeapons(weaponNodeList);
    }

    private static XmlNodeList GetNodeList(string path, string nodeName){
        XmlDocument doc = new XmlDocument();
        doc.Load(Path.Combine(Application.dataPath, path));
        XmlNode root = doc.DocumentElement;
        return root.SelectNodes(nodeName);
    } 

    private static void CreateWeapons(XmlNodeList weapons){
        foreach(XmlNode weapon in weapons){
            Weapon newWeapon = new Weapon(weapon);
        }
    }    

    public static List<Unit> GetPlayerUnits(int playerIndex){
        int randomNumber = Random.Range(1, 20);
        List<Unit> playerUnits = new List<Unit>();
        for (int i = 0; i < randomNumber; i++)
        {
            Unit newUnit = new Unit("Unit " + playerIndex + " " + i, 2, 34, 4);
            playerUnits.Add(newUnit);
        }
      
        return playerUnits;
    }
}