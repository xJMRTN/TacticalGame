using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    public List<Unit> units = new List<Unit>();

    private int UnitsRemaining;

    public void Start(){
        GetUnitsRemaining();
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
}