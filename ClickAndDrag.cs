using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{

    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;
    private float heldPosX;
    private float heldPosY;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld == true)     //Moves the card with the mouse
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);
        }
    }

    private void OnMouseDown()  //Starts the card movement
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Lets the card snap back to its last place
            heldPosX = this.transform.localPosition.x;
            heldPosY = this.transform.localPosition.y;
            //Puts the currently held card in front of the other cards
            this.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Currently Held Card");
            this.gameObject.layer = 10;

            //Gets the mouse pos in reference to the screen rather than the exact pos
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            //Makes the card center not snap to the mouse, smoother movement
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;

        }

    }
    private void OnMouseUp()    //Lets go of the card
    {
        isBeingHeld = false;
        this.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Cards");
        
        PositionSnapping();
    }

    public float CurrentPositionX;
    public float CurrentPositionY;

    private void PositionSnapping()
    {
        LayerMask Holders = LayerMask.GetMask("Card Holders");
        //Grabs the mouse pos in reference to the screen
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        //Checks if the mouse is over a holder
        Collider2D hit1 = Physics2D.OverlapPoint(mousePos, Holders);
        
        //puts the card into the holder or back to its previous spot
        if (hit1 != null)
        {
            //Need to ensure that the selected holder is empty
            GameObject BattleSc = GameObject.Find("GamePlay");
            var BScript = BattleSc.GetComponent<BattleScript>();

            GameObject[] InPlayCardsCopy = BScript.InPlayCards; //Card array
            GameObject HitHolder = hit1.gameObject; //touched holder
            GameObject PlH0C = BScript.PlH0;
            GameObject PlH1C = BScript.PlH1;
            GameObject PlH2C = BScript.PlH2;
            GameObject PlH3C = BScript.PlH3;
            GameObject PlH4C = BScript.PlH4;
            GameObject PlH5C = BScript.PlH5;
            GameObject PlH6C = BScript.PlH6;
            GameObject PlH7C = BScript.PlH7;
            GameObject PlH8C = BScript.PlH8;
            GameObject PlH9C = BScript.PlH9;

            int goodHit = 1;
            if (HitHolder == PlH0C) //Determines which holder is being dealt with
            {
                if (InPlayCardsCopy[0] != null)
                {
                    //Debug.Log("Nuh uh");
                    goodHit = 2;
                } 
                else { goodHit = 1; }
            } else if (HitHolder == PlH1C)
            {
                if (InPlayCardsCopy[1] != null)
                {
                    goodHit = 2;
                } 
                else { goodHit = 1; }
            } else if (HitHolder == PlH2C)
            {
                if (InPlayCardsCopy[2] != null)
                {
                    goodHit = 2;
                }
                else { goodHit = 1; }
            } else if (HitHolder == PlH3C)
            {
                if (InPlayCardsCopy[3] != null)
                {
                    goodHit = 2;
                }
                else { goodHit = 1; }
            } else if (HitHolder == PlH4C)
            {
                if (InPlayCardsCopy[4] != null)
                {
                    goodHit = 2;
                }
                else { goodHit = 1; }
            } else if (HitHolder == PlH5C)
            {
                if (InPlayCardsCopy[5] != null)
                {
                    goodHit = 2;
                }
                else { goodHit = 1; }
            } else if (HitHolder == PlH6C)
            {
                if (InPlayCardsCopy[6] != null)
                {
                    goodHit = 2;
                }
                else { goodHit = 1; }
            } else if (HitHolder == PlH7C)
            {
                if (InPlayCardsCopy[7] != null)
                {
                    goodHit = 2;
                }
                else { goodHit = 1; }
            } else if (HitHolder == PlH8C)
            {
                if (InPlayCardsCopy[8] != null)
                {
                    goodHit = 2;
                }
                else { goodHit = 1; }
            } else if (HitHolder == PlH9C)
            {
                if (InPlayCardsCopy[9] != null)
                {
                    goodHit = 2;
                }
                else { goodHit = 1; }
            }
            this.gameObject.layer = 9;

            if (goodHit == 1)
            {
                //Snaps to holder
                this.gameObject.transform.position = hit1.transform.position;
                CurrentPositionX = this.transform.localPosition.x;
                CurrentPositionY = this.transform.localPosition.y;
            }
            else
            {
                //Snaps back to starting position
                this.gameObject.transform.position = new Vector3(heldPosX, heldPosY, 0);
            }
            
        }
        else
        {
            //Snaps back to starting position
            this.gameObject.transform.position = new Vector3(heldPosX, heldPosY, 0);
        }

    }

}
