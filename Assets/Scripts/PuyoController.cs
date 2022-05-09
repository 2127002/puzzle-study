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
    //色のマテリアルデータは別箇所に定義
    private ColorType _puyoColor;
    [SerializeField]
    private Renderer _puyoRenderer = default!;

    //固定中か
    private bool _OnGround = false;

    /// <summary>
    /// 特定のポジションにオブジェクトを設定する
    /// </summary>
    public void SetPos(float Width, float Height)
    {
        Vector3 newPos = new Vector3(DataSetting.dataSetting.KeyPosition.x
            + DataSetting.dataSetting.PosSize
            * Width,
            DataSetting.dataSetting.KeyPosition.y
            + DataSetting.dataSetting.PosSize
            * -Height,
            0);
        newPos += DataSetting.dataSetting.KeyPosition;

        this.transform.position = newPos;
    }

    private void OnEnable()
    {
        //正しい色データなら
        if (ColorType.Default < puyoColor && puyoColor < ColorType.Unknown)
        {
            //色を設定する
            puyoRenderer.material = DataSetting.dataSetting.MaterialMap[puyoColor];
        }
        else
        {
            Debug.LogError("PuyoColorData Error");
            return;
        }
    }

    public ColorType puyoColor
    {
        get
        {
            return _puyoColor;
        }
        set
        {
            _puyoColor = value;
        }


    }
    public Renderer puyoRenderer
    {
        get
        {
            return _puyoRenderer;
        }
        set
        {
            _puyoRenderer = value;
        }
    }
}