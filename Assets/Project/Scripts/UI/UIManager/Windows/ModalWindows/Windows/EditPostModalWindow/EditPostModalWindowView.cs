using TMPro;
using UI.Abstracts;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class EditPostModalWindowView : UIViewBase
    {
        public TMP_InputField Id => _id;
        public TMP_InputField Title => _title;
        public TMP_InputField Body => _body;
        public ResultMessage ResultMessage => _resultMessage;
        public Button CancelButton => _cancelButton;
        public Button AcceptButton => _acceptButton;
        
        [SerializeField] private TMP_InputField _id;
        [SerializeField] private TMP_InputField _title;
        [SerializeField] private TMP_InputField _body;
        [SerializeField] private ResultMessage _resultMessage;
        [SerializeField] private Button _cancelButton;
        [SerializeField] private Button _acceptButton;
    }
}