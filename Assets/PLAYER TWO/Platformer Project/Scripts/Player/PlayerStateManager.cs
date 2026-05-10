using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))] // 该组件所在的物体必须挂有Player组件
public class PlayerStateManager : EntityStateManager<Player>
{
    /// <summary>
    /// 玩家状态类的字符串数组。
    /// 使用 ClassTypeName 特性，让 Unity Inspector 面板中可以通过下拉/输入选择继承自 PlayerState 的类。
    /// 
    /// 示例：
    /// states = { "IdlePlayerState", "RunPlayerState", "JumpPlayerState", "SpinPlayerState" }
    /// </summary>
    [ClassTypeName(typeof(PlayerState))]
    public string[] states;


    protected override List<EntityState<Player>> GetStateList()
    {
        return PlayerState.CreateListFromStringArray(states);
    }
}
