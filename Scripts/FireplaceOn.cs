using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireplaceOn : MonoBehaviour
{
    
    
    private bool playerTrigger; //changes when the player approaches
    public GameObject lightFireplace; //the particle system and the light inside the fireplace
    public TextController changeOption; //the text displayed on the text box
    public GuideText changeText; //text displayed when the player approches the fireplace
    public bool fireOn = false;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerTrigger = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTrigger && Input.GetKeyDown(KeyCode.F) && count == 0) //this allows the action to take part just once
        {
            lightFireplace.SetActive(!fireOn);//switches the particle system and the light inside the fireplace on
            AudioSource fireSound = GetComponent<AudioSource>(); 
            fireSound.Play();//turns on the music
            StartCoroutine(MyCoroutine()); // calls the function that changes the text displayed inside the text box
            count = 1;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "First Person Player")
        {
            playerTrigger = true;
            //the guide text can be displayed just in case the player hasn't pressed "F" yet
            if (count == 0) { 
            changeText.option = 1; 
            }
            else
            {
                changeText.option = 0;
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "First Person Player")
        {
            playerTrigger = false;
           
            changeText.option = 0; // sets the text to not be active
        }
    }

    private IEnumerator MyCoroutine()
    {
        changeOption.option = 0;
        yield return new WaitForSeconds(5f); 
        changeOption.option = 2; // displays the next text inside the text box
    }
    
}
