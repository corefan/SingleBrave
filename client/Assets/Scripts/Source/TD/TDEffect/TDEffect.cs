using System;
using UnityEngine;


//  TDEffect.cs
//  Author: Lu Zexi
//  2013-01-31



/// <summary>
/// 2D特效类
/// </summary>
public class TDEffect : TDObject
{
	public TDEffect (Transform parent,UIAtlas atlas) : base(parent,atlas)
	{
		Initialize();
	}

    //初始化
    protected override void Initialize()
	{
	    ITDMovieClip td_mc = new TDMovieClip(this.m_cAtlas);
        td_mc.SetParent(this.m_cTransform);
        td_mc.SetLocalPos(Vector3.zero);
		AddTDMovieClip(td_mc);
	}

    /// <summary>
    /// 获取最大影片剪辑数
    /// </summary>
    /// <returns></returns>
    public override int GetMovieClipMaxNum()
    {
        return 0;
    }
}


