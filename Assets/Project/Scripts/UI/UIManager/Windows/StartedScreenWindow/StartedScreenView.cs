using UI.Abstracts;
using UnityEngine;

namespace UI
{
    public class StartedScreenView : UIViewBase
    {
        [SerializeField] private GameObject _go;
        public GameObject GO => _go;
    }
}