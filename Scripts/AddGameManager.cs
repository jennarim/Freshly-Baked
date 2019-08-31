using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddGameManager : MonoBehaviour
{
    public GameObject scrollView;
    public Collider2D startSensorBar;
    public Collider2D gameBar;

    private ScrollRect scrollRect;

    private GameObject ingredients;
    private int count = 0;

    private bool gameActive;
    private bool gameWin;

    // Start is called before the first frame update
    void Start()
    {
        ingredients = transform.GetChild(0).gameObject;
        scrollRect = scrollView.GetComponent<ScrollRect>();
        gameActive = false;
        gameWin = false;
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

    void deactivateScroll()
    {
        scrollRect.enabled = false;
    }

    void reactivateScroll()
    {
        scrollRect.enabled = true;
    }
}
