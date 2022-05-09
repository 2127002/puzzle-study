using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    public static readonly int BOARD_WIDTH = 6;
    public static readonly int BOARD_HEIGHT = 14;

    [SerializeField]
    private GameObject PuyoPrefab = default!;

    int[,] _board = new int[BOARD_HEIGHT, BOARD_WIDTH];
    GameObject[,] _puyos = new GameObject[BOARD_HEIGHT,BOARD_WIDTH];

    private void Start()
    {
        ClearAll(_board);
    }

    public void ClearAll(int[,] board)
    {
        for(int y = 0; y < BOARD_HEIGHT; y++)
        {
            for(int x = 0; x < BOARD_WIDTH; x++)
            {
                board[y,x] = 0;

                if (_puyos[y,x] != null) Destroy(_puyos[y, x]);
                _puyos[y, x] = null;
            }
        }
    }
}
