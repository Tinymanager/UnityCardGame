using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScript : MonoBehaviour
{
    public int[] HeldCards = new int[11];   //For the in-hand cards
    public GameObject[] InPlayCards = new GameObject[10]; //For the in-play cards

    public Vector3 positionPlH0;
    public Vector3 positionPlH1;
    public Vector3 positionPlH2;
    public Vector3 positionPlH3;
    public Vector3 positionPlH4;
    public Vector3 positionPlH5;
    public Vector3 positionPlH6;
    public Vector3 positionPlH7;
    public Vector3 positionPlH8;
    public Vector3 positionPlH9;

    public GameObject PlH0;
    public GameObject PlH1;
    public GameObject PlH2;
    public GameObject PlH3;
    public GameObject PlH4;
    public GameObject PlH5;
    public GameObject PlH6;
    public GameObject PlH7;
    public GameObject PlH8;
    public GameObject PlH9;

    public GameObject[] InPlayEnemies = new GameObject[10];

    // Start is called before the first frame update
    void Start()
    {
        GameObject appSc = GameObject.Find("__app");
        appSc.GetComponent<PlayerDeckCondition>().GamePlayGen();
        appSc.GetComponent<PlayerDeckCondition>().EnemyPresetSetup();
        CardPositionChecking();
    }
    // Update is called once per frame
    void Update()
    {
        CardPositionChecking();
    }

    //Need to make one of these for the enemies to finish combat
    public void CardPositionChecking()
    {
        //Setup for position checking  -------------------------------//
        PlH0 = GameObject.Find("Card Holder (0)");
        Transform PLH0T = PlH0.transform;
        positionPlH0 = PLH0T.position; //Used to reference the position of a card holder

        PlH1 = GameObject.Find("Card Holder (1)");
        Transform PLH1T = PlH1.transform;
        positionPlH1 = PLH1T.position;

        PlH2 = GameObject.Find("Card Holder (2)");
        Transform PLH2T = PlH2.transform;
        positionPlH2 = PLH2T.position;

        PlH3 = GameObject.Find("Card Holder (3)");
        Transform PLH3T = PlH3.transform;
        positionPlH3 = PLH3T.position;

        PlH4 = GameObject.Find("Card Holder (4)");
        Transform PLH4T = PlH4.transform;
        positionPlH4 = PLH4T.position;

        PlH5 = GameObject.Find("Card Holder (5)");
        Transform PLH5T = PlH5.transform;
        positionPlH5 = PLH5T.position;

        PlH6 = GameObject.Find("Card Holder (6)");
        Transform PLH6T = PlH6.transform;
        positionPlH6 = PLH6T.position;

        PlH7 = GameObject.Find("Card Holder (7)");
        Transform PLH7T = PlH7.transform;
        positionPlH7 = PLH7T.position;

        PlH8 = GameObject.Find("Card Holder (8)");
        Transform PLH8T = PlH8.transform;
        positionPlH8 = PLH8T.position;

        PlH9 = GameObject.Find("Card Holder (9)");
        Transform PLH9T = PlH9.transform;
        positionPlH9 = PLH9T.position;

        //Start of Position Checking ---------------------------------//
        LayerMask Cards = LayerMask.GetMask("Cards");

        Collider2D hit0 = Physics2D.OverlapPoint(positionPlH0, Cards);
        if (hit0 != null)   //hit returns the card in that holder
        {
            //Debug.Log(hit0.gameObject);
            InPlayCards[0] = hit0.gameObject;
            //Tells which card was put in the holder
        } else { InPlayCards[0] = null;}

        Collider2D hit1 = Physics2D.OverlapPoint(positionPlH1, Cards);
        if (hit1 != null)
        {
            //Debug.Log(hit1);
            InPlayCards[1] = hit1.gameObject;
        } else { InPlayCards[1] = null;}

        Collider2D hit2 = Physics2D.OverlapPoint(positionPlH2, Cards);
        if (hit2 != null)
        {
            //Debug.Log(hit2);
            InPlayCards[2] = hit2.gameObject;
        } else { InPlayCards[2] = null;}

        Collider2D hit3 = Physics2D.OverlapPoint(positionPlH3, Cards);
        if (hit3 != null)
        {
            //Debug.Log(hit3);
            InPlayCards[3] = hit3.gameObject;
        } else { InPlayCards[3] = null;}

        Collider2D hit4 = Physics2D.OverlapPoint(positionPlH4, Cards);
        if (hit4 != null)
        {
            //Debug.Log(hit4);
            InPlayCards[4] = hit4.gameObject;
        } else { InPlayCards[4] = null;}

        Collider2D hit5 = Physics2D.OverlapPoint(positionPlH5, Cards);
        if (hit5 != null)
        {
            //Debug.Log(hit5);
            InPlayCards[5] = hit5.gameObject;
        } else { InPlayCards[5] = null;}

        Collider2D hit6 = Physics2D.OverlapPoint(positionPlH6, Cards);
        if (hit6 != null)
        {
            //Debug.Log(hit6);
            InPlayCards[6] = hit6.gameObject;
        } else { InPlayCards[6] = null;}

        Collider2D hit7 = Physics2D.OverlapPoint(positionPlH7, Cards);
        if (hit7 != null)
        {
            //Debug.Log(hit7);
            InPlayCards[7] = hit7.gameObject;
        } else { InPlayCards[7] = null;}

        Collider2D hit8 = Physics2D.OverlapPoint(positionPlH8, Cards);
        if (hit8 != null)
        {
            //Debug.Log(hit8);
            InPlayCards[8] = hit8.gameObject;
        } else { InPlayCards[8] = null;}

        Collider2D hit9 = Physics2D.OverlapPoint(positionPlH9, Cards);
        if (hit9 != null)
        {
            //Debug.Log(hit9);
            InPlayCards[9] = hit9.gameObject;
        } else { InPlayCards[9] = null;}

    }

    public void CombatTurn()
    {
        //Debug.Log("Starting");
      /*GameObject ET0 = InPlayEnemies[0];
        GameObject ET1 = InPlayEnemies[1];
        GameObject ET2 = InPlayEnemies[2];
        GameObject ET3 = InPlayEnemies[3];
        GameObject ET4 = InPlayEnemies[4];
        GameObject EB0 = InPlayEnemies[5];
        GameObject EB1 = InPlayEnemies[6];
        GameObject EB2 = InPlayEnemies[7];
        GameObject EB3 = InPlayEnemies[8];
        GameObject EB4 = InPlayEnemies[9];

        GameObject PT0 = InPlayCards[4];
        GameObject PT1 = InPlayCards[3];
        GameObject PT2 = InPlayCards[2];
        GameObject PT3 = InPlayCards[1];
        GameObject PT4 = InPlayCards[0];
        GameObject PB0 = InPlayCards[9];
        GameObject PB1 = InPlayCards[8];
        GameObject PB2 = InPlayCards[7];
        GameObject PB3 = InPlayCards[6];
        GameObject PB4 = InPlayCards[5];*/

        GameObject[] TargetableTopCards = new GameObject[5];
        GameObject[] TargetableBottomCards = new GameObject[5];
        GameObject[] TargetableTopEnemys = new GameObject[5];
        GameObject[] TargetableBottomEnemys = new GameObject[5];
        

        //If the spots not empty the card is added to the new array
        for (int i=4; i>=0; i--)
        {
            int flipper = 0;
            if (i == 4) { flipper = 0; }
            else if (i == 3) { flipper = 1; }
            else if (i == 2) { flipper = 2; }
            else if (i == 1) { flipper = 3; }
            else if (i == 0) { flipper = 4; }
            if (InPlayCards[i] != null)
            {
                TargetableTopCards[flipper] = InPlayCards[i];
            }
        }
        
        for (int i = 9; i>=5; i--)
        {
            int flipper = 0;
            if (i == 9) { flipper = 0; }
            else if (i == 8) { flipper = 1; }
            else if (i == 7) { flipper = 2; }
            else if (i == 6) { flipper = 3; }
            else if (i == 5) { flipper = 4; }
            if (InPlayCards[i] != null)
            {
                TargetableBottomCards[flipper] = InPlayCards[i];
            }
        }

        for (int i=0; i<5; i++)
        {
            if (InPlayEnemies[i] != null)
            {
                TargetableTopEnemys[i] = InPlayEnemies[i];
            }
        }
        for (int i=5; i<10; i++)
        {
            int flipper = 0;
            if (i == 5) { flipper = 0; }
            else if (i == 6) { flipper = 1; }
            else if (i == 7) { flipper = 2; }
            else if (i == 8) { flipper = 3; }
            else if (i == 9) { flipper = 4; }
            if (InPlayEnemies[i] != null)
            {
                TargetableBottomEnemys[flipper] = InPlayEnemies[i];
            }
        }

        //Pull the first card from the top
        //Check if the enemy has a card in the top
        //Attack the first top enemy if there is one
        //Pull the rest of the top row cards, same process
        //Pull the first bottom card
        //Check and attack the first bottom enemy
        //If there are no enemies in their row, attack the other row

        //New Function here
        for (int i=0; i<TargetableTopCards.Length; i++)
        {
            if (TargetableTopCards[i] != null)
            {
                int Damage = TargetableTopCards[i].GetComponent<CardStats>().MeleeDamage;
                for (int j = 0; j < TargetableTopEnemys.Length; j++)
                {
                    if (TargetableTopEnemys[j] != null)
                    {
                        TargetableTopEnemys[j].GetComponent<EnemyStats0>().EHealthChange(-Damage);
                        break;
                    }
                    else if (TargetableBottomEnemys[j] != null)
                    {
                        TargetableBottomEnemys[j].GetComponent<EnemyStats0>().EHealthChange(-Damage);
                        break;
                    }
                }
               
            }
        }

        for (int i = 0; i < TargetableBottomCards.Length; i++)
        {
            if (TargetableBottomCards[i] != null)
            {
                int Damage = TargetableBottomCards[i].GetComponent<CardStats>().MeleeDamage;
                for (int j = 0; j < TargetableBottomEnemys.Length; j++)
                {
                    if (TargetableBottomEnemys[j] != null)
                    {
                        TargetableBottomEnemys[j].GetComponent<EnemyStats0>().EHealthChange(-Damage);
                        break;
                    }
                    else if (TargetableTopEnemys[j] != null)
                    {
                        TargetableTopEnemys[j].GetComponent<EnemyStats0>().EHealthChange(-Damage);
                        break;
                    }
                }

            }
        }

    //-------------------------------------------------------------------//
        for (int i = 0; i < TargetableTopEnemys.Length; i++)
        {
            if (TargetableTopEnemys[i] != null)
            {
                int Damage = TargetableTopEnemys[i].GetComponent<EnemyStats0>().MeleeDamage;
                for (int j = 0; j < TargetableTopCards.Length; j++)
                {
                    if (TargetableTopCards[j] != null)
                    {
                        TargetableTopCards[j].GetComponent<CardStats>().HealthChange(-Damage);
                        break;
                    }
                    else if (TargetableBottomCards[j] != null)
                    {
                        TargetableBottomCards[j].GetComponent<CardStats>().HealthChange(-Damage);
                        break;
                    }
                }

            }
        }

        for (int i = 0; i < TargetableBottomEnemys.Length; i++)
        {
            if (TargetableBottomEnemys[i] != null)
            {
                int Damage = TargetableBottomEnemys[i].GetComponent<EnemyStats0>().MeleeDamage;
                for (int j = 0; j < TargetableBottomCards.Length; j++)
                {
                    if (TargetableBottomCards[j] != null)
                    {
                        TargetableBottomCards[j].GetComponent<CardStats>().HealthChange(-Damage);
                        break;
                    }
                    else if (TargetableTopCards[j] != null)
                    {
                        TargetableTopCards[j].GetComponent<CardStats>().HealthChange(-Damage);
                        break;
                    }
                }
            }
        }
    }
}


//GameObject EActive = InPlayEnemies[i];
//int Damage = EActive.GetComponent<EnemyStats0>().MeleeDamage;


//int Damage = PT4.GetComponent<CardStats>().MeleeDamage;