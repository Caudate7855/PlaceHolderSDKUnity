using System.Threading.Tasks;
using UnityEngine;

public interface IUIAssetLoader
{
    public GameObject CashedObject { get; set; }
    public Task<T> Load<T>(string path);
    public void Unload();
}