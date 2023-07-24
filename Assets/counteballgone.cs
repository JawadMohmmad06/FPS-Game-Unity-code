using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class counteballgone : MonoBehaviour
{

    public TextMeshProUGUI newhigh;
    public TextMeshProUGUI oldhigh;
    public TextMeshProUGUI hited;
    public GameObject complelvl;
    public TextMeshProUGUI countball;
    public static int ball = 0;
    public float live = 5;
    public static int hit = 0;
    // Update is called once per frame
    void Start()
    {
        ball = 0;
       live =10;
        hit = 0;
        complelvl.SetActive(false);
    }
    void Update()
    {
        hited.SetText("Destroyed: "+hit.ToString());
        if (live - ball<=0)
        {
            GameOver();
            return;
        }
        countball.text = "Lives: " + (live-ball).ToString();
    }
 public void GameOver()
    {
        int hs = PlayerPrefs.GetInt("Score", 0);
        if (hit > hs)
        {
            PlayerPrefs.SetInt("Score", hit);
            newhigh.SetText("New HighScore " +hit.ToString());
            oldhigh.SetText("");

        }
        else
        {
            hited.SetText("");
            newhigh.SetText("Your Score " + hit);
            oldhigh.SetText("High Score " + hs.ToString());
        }
        complelvl.SetActive(true);
    }


}
