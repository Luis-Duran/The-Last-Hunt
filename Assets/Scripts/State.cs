using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "State", order = 51)]
public class State : ScriptableObject
{
    [TextArea(10, 100)] [SerializeField] string displayText;
    [SerializeField] State[] nextStates;

    public string GetDisplayText()
    {
        return displayText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
