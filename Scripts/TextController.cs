using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI speech;
    public int option = 1;
    public GameObject image;
    public GameObject word;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(option == 0)
        {
            image.SetActive(false); //disables the image
            word.SetActive(false); //disables the text

        }
        else if(option == 1)
        {
            image.SetActive(true);//makes the image visible
            word.SetActive(true);//makes the text visible
            speech.text = "It's so cold in here. Oh I think there must be a fireplace in here."; //changes what is shown on the screen
        }
        else if(option == 2)
        {
            image.SetActive(true);
            word.SetActive(true);
            speech.text = "Way better! Now let's switch the lights on. It is so dark in here.";
        }else if(option == 3)
        {
            image.SetActive(true);
            word.SetActive(true);
            speech.text = "The only thing missing is the music. I think I saw a radio.";
        }
    }
}
