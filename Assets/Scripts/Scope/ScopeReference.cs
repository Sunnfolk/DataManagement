using UnityEngine;

public class ScopeReference : MonoBehaviour
{
    private ScopeManager _scope;

    private void Start()
    {
        // ScopeManager & ScopeReference must be on the same GameObject
        // If not - Expect NulLReferenceException
        _scope = GetComponent<ScopeManager>();
        _scope.score = 10;
        
        //ScopeManager.pause = true;
    }
}