using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brick : MonoBehaviour
{
    public Text textValue;
    public Slider valueSetter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnValidate()
    {
        textValue.text = "Value: " + valueSetter.value;

        transform.localScale = new Vector3(valueSetter.value, 1, 1);
    }
}
