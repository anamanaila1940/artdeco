using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GuideText : MonoBehaviour
{
    public TextMeshProUGUI speech;
    public GameObject word;
    public int option = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (option == 0)
        {
           
            word.SetActive(false);  //disables the text

        }
        else if (option == 1)
        {
            word.SetActive(true); //makes the text visible
            speech.text = "Press F to turn the fireplace on."; //changes what is shown on the screen
        }
        else if (option == 2)
        {
            
            word.SetActive(true);//makes the text visible
            speech.text = "Press F to switch the light on."; //changes what is shown on the screen
        }
        else if (option == 3)
        {
           
            word.SetActive(true); //makes the text visible
            speech.text = "Press F to switch the radio on."; //changes what is shown on the screen
        }
        else if (option == 4)
        {
            word.SetActive(true); //makes the text visible
            speech.text = "Press F to switch the radio off."; //changes what is shown on the screen
        }
    }
}
