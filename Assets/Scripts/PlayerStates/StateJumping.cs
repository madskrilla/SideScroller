using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateJumping : IState
{
    private PlayerController mPlayer;

    public void Init(PlayerController _player)
    {
        mPlayer = _player;
    }

    public void Update()
    {
        //Empty
    }
}
