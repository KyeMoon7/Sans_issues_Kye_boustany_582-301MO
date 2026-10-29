using System.Net.Sockets;
using UnityEngine;

public class MouseUnlock : MonoBehaviour
{
    public bool locked = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetLocked(locked);
    }

    public void SetLocked(bool value)
    {
        locked = value;
        Cursor.lockState = locked ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !locked;
    }
}
