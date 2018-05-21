using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform charTransform = null;
    private PlayerStateMachine mPlayerSM;

    // Use this for initialization
    void Start()
    {
        charTransform = transform;

        mPlayerSM = new PlayerStateMachine();
        mPlayerSM.Init(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Input()
    {

    }
}
