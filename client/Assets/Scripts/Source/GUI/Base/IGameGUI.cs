

using UnityEngine;



//  IGameGUI.cs
//  Author:Lu Zexi
//  2012-11-1



/// <summary>
/// 底层GUI接口
/// </summary>
public interface IGameGUI
{
    void Initialize();  //初始化
    void Destory();     //析构
    bool IsShow();      //是否在展示状态
    void Show();        //展示GUI
    void Hiden();       //隐藏GUI
    void SetLocalPos(float x, float y);  //设置平面坐标
    void SetLocalPos(float z);           //设置深度
    void SetLocalPos(Vector3 pos);       //设置3D坐标
    void SetFocus();    //设置为焦点
    bool Update();      //逻辑更新
    bool Render();      //渲染更新
}
