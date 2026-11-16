using UnityEngine;
using UnityEngine.Events;

public class AnimationEventRelay : MonoBehaviour
{
    public UnityEvent onAnimationEvent;
 public bool timer = false ;
    public void Trigger()
    {
        timer = true;
        onAnimationEvent.Invoke();
    }
}