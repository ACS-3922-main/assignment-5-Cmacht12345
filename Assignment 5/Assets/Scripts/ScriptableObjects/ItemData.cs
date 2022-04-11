
using UnityEngine;

[CreateAssetMenu(fileName = "New ItemData", menuName = "ItemData", order = 51)]

public class ItemData : ScriptableObject
{
    public enum ItemType
    {
        Health,
        Banana,
        Watermelon,
        Weapon,
        Donut
    }

    [SerializeField] private string _objectName;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private int _quantity;
    [SerializeField] private bool _isStackable;
    [SerializeField] private ItemType _itemType;

    public string ObjectName
    {
        get
        {
            return _objectName;
        }
    }

    public Sprite Sprite
    {
        get
        {
            return _sprite;
        }
    }

    public int Quantity
    {
        get
        {
            return _quantity;
        }
        set
        {
            _quantity = value;
        }
    }

    public bool IsStackable
    {
        get
        {
            return _isStackable;
        }
    }

    public ItemType Type
    {
        get
        {
            return _itemType;
        }
    }
}
