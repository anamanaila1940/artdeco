using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIntensity : MonoBehaviour
{
    //this is the light that is inside the fireplace
    public Light pointLight;
    //by setting maxIntensity to 4, the intenisty of the light will go from 0 to 4 in order to replicate the light inside a real fireplace
    public int maxIntensity = 4;
    //by setting maxRange to 4, the range of the light will go from 0 to 4 in order to replicate the light inside a real fireplace
    public int maxRange = 4;
    // Start is called before the first frame update
    void Start()
    {
        pointLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //the variable for intensity will go from 0 to the value set as maxIntensity
        pointLight.intensity = Mathf.PingPong(Time.time * 1, maxIntensity);
        //the variable for range will go from 0 to the value set as maxRange
        pointLight.range = Mathf.PingPong(Time.time*2, maxRange);
    }
}
