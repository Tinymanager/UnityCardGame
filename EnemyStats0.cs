using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats0 : MonoBehaviour
{
    public int Health = 10;
    public int Mana = 2;
    public int MeleeDamage = 4;
    public int RangeDamage = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EStatSetup(int health, int mana, int mDMG, int rDMG)
    {
        Health = health;
        Mana = mana;
        MeleeDamage = mDMG;
        RangeDamage = rDMG;
    }

    public void EHealthChange(int change)
    {
        Health = Health + change;
        if (Health > 0)
        {
            Debug.Log("Enemy Health is now at: " + Health);
        }
        else
        {
            Destroy(gameObject);
        }        

    }

}
