using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonFunctions : MonoBehaviour
{
    int score = 0;
    public GameObject scoreObject;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreObject = GameObject.Find("Canvas/ScoreTracker/ScoreOutput");
        scoreText = scoreObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void ScoreUp()
    {
        score += 5;
    }

    public void ScoreDown()
    {
        if (score > 0) score -= 5;
    }
}
