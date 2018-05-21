using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public PlayerController mPlayer;

    private List<IState> mStates = new List<IState>();
    private IState mCurrentState;

    /// <summary>
    ///Used to Add States and Set The Initial Player State
    ///</summary>
    public void Init(PlayerController _player)
    {
        mPlayer = _player;
    }

    /// <summary>
    /// Update the Current State
    /// </summary>
    public void Update()
    {
        mCurrentState.Update();
    }

    /// <summary>
    /// Switch to the Next State
    /// </summary>
    public void SwitchState()
    {

    }
}
