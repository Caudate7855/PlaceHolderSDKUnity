using TMPro;
using UI.Abstracts;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class DeletePostModalWindowView : UIViewBase
    {
        public TMP_InputField Id => _id;
        public ResultMessage ResultMessage => _resultMessage;
        public Button CancelButton => _cancelButton;
        public Button AcceptButton => _acceptButton;

        [SerializeField] private TMP_InputField _id;
        [SerializeField] private ResultMessage _resultMessage;
        [SerializeField] private Button _cancelButton;
        [SerializeField] private Button _acceptButton;
    }
}