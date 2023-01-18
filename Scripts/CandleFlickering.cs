using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleFlickering : MonoBehaviour
{
    //this is the light that is emitted by the candle
    public Light pointLight;
    //by setting maxIntensity to 1.5, the intenisty of the light will go from 0 to 4 in order to replicate the light of a real candle
    public float maxIntensity = 1.5f;
    //by setting maxRange to 2, the range of the light will go from 0 to 4 in order to replicate the light of a real cand;e
    public int maxRange = 2;
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
        pointLight.range = Mathf.PingPong(Time.time * 1, maxRange);
    }
}
