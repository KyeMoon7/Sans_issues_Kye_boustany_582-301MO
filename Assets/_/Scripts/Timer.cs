using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public UnityEvent onEvent;
    public bool timer = false ;
    public void TriggerTimer()
    {
        timer = true;
        onEvent.Invoke();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
}
