using System;
using UnityEngine;
using UnityEngine.UI;

abstract public class GameManager : MonoBehaviour {
    [SerializeField]
    protected GameObject scrollView;
    [SerializeField]
    protected Collider2D startSensorBar;
    [SerializeField]
    protected Collider2D gameBar;

    protected ScrollRect scrollRect;

    protected bool gameActive;
    protected bool gameWin;

    public virtual void Start()
    {
        scrollRect = scrollView.GetComponent<ScrollRect>();
        gameActive = false;
        gameWin = false;
    }

    protected void deactivateScroll()
    {
        scrollRect.enabled = false;
    }

    protected void reactivateScroll()
    {
        scrollRect.enabled = true;
    }
}
