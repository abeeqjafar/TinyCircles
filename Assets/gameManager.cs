using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{
    public Text score;
    float timer = 0.0f;
    int start;
    // Start is called before the first frame update
    void Start()
    {
        start = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        start = (int)timer % 60;
        score.text =  "Score: " + start.ToString();
       
    }
}
