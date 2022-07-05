using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public sealed class GameController : MonoBehaviour
{
    private const int NumberOfPlayers = 2;

    private static GameController instance = new GameController();

    private List<UnitController> players = new List<UnitController>();

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

    public void Start(){
        CreatePlayers();
    }

    public void CreatePlayers(){
        for (int i = 0; i < NumberOfPlayers; i++)
        {
            UnitController newPlayer = new UnitController(i);         
            newPlayer.SetupPlayer(XMLReader.GetPlayerUnits(i));
            players.Add(newPlayer);
            newPlayer.DebugShowUnits();
        }
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