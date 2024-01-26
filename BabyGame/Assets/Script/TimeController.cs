using System;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    [SerializeField] private float remainingTime = 300f; // 5 dakika.
    [SerializeField] private Boolean gameRunningState = false; 
    public float speedUp = 0f; 
    public string remainingTimeText = "05:00"; // Timer'� oyun i�inde kullan�rken direkt bu de�i�keni kullan�n.
     
    void Start()
    {
        gameRunningState = true; 
    } 
    
    void Update()
    {
        if (gameRunningState)
        { 
            if (remainingTime <= 0)
            {
                updateTime(speedUp); 
            }
            else
            {
                gameRunningState = false;
            }
        }
    }

    private void GetRemainingTime()
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(remainingTime);
        remainingTimeText = timeSpan.ToString(@"mm:ss"); 
    }

    private void updateTime(float speedup) 
    {         
        remainingTime = remainingTime - Time.deltaTime - speedup;
        GetRemainingTime();
    }

    public Boolean getGameRunningState()
    {
        return gameRunningState;
    }
}
