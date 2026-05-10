using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class EntityStateManagerEvents
{
    /// <summary>
    /// 当状态发生切换时触发的事件。
    /// </summary>
    public UnityEvent onChange;

    /// <summary>
    /// 当进入某个状态时触发的事件。
    /// 传递被进入状态的类型信息（Type），方便外部根据状态类型做不同处理。
    /// </summary>
    public UnityEvent<Type> onEnter;

    /// <summary>
    /// 当退出某个状态时触发的事件。
    /// 传递被退出状态的类型信息（Type），方便外部根据状态类型做不同处理。
    /// </summary>
    public UnityEvent<Type> onExit;
}
