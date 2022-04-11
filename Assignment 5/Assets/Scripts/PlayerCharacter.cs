using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    private int _health;
    private Vector3 _startPos;
    public Vector3 _respawn = new Vector3(10f, -10f, 0.4f);
    [SerializeField] private Text _game;
    [SerializeField] private Image _gameOver;
    [SerializeField] private Image _gameWon;
    [SerializeField] private Image _inventory;
    [SerializeField] private Text _healthText;
    [SerializeField] private Image _slot1;
    [SerializeField] private Image _slot2;
    [SerializeField] private Image _slot3;
    [SerializeField] private Image _slot4;
    [SerializeField] private Image _slot5;
    private bool _gameOverBool = false;
    private bool _active;
    private int _slotCounter = 0;
    void Start()
    {
        _health = 5;
        _healthText.text = "Health: "+ _health;
        _startPos = transform.position;
        _gameOver.gameObject.SetActive(false);
        _gameWon.gameObject.SetActive(false);
        _inventory.gameObject.SetActive(false);

    }
    void Update()
    {
        if (transform.position.y < -15f || _health <= 0 && !_gameOverBool)
        {
            _gameOverBool = true;
            GameOver();
        }
        if (Input.GetKey(KeyCode.Escape) && !_gameOverBool)
        {
            if (!_active)
            {
                _inventory.gameObject.SetActive(true);
                _active = true;
            }
            else if (_active)
            {
                _inventory.gameObject.SetActive(false);
                _active = false;
            }
            

        }
    }
    public void Hurt(int damage)
    {
        _health -= damage;
        _healthText.text = "Health: " + _health;
    }
    public void Heal(int energy)
    {
        _health += energy;
        if(_health > 10)
        {
            _health = 10;
        }
        _healthText.text = "Health: " + _health;
    }
    public void GameOver()
    {
        if(_health > 0 && !_gameOverBool)
        {
            _game.text = "You Have Won The Game Enjoy Your Donut!";
            _gameWon.gameObject.SetActive(true);
            _gameOverBool = true;
        }
        else if(_health <= 0 && !_gameOverBool)
        {
            _gameOver.gameObject.SetActive(true);
            _game.text = "Game Over!";
            _gameOverBool = true;
        }
        else if (transform.position.y < -15f && !_gameOverBool)
        {
            _gameOver.gameObject.SetActive(true);
            _game.text = "Game Over!";
            _gameOverBool = true;
        }

    }
    public void InventoryImage(ItemData slot)
    {
        
        _slotCounter++;
        switch (_slotCounter)
        {
            case 1:
                _slot1.GetComponent<Image>().sprite = slot.Sprite;
                break;
            case 2:
                _slot2.GetComponent<Image>().sprite = slot.Sprite;
                break;
            case 3:
                _slot3.GetComponent<Image>().sprite = slot.Sprite;
                break;
            case 4:
                _slot4.GetComponent<Image>().sprite = slot.Sprite;
                break;
            case 5:
                _slot5.GetComponent<Image>().sprite = slot.Sprite;
                break;
            default:
                print("Inventory Full");
                break;
        }

    }

}
