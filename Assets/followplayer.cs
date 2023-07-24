using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class followplayer : MonoBehaviour
{
    public float health = 100f;
    public Image healthbar;

    public float speed = 0.5f;
    private Vector3 dis;
   
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        dis = player.transform.position - transform.position;
        float distancethis = speed;
        if (dis.magnitude <= distancethis)
        {
            counteballgone.ball++;
            Destroy(gameObject);
            return;
        }
        transform.Translate(dis.normalized * distancethis, Space.World);
        transform.LookAt(player.transform.position);

    }
    public void Die()
    {
        health = health - 34;
        healthbar.fillAmount = health / 100f;
        if (health <= 0)
        {

            Destroy(gameObject);
        }
    }
    
}