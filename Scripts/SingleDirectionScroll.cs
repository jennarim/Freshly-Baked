using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleDirectionScroll : MonoBehaviour
{
    public GameObject content;
    
    private RectTransform rectT;
    private float maxPosX;

    // Start is called before the first frame update
    void Start()
    {
        rectT = content.GetComponent<RectTransform>();
        maxPosX = rectT.anchoredPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        float currPosX = rectT.anchoredPosition.x;
        if (currPosX > maxPosX)
        {
            Vector3 newPos = new Vector3(maxPosX, 0, 0);
            rectT.anchoredPosition = newPos;
        } else if (currPosX < maxPosX)
        {
            maxPosX = currPosX;
        }
    }
}
