using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClockScript : MonoBehaviour
{
    public TextMeshProUGUI timeText ;


    float timeToWait = 0f;

    float oldValue = 0f;
    float rand = 0f;
    float newValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //timeText = GetComponent<TextMeshProUGUI>();
        timeToWait = Time.fixedTime + 2f;


    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        if (Time.fixedTime >= timeToWait)
        {
            oldValue = float.Parse(timeText.text);
            rand = Random.Range(-2, 3);
            newValue = Mathf.Clamp(oldValue + rand, 5, 30);
            timeText.text = newValue.ToString();

            timeToWait = Time.fixedTime + 2f;
        }

    }
}
