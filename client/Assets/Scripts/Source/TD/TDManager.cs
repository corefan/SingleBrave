using System;
using System.Collections.Generic;
using UnityEngine;

using Game.Base;


//  TDManager.cs
//  Author: Lu Zexi
//  2012-11-29


/// <summary>
/// 2D渲染体管理类
/// </summary>
public class TDManager : Singleton<TDManager>
{
	private List<TDObject> m_lstTDObject;      //渲染体集合
	
	public TDManager ()
	{
        Initialize();
	}
	
    /// <summary>
    /// 初始化
    /// </summary>
	public void Initialize()
	{
        this.m_lstTDObject = new List<TDObject>();
	}
	
    /// <summary>
    /// 逻辑更新
    /// </summary>
	public void Update()
	{	
		foreach(TDObject obj in this.m_lstTDObject)
		{
		 	obj.Update();
		}
	}
	
    /// <summary>
    /// 销毁
    /// </summary>
	public void Destroy()
	{
        foreach (TDObject item in this.m_lstTDObject)
        {
            item.Destory();
        }
        this.m_lstTDObject.Clear();
	}
	
	/// <summary>
	/// 创建特效渲染体
	/// </summary>
	/// <param name="parent"></param>
	/// <param name="atlas"></param>
	/// <returns></returns>
	public TDEffect CreateEffect(Transform parent,UIAtlas atlas)
	{
		TDEffect effect = new TDEffect(parent,atlas);
		m_lstTDObject.Add(effect);
		
		return effect;
	}
	
	/// <summary>
	/// 删除渲染体
	/// </summary>
	/// <param name="obj"></param>
	public void RemoveTDObject(TDObject obj)
	{
		if(m_lstTDObject.Contains(obj))
		{
            obj.Destory();
			m_lstTDObject.Remove(obj);	
		}
	}
	
}


