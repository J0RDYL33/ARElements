using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollision : MonoBehaviour
{
    public InfoSlider myInfoSlider;
    // Start is called before the first frame update
    void Start()
    {
        myInfoSlider = FindObjectOfType<InfoSlider>();
        myInfoSlider.PlayAnim("water");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
