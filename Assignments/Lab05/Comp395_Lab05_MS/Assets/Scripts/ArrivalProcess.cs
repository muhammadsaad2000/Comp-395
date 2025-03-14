using System;
using System.Collections;
using UnityEngine;
public class ArrivalProcess : MonoBehaviour
{
    public GameObject customerPrefab;
    public Transform customerSpawnPlace;
    public SimulationParameters simulationParameters; public bool generateArrivals;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(GenerateArrivals());
    }
    private IEnumerator GenerateArrivals()
    {
        while (generateArrivals)
        {
            Instantiate(customerPrefab, customerSpawnPlace.position, Quaternion.identity);
            float interArrivalTime = -Mathf.Log(1 - UnityEngine.Random.value) / simulationParameters.lambda;
            print($"interArrivalTime={interArrivalTime}");
            yield return new WaitForSeconds(interArrivalTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}