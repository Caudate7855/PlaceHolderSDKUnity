using UI;
using UI.UIManager;
using UnityEngine;

public class Boot: MonoBehaviour
{
    IUIManager _uiManager = new UIManager();
    private MainWindowController _mainWindowController;
    
    
    private void Start()
    {
        _mainWindowController = _uiManager.Load<MainWindowController>();
        
        _mainWindowController.Open();
    }
}