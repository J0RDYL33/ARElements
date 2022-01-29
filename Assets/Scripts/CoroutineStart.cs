using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoroutineStart : MonoBehaviour
{
    public Image firstImage;
    public Text secondText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CycleStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CycleStart()
    {
        firstImage.gameObject.SetActive(true);
        secondText.gameObject.SetActive(false);
        yield return new WaitForSeconds(10.0f);
        firstImage.gameObject.SetActive(false);
        secondText.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        secondText.gameObject.SetActive(false);
    }
}
