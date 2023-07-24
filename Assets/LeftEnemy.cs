using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEnemy : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {

        target = LeftEnemeySpwn.waypointss[0];
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWypoint();
        }
    }
    void GetNextWypoint()
    {
        if (wavepointIndex < LeftEnemeySpwn.waypointss.Length - 1)
        {

            wavepointIndex++;
            target = LeftEnemeySpwn.waypointss[wavepointIndex];
        }
        else
        {

            counteballgone.ball++;
            Destroy(gameObject);

        }
    }
    public void Die()
    {
        counteballgone.hit++;
        Destroy(gameObject);
    }
}