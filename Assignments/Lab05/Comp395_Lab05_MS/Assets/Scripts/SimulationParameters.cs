using UnityEngine;

[CreateAssetMenu(fileName = "SimulationParameters", menuName = "Scriptable Objects/SimulationParameters")]
public class SimulationParameters : ScriptableObject
{
    public float TimeScale = 1.0f;
    public string SimulationName = ""; public float dt = .02f; // sec public float StartTime = 0;
    public float EndTime = 300; //5 min
    [Header("M/M/1 Queue Parameters")] public float lambda = 24;
    public float mu = 40;
}