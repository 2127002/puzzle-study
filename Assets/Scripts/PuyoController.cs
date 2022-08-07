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

[RequireComponent(typeof(Renderer))]
public class PuyoController : MonoBehaviour
{
    [SerializeField]
    private Renderer _puyoRenderer = default!;
    private ColorType _type = ColorType.Unknown;

    static readonly Color[] color_table = new Color[] {
        Color.black,

        Color.red,
        Color.blue,
        Color.green,
        Color.magenta,
        Color.yellow,
        Color.gray,

        Color.white
    };

    public void SetPuyoType(ColorType type)
    {
        _type = type;

        _puyoRenderer.material.color = color_table[(int)_type];
    }
    public ColorType GetColorType()
    {
        return _type;
    }

    public void SetPos(Vector3 pos)
    {
        this.transform.localPosition = pos;
    }
}