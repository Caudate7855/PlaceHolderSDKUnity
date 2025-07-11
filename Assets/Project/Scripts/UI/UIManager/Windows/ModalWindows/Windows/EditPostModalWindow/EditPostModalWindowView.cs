using PlaceHolderSDK;
using TMPro;
using UI.Abstracts;
using UnityEngine;

namespace UI
{
    public class EditPostModalWindowView : UIViewBase
    {
        public TMP_InputField Id => _id;
        public TMP_InputField Title => _title;
        public TMP_InputField Body => _body;
        
        [SerializeField] private TMP_InputField _id;
        [SerializeField] private TMP_InputField _title;
        [SerializeField] private TMP_InputField _body;
    }
}