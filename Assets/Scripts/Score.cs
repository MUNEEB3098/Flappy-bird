using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text;
    int score;
    
    void Start()
    {
        text= GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Bird.collided)
            if(!restart.pase)
            score += 1;
        text.text = "Score :"+score;
        
    }
    
}
