using System;
using System.Linq;
using System.Threading.Tasks;
using UI.Attributes;
using UI.Factories;
using UI.Interfaces;
using Object = UnityEngine.Object;

namespace UI.Abstracts
{
    public abstract class UIControllerBase<TView> : IUIController where TView : UIViewBase
    {
        public bool IsOpened { get; private set; }
        protected MainCanvas MainCanvas { get; }
        protected TView View;
        private bool _isViewLoaded;

        protected UIControllerBase()
        {
            MainCanvas = Object.FindObjectOfType<MainCanvas>();
            
            LoadFromAddressables();
        }
        
        private async void LoadFromAddressables()
        {
            View = await UIViewFactory.LoadFromAddressablesAsync<TView>(MainCanvas, GetViewAssetAddress());
            
            View.gameObject.SetActive(false);
            _isViewLoaded = true;

            Initialize();
        }

        public async void Open()
        {
            if (IsOpened)
                return;
            
            if (!_isViewLoaded)
                await WaitForViewToLoad();

            View.gameObject.SetActive(true);
            IsOpened = true;
            OnOpen();
        }

        public async void Close()
        {
            if(!IsOpened)
                return;
            
            if (!_isViewLoaded)
                await WaitForViewToLoad();

            View.gameObject.SetActive(false);
            IsOpened = false;
            OnClose();
        }

        protected abstract void Initialize();

        protected virtual void OnOpen() { }

        protected virtual void OnClose() { }

        private async Task WaitForViewToLoad()
        {
            while (!_isViewLoaded) 
                await Task.Yield();
        }

        private string GetViewAssetAddress()
        {
            var type = GetType();

            var attribute = type.GetCustomAttributes(typeof(AssetAddress), false)
                .FirstOrDefault() as AssetAddress;

            return attribute?.Address ?? throw new ArgumentException($"Cannot find Address of {type}");
        }
    }
}