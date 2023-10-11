using System.Linq;
using UnityEngine;

public class Cell : ClickableObjectBase
{
    private int[] _position = {-1,-1};
    public int[] position
    {
        get => _position;
    }

    public void InitCell(int x, int y)
    {
        _position = new[] { x, y };

        this.transform.position = new Vector3(_position[0], 0, _position[1]);
    }

    public override void Action()
    {
        if (GameManager.IsEditing)
        {
            //편집 모드일 경우
        }
        else
        {
            //플레이 중이 경우
        }
    }
}
