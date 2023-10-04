using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeckCondition : MonoBehaviour
{
    public Sprite[] CardSprites;
    public Sprite[] EnemySprites;

    public int[] PlayerDeck = new int[48];

    public int[] EnemyPresets = { 0, 1, 2, 3 };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            LayerMask StartingDeckDrawButton = LayerMask.GetMask("StartingDeckDrawButton");

            Collider2D hit0 = Physics2D.OverlapPoint(mousePos, StartingDeckDrawButton);
            if (hit0 != null)
            {
                Debug.Log("Y");
                StartingDeckDisplay();
            }
        }
    }

    public void StartingDeckDisplay()
    {
        for (int i = 0; i < 12; i++)
        {
            int RandomVal = Random.Range(1, 101);
            if (RandomVal >= 1 & RandomVal < 13) //12
            {
                Debug.Log("2");
                PlayerDeck[i] = 2;
            } if (RandomVal >= 13 & RandomVal < 25){ //12
                Debug.Log("3");
                PlayerDeck[i] = 3;
            } if (RandomVal >= 25 & RandomVal < 37){ //12
                Debug.Log("4");
                PlayerDeck[i] = 4;
            } if (RandomVal >= 37 & RandomVal < 47){ //10
                Debug.Log("5");
                PlayerDeck[i] = 5;
            } if (RandomVal >= 47 & RandomVal < 57){ //10
                Debug.Log("6");
                PlayerDeck[i] = 6;
            } if (RandomVal >= 57 & RandomVal < 67){ //10
                Debug.Log("7");
                PlayerDeck[i] = 7;
            } if (RandomVal >= 67 & RandomVal < 75){ //8
                Debug.Log("8");
                PlayerDeck[i] = 8;
            } if (RandomVal >= 75 & RandomVal < 83){ //8
                Debug.Log("9");
                PlayerDeck[i] = 9;
            } if (RandomVal >= 83 & RandomVal < 90){ //7
                Debug.Log("Jack");
                PlayerDeck[i] = 10;
            } if (RandomVal >= 90 & RandomVal < 95){ //5
                Debug.Log("Queen");
                PlayerDeck[i] = 11;
            } if (RandomVal >= 95 & RandomVal < 100){ //5
                Debug.Log("King");
                PlayerDeck[i] = 12;
            }
        }
        CardGenerator();
    }

    public Sprite Card2B2;
    public Sprite Card2B3;
    public Sprite Card2B4;
    public Sprite Card2B5;
    public Sprite Card2B6;
    public Sprite Card2B7;
    public Sprite Card2B8;
    public Sprite Card2B9;
    public Sprite Card2B10;
    public Sprite Card2B11;
    public Sprite Card2B12;
    public Sprite Card2B13;

    public void CardGenerator()
    {
        GameObject PlH0 = GameObject.Find("Card Holder (0)");
        Transform PLH0T = PlH0.transform;
        Vector3 positionPlH0 = PLH0T.position;

        GameObject PlH1 = GameObject.Find("Card Holder (1)");
        Transform PLH1T = PlH1.transform;
        Vector3 positionPlH1 = PLH1T.position;

        GameObject PlH2 = GameObject.Find("Card Holder (2)");
        Transform PLH2T = PlH2.transform;
        Vector3 positionPlH2 = PLH2T.position;

        GameObject PlH3 = GameObject.Find("Card Holder (3)");
        Transform PLH3T = PlH3.transform;
        Vector3 positionPlH3 = PLH3T.position;

        GameObject PlH4 = GameObject.Find("Card Holder (4)");
        Transform PLH4T = PlH4.transform;
        Vector3 positionPlH4 = PLH4T.position;

        GameObject PlH5 = GameObject.Find("Card Holder (5)");
        Transform PLH5T = PlH5.transform;
        Vector3 positionPlH5 = PLH5T.position;

        GameObject PlH6 = GameObject.Find("Card Holder (6)");
        Transform PLH6T = PlH6.transform;
        Vector3 positionPlH6 = PLH6T.position;

        GameObject PlH7 = GameObject.Find("Card Holder (7)");
        Transform PLH7T = PlH7.transform;
        Vector3 positionPlH7 = PLH7T.position;

        GameObject PlH8 = GameObject.Find("Card Holder (8)");
        Transform PLH8T = PlH8.transform;
        Vector3 positionPlH8 = PLH8T.position;

        GameObject PlH9 = GameObject.Find("Card Holder (9)");
        Transform PLH9T = PlH9.transform;
        Vector3 positionPlH9 = PLH9T.position;

        GameObject PlH10 = GameObject.Find("Card Holder (10)");
        Transform PLH10T = PlH10.transform;
        Vector3 positionPlH10 = PLH10T.position;

        GameObject PlH11 = GameObject.Find("Card Holder (11)");
        Transform PLH11T = PlH11.transform;
        Vector3 positionPlH11 = PLH11T.position;
        //create a gameObject
        //Assign it a sprite based on which card its supposed to be
        //Assign it a boxcollider2D
        //Assign it the clickandDrag script
        //Assign it a health/damage script
        //Assign its position to the correct holder based on its place in the deck

        for (int i=0; i<PlayerDeck.Length; i++)
        {
            Vector3 CardPositioning;
            CardPositioning = new Vector3(0, 0, 0);
            if (i == 0)
            {
                CardPositioning = positionPlH0;
            } 
            else if (i == 1)
            {
                CardPositioning = positionPlH1;
            }
            else if (i == 2)
            {
                CardPositioning = positionPlH2;
            }
            else if (i == 3)
            {
                CardPositioning = positionPlH3;
            }
            else if (i == 4)
            {
                CardPositioning = positionPlH4;
            }
            else if (i == 5)
            {
                CardPositioning = positionPlH5;
            }
            else if (i == 6)
            {
                CardPositioning = positionPlH6;
            }
            else if (i == 7)
            {
                CardPositioning = positionPlH7;
            }
            else if (i == 8)
            {
                CardPositioning = positionPlH8;
            }
            else if (i == 9)
            {
                CardPositioning = positionPlH9;
            }
            else if (i == 10)
            {
                CardPositioning = positionPlH10;
            }
            else if (i == 11)
            {
                CardPositioning = positionPlH11;
            }

//-----------------------------------------------------------------------//

            if (PlayerDeck[i] == 2)
            {
                GameObject PCard2 = new GameObject();
                PCard2.name = "PCard2";
                PCard2.AddComponent<BoxCollider2D>();
                PCard2.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard2.AddComponent<CardStats>();  //Needs setup for each card type
                PCard2.AddComponent<ClickAndDrag>();
                PCard2.layer = 9;

                PCard2.AddComponent<SpriteRenderer>();
                PCard2.GetComponent<SpriteRenderer>().sprite = Card2B2;
                PCard2.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");

                PCard2.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard2.transform.position = CardPositioning;
            } else if (PlayerDeck[i] == 3)
            {
                GameObject PCard3 = new GameObject();
                PCard3.name = "PCard3";
                PCard3.AddComponent<BoxCollider2D>();
                PCard3.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard3.AddComponent<CardStats>(); 
                PCard3.AddComponent<ClickAndDrag>();
                PCard3.layer = 9;
                PCard3.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard3.transform.position = CardPositioning;

                PCard3.AddComponent<SpriteRenderer>();
                PCard3.GetComponent<SpriteRenderer>().sprite = Card2B3;
                PCard3.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
            } else if (PlayerDeck[i] == 4)
            {
                GameObject PCard4 = new GameObject();
                PCard4.name = "PCard4";
                PCard4.AddComponent<BoxCollider2D>();
                PCard4.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard4.AddComponent<CardStats>();
                PCard4.AddComponent<ClickAndDrag>();
                PCard4.layer = 9;
                PCard4.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard4.transform.position = CardPositioning;

                PCard4.AddComponent<SpriteRenderer>();
                PCard4.GetComponent<SpriteRenderer>().sprite = Card2B4;
                PCard4.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
            } else if (PlayerDeck[i] == 5)
            {
                GameObject PCard5 = new GameObject();
                PCard5.name = "PCard5";
                PCard5.AddComponent<BoxCollider2D>();
                PCard5.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard5.AddComponent<CardStats>();
                PCard5.AddComponent<ClickAndDrag>();
                PCard5.layer = 9;
                PCard5.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard5.transform.position = CardPositioning;

                PCard5.AddComponent<SpriteRenderer>();
                PCard5.GetComponent<SpriteRenderer>().sprite = Card2B5;
                PCard5.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
            } else if (PlayerDeck[i] == 6)
            {
                GameObject PCard6 = new GameObject();
                PCard6.name = "PCard6";
                PCard6.AddComponent<BoxCollider2D>();
                PCard6.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard6.AddComponent<CardStats>();
                PCard6.AddComponent<ClickAndDrag>();
                PCard6.layer = 9;
                PCard6.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard6.transform.position = CardPositioning;

                PCard6.AddComponent<SpriteRenderer>();
                PCard6.GetComponent<SpriteRenderer>().sprite = Card2B6;
                PCard6.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
            } else if (PlayerDeck[i] == 7)
            {
                GameObject PCard7 = new GameObject();
                PCard7.name = "PCard7";
                PCard7.AddComponent<BoxCollider2D>();
                PCard7.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard7.AddComponent<CardStats>();
                PCard7.AddComponent<ClickAndDrag>();
                PCard7.layer = 9;
                PCard7.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard7.transform.position = CardPositioning;

                PCard7.AddComponent<SpriteRenderer>();
                PCard7.GetComponent<SpriteRenderer>().sprite = Card2B7;
                PCard7.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
            } else if (PlayerDeck[i] == 8)
            {
                GameObject PCard8 = new GameObject();
                PCard8.name = "PCard8";
                PCard8.AddComponent<BoxCollider2D>();
                PCard8.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard8.AddComponent<CardStats>();
                PCard8.AddComponent<ClickAndDrag>();
                PCard8.layer = 9;
                PCard8.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard8.transform.position = CardPositioning;

                PCard8.AddComponent<SpriteRenderer>();
                PCard8.GetComponent<SpriteRenderer>().sprite = Card2B8;
                PCard8.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
            } else if (PlayerDeck[i] == 9)
            {
                GameObject PCard9 = new GameObject();
                PCard9.name = "PCard9";
                PCard9.AddComponent<BoxCollider2D>();
                PCard9.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard9.AddComponent<CardStats>();
                PCard9.AddComponent<ClickAndDrag>();
                PCard9.layer = 9;
                PCard9.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard9.transform.position = CardPositioning;

                PCard9.AddComponent<SpriteRenderer>();
                PCard9.GetComponent<SpriteRenderer>().sprite = Card2B9;
                PCard9.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
            } else if (PlayerDeck[i] == 10)
            {
                GameObject PCard10 = new GameObject();
                PCard10.name = "PCard10";
                PCard10.AddComponent<BoxCollider2D>();
                PCard10.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard10.AddComponent<CardStats>();
                PCard10.AddComponent<ClickAndDrag>();
                PCard10.layer = 9;
                PCard10.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard10.transform.position = CardPositioning;

                PCard10.AddComponent<SpriteRenderer>();
                PCard10.GetComponent<SpriteRenderer>().sprite = Card2B10;
                PCard10.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
            } else if (PlayerDeck[i] == 11)
            {
                GameObject PCard11 = new GameObject();
                PCard11.name = "PCard11";
                PCard11.AddComponent<BoxCollider2D>();
                PCard11.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard11.AddComponent<CardStats>();
                PCard11.AddComponent<ClickAndDrag>();
                PCard11.layer = 9;
                PCard11.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard11.transform.position = CardPositioning;

                PCard11.AddComponent<SpriteRenderer>();
                PCard11.GetComponent<SpriteRenderer>().sprite = Card2B11;
                PCard11.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
            } else if (PlayerDeck[i] == 12)
            {
                GameObject PCard12 = new GameObject();
                PCard12.name = "PCard12";
                PCard12.AddComponent<BoxCollider2D>();
                PCard12.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

                PCard12.AddComponent<CardStats>();
                PCard12.AddComponent<ClickAndDrag>();
                PCard12.layer = 9;
                PCard12.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
                PCard12.transform.position = CardPositioning;

                PCard12.AddComponent<SpriteRenderer>();
                PCard12.GetComponent<SpriteRenderer>().sprite = Card2B12;
                PCard12.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
            } else
            {
                //Debug.Log("N");
            }

        }
    }

    public void GamePlayGen()
    {
        //Debug.Log("Working");
        GameObject PlH0 = GameObject.Find("Start Holder (0)");
        Transform PLH0T = PlH0.transform;
        Vector3 positionPlH0 = PLH0T.position;

        GameObject PlH1 = GameObject.Find("Start Holder (1)");
        Transform PLH1T = PlH1.transform;
        Vector3 positionPlH1 = PLH1T.position;

        GameObject PlH2 = GameObject.Find("Start Holder (2)");
        Transform PLH2T = PlH2.transform;
        Vector3 positionPlH2 = PLH2T.position;

        GameObject PlH3 = GameObject.Find("Start Holder (3)");
        Transform PLH3T = PlH3.transform;
        Vector3 positionPlH3 = PLH3T.position;

        GameObject PlH4 = GameObject.Find("Start Holder (4)");
        Transform PLH4T = PlH4.transform;
        Vector3 positionPlH4 = PLH4T.position;

        GameObject PlH5 = GameObject.Find("Start Holder (5)");
        Transform PLH5T = PlH5.transform;
        Vector3 positionPlH5 = PLH5T.position;

        GameObject PlH6 = GameObject.Find("Start Holder (6)");
        Transform PLH6T = PlH6.transform;
        Vector3 positionPlH6 = PLH6T.position;

        GameObject PlH7 = GameObject.Find("Start Holder (7)");
        Transform PLH7T = PlH7.transform;
        Vector3 positionPlH7 = PLH7T.position;

        GameObject PlH8 = GameObject.Find("Start Holder (8)");
        Transform PLH8T = PlH8.transform;
        Vector3 positionPlH8 = PLH8T.position;

        GameObject PlH9 = GameObject.Find("Start Holder (9)");
        Transform PLH9T = PlH9.transform;
        Vector3 positionPlH9 = PLH9T.position;

        GameObject PlH10 = GameObject.Find("Start Holder (10)");
        Transform PLH10T = PlH10.transform;
        Vector3 positionPlH10 = PLH10T.position;

        TurnBasedGen(positionPlH0, positionPlH1, positionPlH2, positionPlH3, positionPlH4, positionPlH5, positionPlH6, positionPlH7, positionPlH8, positionPlH9, positionPlH10);
    }


    int TurnGenCounter = 0;
    public void TurnBasedGen(Vector3 positionPlH0, Vector3 positionPlH1, Vector3 positionPlH2, Vector3 positionPlH3, Vector3 positionPlH4, Vector3 positionPlH5, Vector3 positionPlH6, Vector3 positionPlH7, Vector3 positionPlH8, Vector3 positionPlH9, Vector3 positionPlH10)
    {
        Vector3 cardPositioning;
        cardPositioning = new Vector3(0, 0, 0);
        if (TurnGenCounter == 0)
        {
            cardPositioning = positionPlH0;
        }
        else if (TurnGenCounter == 1)
        {
            cardPositioning = positionPlH1;
        }
        else if (TurnGenCounter == 2)
        {
            cardPositioning = positionPlH2;
        }
        else if (TurnGenCounter == 3)
        {
            cardPositioning = positionPlH3;
        }
        else if (TurnGenCounter == 4)
        {
            cardPositioning = positionPlH4;
        }
        else if (TurnGenCounter == 5)
        {
            cardPositioning = positionPlH5;
        }
        else if (TurnGenCounter == 6)
        {
            cardPositioning = positionPlH6;
        }
        else if (TurnGenCounter == 7)
        {
            cardPositioning = positionPlH7;
        }
        else if (TurnGenCounter == 8)
        {
            cardPositioning = positionPlH8;
        }
        else if (TurnGenCounter == 9)
        {
            cardPositioning = positionPlH9;
        }
        else if (TurnGenCounter == 10)
        {
            cardPositioning = positionPlH10;
        }

 //---------------------------------------------------------------------//


        if (PlayerDeck[TurnGenCounter] == 2)
        {
            GameObject PCard2 = new GameObject();
            PCard2.name = "PCard2";
            PCard2.AddComponent<BoxCollider2D>();
            PCard2.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard2.AddComponent<CardStats>();
            PCard2.GetComponent<CardStats>().CardStatSetup(10, 0, 4, 4);//

            PCard2.AddComponent<ClickAndDrag>();
            PCard2.layer = 9;

            PCard2.AddComponent<SpriteRenderer>();
            PCard2.GetComponent<SpriteRenderer>().sprite = Card2B2;
            PCard2.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");

            PCard2.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard2.transform.position = cardPositioning;
        }
        else if (PlayerDeck[TurnGenCounter] == 3)
        {
            GameObject PCard3 = new GameObject();
            PCard3.name = "PCard3";
            PCard3.AddComponent<BoxCollider2D>();
            PCard3.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard3.AddComponent<CardStats>();
            PCard3.GetComponent<CardStats>().CardStatSetup(14, 0, 7, 0);//

            PCard3.AddComponent<ClickAndDrag>();
            PCard3.layer = 9;
            PCard3.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard3.transform.position = cardPositioning;

            PCard3.AddComponent<SpriteRenderer>();
            PCard3.GetComponent<SpriteRenderer>().sprite = Card2B3;
            PCard3.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        }
        else if (PlayerDeck[TurnGenCounter] == 4)
        {
            GameObject PCard4 = new GameObject();
            PCard4.name = "PCard4";
            PCard4.AddComponent<BoxCollider2D>();
            PCard4.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard4.AddComponent<CardStats>();
            PCard4.GetComponent<CardStats>().CardStatSetup(12, 4, 3, 6);//

            PCard4.AddComponent<ClickAndDrag>();
            PCard4.layer = 9;
            PCard4.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard4.transform.position = cardPositioning;

            PCard4.AddComponent<SpriteRenderer>();
            PCard4.GetComponent<SpriteRenderer>().sprite = Card2B4;
            PCard4.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        }
        else if (PlayerDeck[TurnGenCounter] == 5)
        {
            GameObject PCard5 = new GameObject();
            PCard5.name = "PCard5";
            PCard5.AddComponent<BoxCollider2D>();
            PCard5.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard5.AddComponent<CardStats>();
            PCard5.GetComponent<CardStats>().CardStatSetup(15, 0, 8, 0);//

            PCard5.AddComponent<ClickAndDrag>();
            PCard5.layer = 9;
            PCard5.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard5.transform.position = cardPositioning;

            PCard5.AddComponent<SpriteRenderer>();
            PCard5.GetComponent<SpriteRenderer>().sprite = Card2B5;
            PCard5.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        }
        else if (PlayerDeck[TurnGenCounter] == 6)
        {
            GameObject PCard6 = new GameObject();
            PCard6.name = "PCard6";
            PCard6.AddComponent<BoxCollider2D>();
            PCard6.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard6.AddComponent<CardStats>();
            PCard6.GetComponent<CardStats>().CardStatSetup(15, 0, 8, 0);//Gets 2 turns

            PCard6.AddComponent<ClickAndDrag>();
            PCard6.layer = 9;
            PCard6.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard6.transform.position = cardPositioning;

            PCard6.AddComponent<SpriteRenderer>();
            PCard6.GetComponent<SpriteRenderer>().sprite = Card2B6;
            PCard6.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        }
        else if (PlayerDeck[TurnGenCounter] == 7)
        {
            GameObject PCard7 = new GameObject();
            PCard7.name = "PCard7";
            PCard7.AddComponent<BoxCollider2D>();
            PCard7.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard7.AddComponent<CardStats>();
            PCard7.GetComponent<CardStats>().CardStatSetup(18, 0, 13, 0);//

            PCard7.AddComponent<ClickAndDrag>();
            PCard7.layer = 9;
            PCard7.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard7.transform.position = cardPositioning;

            PCard7.AddComponent<SpriteRenderer>();
            PCard7.GetComponent<SpriteRenderer>().sprite = Card2B7;
            PCard7.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        }
        else if (PlayerDeck[TurnGenCounter] == 8)
        {
            GameObject PCard8 = new GameObject();
            PCard8.name = "PCard8";
            PCard8.AddComponent<BoxCollider2D>();
            PCard8.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard8.AddComponent<CardStats>();
            PCard8.GetComponent<CardStats>().CardStatSetup(16, 8, 2, 0);//Drains life when attacking

            PCard8.AddComponent<ClickAndDrag>();
            PCard8.layer = 9;
            PCard8.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard8.transform.position = cardPositioning;

            PCard8.AddComponent<SpriteRenderer>();
            PCard8.GetComponent<SpriteRenderer>().sprite = Card2B8;
            PCard8.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        }
        else if (PlayerDeck[TurnGenCounter] == 9)
        {
            GameObject PCard9 = new GameObject();
            PCard9.name = "PCard9";
            PCard9.AddComponent<BoxCollider2D>();
            PCard9.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard9.AddComponent<CardStats>();
            PCard9.GetComponent<CardStats>().CardStatSetup(12, 10, 6, 6);//

            PCard9.AddComponent<ClickAndDrag>();
            PCard9.layer = 9;
            PCard9.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard9.transform.position = cardPositioning;

            PCard9.AddComponent<SpriteRenderer>();
            PCard9.GetComponent<SpriteRenderer>().sprite = Card2B9;
            PCard9.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        }
        else if (PlayerDeck[TurnGenCounter] == 10)
        {
            GameObject PCard10 = new GameObject();
            PCard10.name = "PCard10";
            PCard10.AddComponent<BoxCollider2D>();
            PCard10.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard10.AddComponent<CardStats>();
            PCard10.GetComponent<CardStats>().CardStatSetup(18, 10, 5, 9);//

            PCard10.AddComponent<ClickAndDrag>();
            PCard10.layer = 9;
            PCard10.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard10.transform.position = cardPositioning;

            PCard10.AddComponent<SpriteRenderer>();
            PCard10.GetComponent<SpriteRenderer>().sprite = Card2B10;
            PCard10.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        }
        else if (PlayerDeck[TurnGenCounter] == 11)
        {
            GameObject PCard11 = new GameObject();
            PCard11.name = "PCard11";
            PCard11.AddComponent<BoxCollider2D>();
            PCard11.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard11.AddComponent<CardStats>();
            PCard11.GetComponent<CardStats>().CardStatSetup(20, 6, 10, 0);//

            PCard11.AddComponent<ClickAndDrag>();
            PCard11.layer = 9;
            PCard11.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard11.transform.position = cardPositioning;

            PCard11.AddComponent<SpriteRenderer>();
            PCard11.GetComponent<SpriteRenderer>().sprite = Card2B11;
            PCard11.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        }
        else if (PlayerDeck[TurnGenCounter] == 12)
        {
            GameObject PCard12 = new GameObject();
            PCard12.name = "PCard12";
            PCard12.AddComponent<BoxCollider2D>();
            PCard12.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            PCard12.AddComponent<CardStats>();
            PCard12.GetComponent<CardStats>().CardStatSetup(18, 8, 10, 0);//
            PCard12.AddComponent<ClickAndDrag>();
            PCard12.layer = 9;
            PCard12.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            PCard12.transform.position = cardPositioning;

            PCard12.AddComponent<SpriteRenderer>();
            PCard12.GetComponent<SpriteRenderer>().sprite = Card2B12;
            PCard12.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        }
        else
        {
            //Debug.Log("N");
        }

        TurnGenCounter++;
        //Debug.Log(TurnGenCounter);
    }

    //int EnemySpawnCounter = 0;
    //New function goes here
    public void EnemyPresetSetup()
    {
        EnemyGen(EnemyPresets[0]);
    }

    public void EnemyGen(int EPresetT)
    {
        int EPreset = EPresetT;
        //Debug.Log("Working");
        GameObject EH0 = GameObject.Find("Card Holder (E0)");
        Transform EH0T = EH0.transform;
        Vector3 positionEH0 = EH0T.position;

        GameObject EH1 = GameObject.Find("Card Holder (E1)");
        Transform EH1T = EH1.transform;
        Vector3 positionEH1 = EH1T.position;

        GameObject EH2 = GameObject.Find("Card Holder (E2)");
        Transform EH2T = EH2.transform;
        Vector3 positionEH2 = EH2T.position;

        GameObject EH3 = GameObject.Find("Card Holder (E3)");
        Transform EH3T = EH3.transform;
        Vector3 positionEH3 = EH3T.position;

        GameObject EH4 = GameObject.Find("Card Holder (E4)");
        Transform EH4T = EH4.transform;
        Vector3 positionEH4 = EH4T.position;

        GameObject EH5 = GameObject.Find("Card Holder (E5)");
        Transform EH5T = EH5.transform;
        Vector3 positionEH5 = EH5T.position;

        GameObject EH6 = GameObject.Find("Card Holder (E6)");
        Transform EH6T = EH6.transform;
        Vector3 positionEH6 = EH6T.position;

        GameObject EH7 = GameObject.Find("Card Holder (E7)");
        Transform EH7T = EH7.transform;
        Vector3 positionEH7 = EH7T.position;

        GameObject EH8 = GameObject.Find("Card Holder (E8)");
        Transform EH8T = EH8.transform;
        Vector3 positionEH8 = EH8T.position;

        GameObject EH9 = GameObject.Find("Card Holder (E9)");
        Transform EH9T = EH9.transform;
        Vector3 positionEH9 = EH9T.position;

    //-------------------------------------------------------------------//

        if (EPreset == 0)
        {
            GameObject battleSc = GameObject.Find("GamePlay");

            GameObject ECard2 = new GameObject();
            ECard2.name = "ECard2";
            ECard2.AddComponent<BoxCollider2D>();
            ECard2.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            ECard2.AddComponent<EnemyStats0>();  
            ECard2.GetComponent<EnemyStats0>().EStatSetup(10, 0, 4, 0);
            ECard2.layer = 9;

            ECard2.AddComponent<SpriteRenderer>();
            ECard2.GetComponent<SpriteRenderer>().sprite = EnemySprites[0];
            ECard2.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");

            ECard2.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            ECard2.transform.position = positionEH0;
            battleSc.GetComponent<BattleScript>().InPlayEnemies[0] = ECard2;

            //------------------------------------//
            GameObject ECard3 = new GameObject();
            ECard3.name = "ECard3";
            ECard3.AddComponent<BoxCollider2D>();
            ECard3.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            ECard3.AddComponent<EnemyStats0>();  
            ECard3.GetComponent<EnemyStats0>().EStatSetup(10, 0, 4, 0);
            ECard3.layer = 9;
        
            ECard3.AddComponent<SpriteRenderer>();
            ECard3.GetComponent<SpriteRenderer>().sprite = EnemySprites[0];
            ECard3.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");

            ECard3.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            ECard3.transform.position = positionEH1;
            battleSc.GetComponent<BattleScript>().InPlayEnemies[1] = ECard3;

            //------------------------------------//
            GameObject ECard4 = new GameObject();
            ECard4.name = "ECard4";
            ECard4.AddComponent<BoxCollider2D>();
            ECard4.GetComponent<BoxCollider2D>().size = new Vector2(6, 8);

            ECard4.AddComponent<EnemyStats0>();  
            ECard4.GetComponent<EnemyStats0>().EStatSetup(10, 0, 4, 0);
            ECard4.layer = 9;

            ECard4.AddComponent<SpriteRenderer>();
            ECard4.GetComponent<SpriteRenderer>().sprite = EnemySprites[0];
            ECard4.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");

            ECard4.transform.localScale = new Vector3(0.264272f, 0.264272f, 1f);
            ECard4.transform.position = positionEH5;
            battleSc.GetComponent<BattleScript>().InPlayEnemies[5] = ECard4;
        }
    }
}