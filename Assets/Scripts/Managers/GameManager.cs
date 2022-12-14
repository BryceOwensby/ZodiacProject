using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        ChangeState(GameState.GenerateGrid);  
    }

    public void ChangeState(GameState newState)
    {

        State = newState;
        switch (newState)
        {
            case GameState.GenerateGrid:
                GridManager.Instance.GernateGrid();
                break;
            case GameState.SpawnHeroes:
                UnitManager.Instance.SpawnHeroes();
                break;
            case GameState.SpawnEnemies:
                UnitManager.Instance.SpawnEnemies();
                break;
            case GameState.HerosTurn:
                break;
            case GameState.EnemiesTurn:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }

public enum GameState 
{ 
    GenerateGrid = 0,
    SpawnHeroes = 1,
    SpawnEnemies = 2,
    HerosTurn = 3,
    EnemiesTurn = 4,
}

}