﻿using UnityEditor;
using UnityEngine;


public class Player
{
    public int health { get; set; }
    string name;

    public Player() { }

    public Player(int health, string name)
    {
        this.health = health;
        this.name = name;
        Debug.Log("Player created");
    }

    public void ShowInfo()
    {
        Debug.Log("Health: " + health + " - Name: " + name);
    }
}