using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioOn : MonoBehaviour
{

    private bool playerTrigger;
    public bool radioActive = true;
    public TextController changeOption;
    public int count = 0;
    public GuideText changeText;
    // Start is called before the first frame update
    void Start()
    {
        playerTrigger = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (radioActive == true)
        {
            AudioSource click = GetComponent<AudioSource>();
            click.Play();
            
        }
        if (playerTrigger && Input.GetKeyDown(KeyCode.F))
        {
            radioActive = !radioActive;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "First Person Player")
        {
            playerTrigger = true;
            if (radioActive) { 
            changeText.option = 3;
            }
            else
            {
                changeText.option = 4;
            }
            if (count == 0)
            {
                changeOption.option = 0;
                count = 1;
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "First Person Player")
        {
            playerTrigger = false;
            changeText.option = 0;
        }
    }
}
