using UnityEngine;

[CreateAssetMenu(fileName = "New FloatVariable", menuName = "Scrubs/Float")]
public class FloatVariable : ScriptableObject
{
   public float Value;
   public bool isDead;

   public Rigidbody2D _Rigidbody2D;

   public void SetValue(float newValue,  bool dead)
   {
      Value = newValue;
      isDead = dead;
   }

   public void SetValue(bool dead)
   {
      isDead = dead;
   }
   
   public void ChangeValue(float newValue)
   {
      Value += newValue;
   }
}