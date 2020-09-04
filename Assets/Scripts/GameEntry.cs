using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class GameEntry : MonoBehaviour
{
    void Start()
    {
        // 初始化内置组件
        InitBuiltinComponents();
 
        // 初始化自定义组件
        InitCustomComponents();
 
        // 初始化自定义调试器
        InitCustomDebuggers();
        
        print("游戏主入口");
        
        
    }
}
