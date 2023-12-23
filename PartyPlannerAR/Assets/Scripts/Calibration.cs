using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calibration : MonoBehaviour
{

    [SerializeField] private GameObject reference;
    public Slider slider;
    public Text text;

    private const float ZOffset = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    // Update is called once per frame
    private void OnSliderValueChanged(float value)
    {
        var scale = 100f;
        var val = value * scale;
        if (reference)
        {
            var pos = reference.transform.position;
            pos.z = ZOffset + val;
            reference.transform.position = pos;
        }

        if (text)
        {
            text.text = "Value: " + val.ToString("F2");
        }
        
    }
}
