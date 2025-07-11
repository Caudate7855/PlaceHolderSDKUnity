using TMPro;
using UI.Abstracts;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class CreatePostModalWindowView : UIViewBase
    {
        public TMP_InputField UserId => _userId;
        public TMP_InputField Title => _title;
        public TMP_InputField Body => _body;
        public Button CancelButton => _cancelButton;
        public Button AcceptButton => _acceptButton;
        
        [SerializeField] private TMP_InputField _userId;
        [SerializeField] private TMP_InputField _title;
        [SerializeField] private TMP_InputField _body;
        [SerializeField] private Button _cancelButton;
        [SerializeField] private Button _acceptButton;
    }
}