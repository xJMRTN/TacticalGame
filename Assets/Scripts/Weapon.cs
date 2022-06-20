using System.Xml;
using UnityEngine; 

public class Weapon
{
    private string WeaponName;
    private string WeaponDescription;
    private int WeaponRange;
    private int HaltedROF;
    private int MovingROF;
    private int AntiTank;
    private int FirePower;

    public Weapon(string _weaponName, string _weaponDescription, int _weaponRange, int _haltedROF, int _movingRof, int _antiTank, int _firePower){
        WeaponName = _weaponName;
        WeaponDescription = _weaponDescription;
        WeaponRange = _weaponRange;
        HaltedROF = _haltedROF;
        MovingROF = _movingRof;
        AntiTank = _antiTank;
        FirePower = _firePower;
    }

    public Weapon(XmlNode weapon){
        XmlElement weaponElement = (XmlElement)weapon;

        WeaponName = weaponElement.GetAttributeNode("WeaponName").InnerXml;
        WeaponDescription = weaponElement.GetAttributeNode("WeaponDescription").InnerXml;
        WeaponRange = int.Parse(weaponElement.GetAttributeNode("WeaponRange").InnerXml);
        HaltedROF = int.Parse(weaponElement.GetAttributeNode("HaltedROF").InnerXml);
        MovingROF = int.Parse(weaponElement.GetAttributeNode("MovingROF").InnerXml);
        AntiTank = int.Parse(weaponElement.GetAttributeNode("AntiTank").InnerXml);
        FirePower = int.Parse(weaponElement.GetAttributeNode("FirePower").InnerXml);       

        DebugPrintWeapon();
    }

    public string GetWeaponName(){
        return WeaponName;
    }

    public string GetWeaponDescription(){
        return WeaponDescription;
    }

    public int GetWeaponRange(){
        return WeaponRange;
    }

    public int GetWeaponHaltedROF(){
        return HaltedROF;
    }

    public int GetWeaponMovingROF(){
        return MovingROF;
    }

    public int GetWeaponAntiTank(){
        return AntiTank;
    }

    public int GetWeaponFirePower(){
        return FirePower;
    }

    public void DebugPrintWeapon(){
        Debug.Log("Weapon Name: " + WeaponName + "| Weapon Description: " + WeaponDescription + "| Weapon Range: " + WeaponRange
        + "| Weapon Halted ROF: " + HaltedROF + "| Weapon Moving ROF: " + MovingROF + "| Weapon Anti Tank: " + AntiTank + "| Weapon Fire Power: " + FirePower);
    }
}