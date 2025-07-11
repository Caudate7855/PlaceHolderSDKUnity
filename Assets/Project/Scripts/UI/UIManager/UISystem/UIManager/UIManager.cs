using System.Collections.Generic;
using JetBrains.Annotations;

namespace UI.UIManager
{
    [UsedImplicitly]
    public class UIManager : IUIManager
    {
        private List<object> _controllers = new List<object>();
        
        public T Load<T>() where T : class
        {
            var potentialController = _controllers.Find(c => c is T);

            if (potentialController != null)
                return potentialController as T;
            
            var controller = System.Activator.CreateInstance<T>();
            
            _controllers.Add(controller);
    
            return controller;
        }
    }
}