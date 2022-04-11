using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    [SerializeField] private ItemData _item;

    public ItemData Item
    {
        get
        {
            return _item;
        }
    }

    private void OnTriggerEnter(Collider other)
        {
        ItemData consumableObject = Item;

            if (other.gameObject.name == "Player")
            {
                switch (consumableObject.Type)
                {
                case ItemData.ItemType.Watermelon:
                        other.GetComponent<PlayerCharacter>().Heal(10);
                        other.GetComponent<PlayerCharacter>().InventoryImage(consumableObject);
                    break;

                case ItemData.ItemType.Banana:
                        other.GetComponent<PlayerCharacter>().Heal(1);
                        other.GetComponent<PlayerCharacter>().InventoryImage(consumableObject);
                    break;
                case ItemData.ItemType.Weapon:
                    GameObject.Find("Main Camera").GetComponent<RayShooter>().enableGun();
                    break;
                case ItemData.ItemType.Donut:
                    other.GetComponent<PlayerCharacter>().GameOver();
                    other.GetComponent<PlayerCharacter>().InventoryImage(consumableObject);
                    break;
            }
                Destroy(this.gameObject);
            }

        }
}
