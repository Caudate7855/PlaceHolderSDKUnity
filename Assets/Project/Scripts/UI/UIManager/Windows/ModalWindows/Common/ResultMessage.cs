using System;
using TMPro;
using UnityEngine;

namespace UI
{
    public class ResultMessage : MonoBehaviour
    {
        [SerializeField] private GameObject _messageContainer;
        [SerializeField] private TMP_Text _messageText;

        [SerializeField] private Color _errorColor;
        [SerializeField] private Color _successColor;
        [SerializeField] private string _successMessageText;
        [SerializeField] private string _errorMessageText;

        private void Start()
        {
            HideMessage();
        }

        public void ShowSuccess()
        {
            _messageText.color = _successColor;
            _messageText.text = _successMessageText;
            
            _messageContainer.SetActive(true);
        }

        public void ShowError()
        {
            _messageText.color = _errorColor;
            _messageText.text = _errorMessageText;
            
            _messageContainer.SetActive(true);
        }

        public void HideMessage()
        {
            _messageContainer.SetActive(false);
        }
    }
}