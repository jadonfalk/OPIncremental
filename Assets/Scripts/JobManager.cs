using UnityEngine;
using System.Collections.Generic;

public class JobManager : MonoBehaviour
{
    public ResourceManager resourceManager;

    // List of jobs
    public List<Job> jobs = new List<Job>();

    public int activeJobIndex = 0;

    void Start()
    {
        // Create 2 passive income jobs
        jobs.Add(new Job { jobName = "Dishwasher", xpPerSecond = 1f, beliPerSecond = 2f });
        jobs.Add(new Job { jobName = "Pirate Hunter", xpPerSecond = 3f, beliPerSecond = 5f });
    }

    void Update()
    {
        if (jobs.Count == 0) return;

        Job activeJob = jobs[activeJobIndex];

        // Passive income tick
        resourceManager.AddResource("XP", activeJob.xpPerSecond * Time.deltaTime);
        resourceManager.AddResource("Beli", activeJob.beliPerSecond * Time.deltaTime);
    }
}