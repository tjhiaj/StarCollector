using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarPlayer : MonoBehaviour
{
    public int stars = 0; // An integer whole number
    public TMP_Text starText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        starText.SetText("Stars: " + stars);
    }
}
