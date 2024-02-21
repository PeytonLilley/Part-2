using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    SpriteRenderer sr;
    public Color selectedColor;
    public Color unselectedColor;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent <SpriteRenderer>();
        Selected(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Selected(true);
    }

    void Selected(bool isSelected)
    {
        if (isSelected)
        {
            sr.color = selectedColor;
        }
        else
        {
            sr.color = unselectedColor;
        }
    }
}
