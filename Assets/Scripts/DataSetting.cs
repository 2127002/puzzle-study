using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSetting : MonoBehaviour
{

    //シングルトン
    public static DataSetting dataSetting;

    private Dictionary<ColorType, Material> _MaterialMap;

    //マテリアルの定義
    [SerializeField]
    private Material Red;
    [SerializeField]
    private Material Blue;
    [SerializeField]
    private Material Green;
    [SerializeField]
    private Material Purple;
    [SerializeField]
    private Material Orange;
    [SerializeField]
    private Material Jammer;

    //基準となる位置
    [SerializeField]
    private Vector3 _KeyPosition;

    //距離定義
    public readonly float PosSize = 1.0f;

    private void Start()
    {
        _MaterialMap = new Dictionary<ColorType, Material>();
        _MaterialMap.Add(ColorType.Red, Red);
        _MaterialMap.Add(ColorType.Blue, Blue);
        _MaterialMap.Add(ColorType.Green, Green);
        _MaterialMap.Add(ColorType.Purple, Purple);
        _MaterialMap.Add(ColorType.Orange, Orange);
        _MaterialMap.Add(ColorType.Jammer, Jammer);

        if (dataSetting == null)
        {
            dataSetting = this;
        }
    }

    public Dictionary<ColorType, Material> MaterialMap
    {
        get {
            return _MaterialMap;
        }
    }

    public Vector3 KeyPosition
    {
        get {
            return _KeyPosition;
        }
    }
}