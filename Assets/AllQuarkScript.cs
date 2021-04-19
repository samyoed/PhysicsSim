using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllQuarkScript : MonoBehaviour
{
    public Slider speedSlider;
    public float quarkSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        quarkSpeed = speedSlider.value;
    }
}
