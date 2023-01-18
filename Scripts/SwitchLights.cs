using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLights : MonoBehaviour
{
    private bool playerTrigger; //changes when the player approaches
    public GameObject lighT; //refers to the ceiling lights
    public bool lightOn = false;
    public GameObject lampLight; //the lamp on the table
    public TextController changeOption; //controlls the text inside the text box
    public int count = 0; //makes sure certain actions are done just once
    public GuideText changeText; //controlls the guide text that lets the player now what is the object they are interacting and what button they should press
    // Start is called before the first frame update
    void Start()
    {
        playerTrigger = false;
 
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTrigger && Input.GetKeyDown(KeyCode.F) && count == 0) 
        {
            lighT.SetActive(!lightOn); //turns the ceiling lights on
            Animator anim = GetComponent<Animator>(); 
            anim.Play("switch"); //plays the rotation of the switch
            AudioSource click = GetComponent<AudioSource>();
            click.Play(); //plays the click sound
            lampLight.SetActive(false); //turns the lamp off
            StartCoroutine(MyCoroutine()); // calls the function that changes the text displayed inside the text box
            count = 1; //makes sure the action is done just once
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "First Person Player")
        {
            playerTrigger = true;

            //the guide text can be displayed just in case the player has not switched the lights on
            if (count == 0)
            {
                changeText.option = 2;
            }
            else
            {
                changeText.option = 0;
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "First Person Player")
        {
            playerTrigger = false;
            changeText.option= 0; //sets the text to not be active
        }
    }

    private IEnumerator MyCoroutine()
    {
        changeOption.option = 0;
        yield return new WaitForSeconds(5f);
        changeOption.option = 3; // displays the next text inside the text box
    }
}
