using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float range = 100f;
    public Camera fpscam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            SHoot();
        }
    }
    void SHoot()
    {
        RaycastHit hit;
     if(   Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit,range))
        {
            if(hit.transform.tag=="re")
            {
                RightEnemey rem = hit.transform.GetComponent<RightEnemey>();
                if(rem!=null )
                {
                    rem.Die();
                }
            }
            if (hit.transform.tag == "le")
            {
                LeftEnemy lem = hit.transform.GetComponent<LeftEnemy>();
                if (lem != null)
                {
                   lem.Die();
                }
            }
            if (hit.transform.tag == "zombie")
            {
                UnityEngine.Debug.Log("ooo");
                followplayer zem = hit.transform.GetComponent<followplayer>();
                if (zem != null)
                {
                    
                    zem.Die();

                }
            }

        }
    }

}
