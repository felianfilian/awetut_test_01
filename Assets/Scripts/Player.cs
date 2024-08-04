using UnityEditor;
using UnityEngine;


public class Player
{
    int health;
    string name;
    public Player(int health, string name)
    {
        this.health = health;
        this.name = name;
        Debug.Log("Player created");
    }

    public void ShowInfo()
    {
        Debug.Log(health);
        Debug.Log(name);
    }
}