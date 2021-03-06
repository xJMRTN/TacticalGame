using System.Collections.Generic;

public class Unit
{
    public enum UnitAction{
        Idle,
        Marching,
        Supressing,
        Attacking
    }

    public enum UnitState{
        Alive,
        Bailed,
        Dead
    }

    public enum UnitType{
        Infantry,
        Tank,
        Helicopter
    }

    private string UnitName;

    private int UnitAmount;
    private int UnitMaxDistance;
    private int UnitRemainingDistance;

    private List<Weapon> UnitWeapons = new List<Weapon>();

    private bool UnitCover;

    private UnitAction action;
    private UnitState state;
    private UnitType type;

    public Unit(string _unitName, int _unitAmount, int _unitMaxDistance, int _unitRemainingDistance){
        UnitName = _unitName;
        UnitAmount = _unitAmount;
        UnitMaxDistance = _unitMaxDistance;
        UnitRemainingDistance = _unitRemainingDistance;
    }
    
    public string GetUnitName(){
        return UnitName;
    }

    public UnitAction GetUnitAction(){
        return action;
    }

    public UnitState GetUnitState(){
        return state;
    }

    public UnitType GetUnitType(){
        return type;
    }

    public int GetUnitAmount(){
        return UnitAmount;
    }

    public void RemoveUnits(int amount){
        UnitAmount -= amount;
    }

    public int GetRemainingDistance(){
        return UnitRemainingDistance;
    }

    public void RemoveUnitDistance(int distance){
        UnitRemainingDistance -= distance;
    }

    public void ResetUnit(){
        UnitRemainingDistance = UnitMaxDistance;
    }

    public bool IsUnitInCover(){
        return UnitCover;
    }

    public void SetUnitCover(bool cover){
        UnitCover = cover;
    }
}