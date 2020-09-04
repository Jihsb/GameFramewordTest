﻿using System.Collections;
using System.Collections.Generic;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;

public class ProcedureLogin : ProcedureBase
{
    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);
        Debug.Log("进入游戏登录流程");
    }
}
