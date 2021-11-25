using UnityEngine;

public class Player : MonoBehaviour
{
    public FloatVariable _playerHealth;

    private void Start()
    {
        _playerHealth.isDead = false;
    }

    private void Update()
    {
        if (_playerHealth.Value >= 100)
        {
            print("I have full health");
        }
        else
        {
            print("I am wounded!");
        }
    }
}