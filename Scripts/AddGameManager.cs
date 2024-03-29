﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddGameManager : GameManager 
{
    private GameObject ingredients;
    private int count = 0;    

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        ingredients = transform.GetChild(0).gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameActive && !gameWin)
        {
            if (startSensorBar.bounds.Intersects(gameBar.bounds))
            {
                gameActive = true;
                deactivateScroll();
            }
        } else if (gameActive)
        {
            if (count == 4)
            {
                gameActive = false;
                gameWin = true;
                reactivateScroll();
            }
        }
    }

    public void appear(GameObject ingredient)
    {
        ingredient.SetActive(true);
        count++;
    }

   

    
}
