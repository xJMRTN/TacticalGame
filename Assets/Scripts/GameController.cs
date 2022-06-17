using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public sealed class GameController : MonoBehaviour
{
    public static GameController instance = new GameController();
    public List<UnitController> players = new List<UnitController>();

    void Awake(){
        if(instance == null) {
            instance = this;         
        }       
    }

    static GameController(){   
    }

    private GameController(){       
    }

    public static GameController Instance{
        get{return instance;}
    }

    public void EndRound(){
       CheckForWinner();
    }

    public void CheckForWinner(){
        UnitController winner = null;
        bool winnerFound = false;
        foreach(UnitController player in players){
            if(player.HasPlayerDied() != false){
                if(winnerFound == true) return;
                winnerFound = true;
                winner = player;
            } 
        }  

        EndGame(winner);
    }

    public void EndGame(UnitController winner){

    }
}   