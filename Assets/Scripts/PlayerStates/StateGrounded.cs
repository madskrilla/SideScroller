using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateGrounded : IState
{
    private PlayerController mPlayer;

    public void Init(PlayerController _player)
    {
        mPlayer = _player;
    }

    void IState.Update()
    {
        //Empty
    }
}
