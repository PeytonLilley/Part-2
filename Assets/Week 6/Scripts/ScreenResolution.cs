using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SetScreen16()
    {
        Screen.SetResolution(1600, 900, false);
    }

    public void SetScreenHD()
    {
        Screen.SetResolution(1920, 1080, false);
    }
}
