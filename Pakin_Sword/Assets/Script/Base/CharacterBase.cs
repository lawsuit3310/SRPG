using System.Linq;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    [SerializeField]
    protected CharacterDataBase Data;

    private byte[] _position;
    public byte[] Position
    {
        get { return _position.Any() ? _position : new byte [] {0,0};}
    }
    public CharacterDataBase data
    {
        get { return Data; }
    }
    
    public string Name { get => Data.Name;}
    
    public abstract void Create(int id);
    public abstract void Think();
    public abstract void Move();
}