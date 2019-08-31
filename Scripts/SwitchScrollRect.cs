using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchScrollRect : MonoBehaviour
{
    public GameObject scrollView;
    public GameObject eventSystem;

    public Collider2D startActivationBar;
    public Collider2D endActivationBar;

    private Collider2D[] screenBars;
    private int curr;

    // Start is called before the first frame update
    void Start()
    {
        getScreenBarsAsColliders();
    }

    // Update is called once per frame
    void Update()
    {
        if (startActivationBar.bounds.Intersects(endActivationBar.bounds))
       {
            scrollView.SetActive(true);
       }

        if (curr < screenBars.Length && startActivationBar.bounds.Intersects(screenBars[curr].bounds))
        {
            eventSystem.SetActive(false);
            curr++;
            eventSystem.SetActive(true);
        }
    }

    private void getScreenBarsAsColliders()
    {
        // Find ScreenBars as GameObjects
        scrollView.SetActive(true);
        GameObject[] bars = GameObject.FindGameObjectsWithTag("ScreenBar");
        scrollView.SetActive(false);

        screenBars = new Collider2D[bars.Length];
        int i = 0;
        foreach (GameObject bar in bars)
        {
            Image image = bar.GetComponent<Image>();
            makeImageTransparent(image);
            screenBars[i++] = bar.GetComponent<BoxCollider2D>();
        }
        curr = 0;
    }

    private void makeImageTransparent(Image image)
    {
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
    }

}
