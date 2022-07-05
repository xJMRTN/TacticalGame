using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    private List<Unit> units = new List<Unit>();
    private int UnitsRemaining;
    private int PlayerIndex;

    public UnitController(int _playerIndex){
        PlayerIndex = _playerIndex;
    }

    public void DebugShowUnits(){
        Debug.Log("----------- Player " + PlayerIndex + " has " + units.Count + " units -----------");

        foreach(Unit u in units){
            Debug.Log(u.GetUnitName());
        }
    }

    public int GetUnitsRemaining(){
        int remaining = 0;
        foreach(Unit u in units){
            if(u.GetUnitState() != Unit.UnitState.Dead) remaining++;
        }
        return remaining;
    }

    public bool HasPlayerDied(){
        return UnitsRemaining <= 0;
    }

    public void SetupPlayer(List<Unit> _units){
        units = _units;
    }
}