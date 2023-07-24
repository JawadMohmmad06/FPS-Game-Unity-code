using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography;
public class Spwnernew : MonoBehaviour
{
    public TextMeshProUGUI wavecountdown;
    public Transform rspwanpoint;
    public Transform lspwanpoint;
    public Transform renemyprefab;
    public Transform lenemyprefab;
    public float timeBetweenWaves = 25f;
    public float coundown;
    private int wavenumber = 1;
    public GameObject zombie;
    // Update is called once per frame
    void Start()
    {
        coundown = 10;
    }
    void Update()
    {
        if (coundown <= 0f)
        {
            StartCoroutine(Spanwave());
            coundown = timeBetweenWaves;
        }
        coundown -= Time.deltaTime;
        wavecountdown.text = "Time: " + coundown.ToString("0");
    }
    IEnumerator Spanwave()
    {

        for (int i = 0; i < wavenumber; i++)
        {
            Vector3 randomposition = new Vector3(Random.Range(10, 100),0, Random.Range(0, -100));
            Instantiate(zombie, randomposition, Quaternion.identity);
            Spanenemy();
            yield return new WaitForSeconds(0.5f);
        }
        wavenumber++;
    }
    void Spanenemy()
    {
        Instantiate(renemyprefab, rspwanpoint.position, rspwanpoint.rotation);
        Instantiate(lenemyprefab, lspwanpoint.position, lspwanpoint.rotation);
    }
}
