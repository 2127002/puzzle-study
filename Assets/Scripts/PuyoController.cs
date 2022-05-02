using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColorType
{
    Default,

    Red,
    Blue,
    Green,
    Purple,
    Orange,
    Jammer,

    Unknown
}

public enum ShapeType
{
    Default,

    Single,
    Double,
    Triple,
    Quadruple,

    Unknown
}

public class PuyoController : MonoBehaviour
{
    //色のデータは別箇所に定義


    /// <summary>
    /// 特定のポジションにオブジェクトを設定する
    /// </summary>
    public void SetPos(float Row,float Column)
    {
        Vector3 newPos = new Vector3(DataSetting.dataSetting.KeyPosition.x
            + DataSetting.dataSetting.PosSize
            * Row,
            DataSetting.dataSetting.KeyPosition.y
            + DataSetting.dataSetting.PosSize
            * -Column,
            0);
        newPos += DataSetting.dataSetting.KeyPosition;

        this.transform.position = newPos;
    }


}