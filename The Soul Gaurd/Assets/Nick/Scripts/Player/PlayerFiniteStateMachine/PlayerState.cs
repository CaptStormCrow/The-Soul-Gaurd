﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected Player player;
    protected PlayerStateMachine stateMachine;
    protected BasicStats basicStats;

    protected float startTime;

    private string animBoolName;

    public PlayerState(Player player, PlayerStateMachine stateMachine, BasicStats basicStats, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.basicStats = basicStats;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter()
    {
        DoChecks();
        player.Anim.SetBool(animBoolName, true);
        startTime = Time.time;
        Debug.Log(animBoolName);
    }
    public virtual void Exit()
    {

        player.Anim.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate()
    {

    } 

    public virtual void PhysicsUpdate()
    {
        DoChecks();
    }

    public virtual void DoChecks()
    {

    }
}
