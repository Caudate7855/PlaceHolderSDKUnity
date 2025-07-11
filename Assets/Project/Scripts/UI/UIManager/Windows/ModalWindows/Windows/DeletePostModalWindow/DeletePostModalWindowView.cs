using TMPro;
using UI.Abstracts;
using UnityEngine;

namespace UI
{
    public class DeletePostModalWindowView : UIViewBase
    {
        public TMP_InputField Id => _id;
        
        [SerializeField] private TMP_InputField _id;
    }
}