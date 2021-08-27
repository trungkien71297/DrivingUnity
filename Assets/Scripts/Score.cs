using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiple;
    public const string HIGH_SCORE_KEY = "HighScore";
    private float score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreMultiple;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy()
    {
        int currentHighest = PlayerPrefs.GetInt(HIGH_SCORE_KEY, 0);
        if(score > currentHighest)
        {
            PlayerPrefs.SetInt(HIGH_SCORE_KEY, Mathf.FloorToInt(score));
        }
    }
}
