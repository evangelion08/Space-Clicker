using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{

    public float score = 0;
    private Text textField;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        textField.text = score.ToString();
        
    }
}
