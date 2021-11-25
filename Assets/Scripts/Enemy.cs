using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
{
    public FloatVariable _playerHealth;

    private void Awake()
    {
        // Load Specific Asset into FloatVariable field.
        _playerHealth = (FloatVariable)AssetDatabase.
            LoadAssetAtPath("Assets/Scripts/Scrubs/PlayerHealth.asset", 
                typeof(FloatVariable));
    }

    private void Update()
    {
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            _playerHealth.ChangeValue(-10f);
            print("Test");
        }

        if (_playerHealth.Value <= 50)
        {
            print("Looks like meat's back on the menu boys!");
        }
    }
}