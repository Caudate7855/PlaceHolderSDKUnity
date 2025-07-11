using System.Threading.Tasks;
using JetBrains.Annotations;
using UI.Abstracts;
using Object = UnityEngine.Object;

namespace UI.Factories
{
    [UsedImplicitly]
    public static class UIViewFactory
    {
        public static async Task<T> LoadFromAddressablesAsync<T>(UIManagerCanvasBase parentCanvas, string assetPath) where T : UIViewBase
        {
            var assetLoader = new UIAssetLoader();
            var instance = await assetLoader.Load<T>(assetPath);

            instance = instance.GetComponent<T>();
            
            parentCanvas = Object.FindObjectOfType<UIManagerCanvasBase>();

            return Object.Instantiate(instance, parentCanvas.transform);
        }
    }
}