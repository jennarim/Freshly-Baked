using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MixGameManager : GameManager
{
    private GameObject unmixedDough;
    private GameObject mixedDough;

    private int spinDistanceToWin;
    private int currSpinDistance;


    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        unmixedDough = transform.GetChild(1).GetChild(0).gameObject;
        mixedDough = transform.GetChild(2).gameObject;
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

        }
    }

    
}
