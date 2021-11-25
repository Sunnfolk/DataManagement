using UnityEngine;

public class ScopeManager : MonoBehaviour
{
    // Initializing / Declaring Variables 
    public int score; // Accessible from Other Classes(Scripts)
    private float health; // Only accessible from ScopeManager Class
    protected bool dead; // Accessible only from ScopeManager
    // And Classes that Inherit from ScopeManager

    public string words;
    
    
    // Keyword Modifiers for Functions
    // abstract
    // virtual
    // override
    
    public static bool pause; // Accessible from All scripts
    // Without reference
    
}