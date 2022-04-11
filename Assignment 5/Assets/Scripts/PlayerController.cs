using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int _health;
    
    void Start()
    {
        _health = 5;
    }
    
    public void Hurt(int damage)
    {
        _health -= damage;
        print("Health: " + _health);
    }
    public void Heal(int energy)
    {
        _health += energy;
        print("Health: " + _health);
    }
}
