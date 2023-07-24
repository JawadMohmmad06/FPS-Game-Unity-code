using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class newgame : MonoBehaviour
{
    public void newwgame()
    {
        UnityEngine.Debug.Log("oye");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
