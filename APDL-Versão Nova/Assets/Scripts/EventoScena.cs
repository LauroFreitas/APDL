using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class ColliderEvent
{
    public string name;
    public int ID;
    public UnityEvent Event;
}
[System.Serializable]
public class EventoScena : MonoBehaviour
{
    public List<ColliderEvent> ColiderEvent;
}