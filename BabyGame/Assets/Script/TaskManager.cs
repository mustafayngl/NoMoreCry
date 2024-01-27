using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{

    public List<string> tasks = new List<string>(); 
    public Text taskDisplayText;

    void Start()
    {
        tasks.Add("Feed the baby two meals");
        tasks.Add("Check if the toys are in place");
        for(int i = 0; i< tasks.Count; i++)
        {
            Debug.Log(tasks[i]);
        }
    }

    public void AddTask(string newTask)
    {
        tasks.Add(newTask);
    }

    public void CompleteTask(string task)
    {
        
        tasks.Remove(task);
        Debug.Log($"{task}, bitti");
        if (AllTaskComplete())
        {
            Debug.Log("tasklar bitti");
        }
    }
    public bool AllTaskComplete()
    {
        return tasks.Count == 0;
    }

}
