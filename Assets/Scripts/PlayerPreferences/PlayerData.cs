using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerPreferences
{
    public class PlayerData : MonoBehaviour
    {
        public float health = 100f;
        private Vector2 _position;
        private Vector3 _rotation;

        public int _isDead = 0;
        
        void Start()
        {
            GetPlayerData();
            if (_isDead != 0)
            {
                Destroy(gameObject);
            }
        }
        
        void Update()
        {
            if (Keyboard.current.aKey.wasPressedThisFrame)
            {
                SetPlayerData();
            }
            else if (Keyboard.current.dKey.wasPressedThisFrame)
            {
                ClearPlayerData();
            } 
            else if (Keyboard.current.wKey.wasPressedThisFrame)
            {
                ResetPlayerData();
            }
        }

        private void GetPlayerData()
        {
            health = PlayerPrefs.GetFloat("Health");
            _position.x = PlayerPrefs.GetFloat("xPos");
            _position.y = PlayerPrefs.GetFloat("yPos");
            _isDead = PlayerPrefs.GetInt(gameObject.name);
            
            transform.position = _position;
        }

        private void SetPlayerData()
        {
            PlayerPrefs.SetFloat("Health", health);
            PlayerPrefs.SetFloat("xPos", transform.position.x);
            PlayerPrefs.SetFloat("yPos", transform.position.y);
            
            PlayerPrefs.SetInt(gameObject.name, _isDead);
        }

        private void ClearPlayerData()
        {
            PlayerPrefs.DeleteAll();
        }

        private void ResetPlayerData()
        {
            PlayerPrefs.SetFloat("Health", 100f);
            PlayerPrefs.SetFloat("xPos", 0f);
            PlayerPrefs.SetFloat("yPos", 0f);
        }
    }
}