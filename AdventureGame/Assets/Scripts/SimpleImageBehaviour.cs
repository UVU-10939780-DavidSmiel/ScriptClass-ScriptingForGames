using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SimpleImageBehaviour : MonoBehaviour
{

    private Image imageObj;
    private RectTransform rectTransform;

    public SimpleFloatData dataObj;

    // Start is called before the first frame update
    void Start()
    {
        imageObj = GetComponent<Image>();

        rectTransform = GetComponent<RectTransform>();
        dataObj.SetValue(20f);

    }

    // Update is called once per frame
    void Update()
    {
        imageObj.rectTransform.sizeDelta = new Vector2(dataObj.value * 25, rectTransform.sizeDelta.y);
    }
  /*  public void UpdateWithFloat()
    {
        ////imageObj.fillAmount = dataObj.value;
        imageObj.rectTransform.sizeDelta = new Vector2(dataObj.value * 500, rectTransform.sizeDelta.y)

    }*/
}
