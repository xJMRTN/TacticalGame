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
}