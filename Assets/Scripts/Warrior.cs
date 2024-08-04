using UnityEditor;
using UnityEngine;

class Warrior : Player
{
    public Warrior(int _health, string _name)
    {
        health = _health;
        Name = _name;
    }
}