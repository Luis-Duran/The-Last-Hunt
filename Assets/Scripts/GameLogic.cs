using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    [SerializeField] State initialState;
    [SerializeField] Text storyText;
    State currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = initialState;
        storyText.text = currentState.GetDisplayText();
    }

    // Update is called once per frame
    void Update()
    {
        StateManager();
    }

    void StateManager()
    {
        var nextStates = currentState.GetNextStates();
        if (currentState == initialState)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                currentState = nextStates[0];
            }
        }
        else
        {
            try
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    currentState = nextStates[0];
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    currentState = nextStates[1];
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    currentState = nextStates[2];
                }
            }
            catch (IndexOutOfRangeException e)
            {
                //do nothing
            }
        }
        storyText.text = currentState.GetDisplayText();
    }
}
