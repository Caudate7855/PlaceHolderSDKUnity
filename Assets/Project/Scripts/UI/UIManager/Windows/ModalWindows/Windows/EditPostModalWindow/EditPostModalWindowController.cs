using System;
using JetBrains.Annotations;
using PlaceHolderSDK;
using UI.Abstracts;
using UI.Attributes;
using UnityEngine.UI;

namespace UI
{
    [AssetAddress("UI/EditPostModalWindow"), UsedImplicitly]
    public class EditPostModalWindowController : UIControllerBase<EditPostModalWindowView>
    {
        private ResultMessage _resultMessage;
        private Button _cancelButton;
        private Button _acceptButton;

        private readonly PlaceholderClient _client =  new();
        
        protected override void Initialize()
        {
            _resultMessage = View.ResultMessage;
            _cancelButton = View.CancelButton;
            _acceptButton = View.AcceptButton;
        }

        protected override void OnOpen()
        {
            _cancelButton.onClick.AddListener(Cancel);
            _acceptButton.onClick.AddListener(Send);
            
            _resultMessage.HideMessage();
        }

        protected override void OnClose()
        {
            _cancelButton.onClick.RemoveListener(Cancel);
            _acceptButton.onClick.RemoveListener(Send);
            
            _resultMessage.HideMessage();
        }
        
        private void Send()
        {
            _resultMessage.HideMessage();
            
            if(!int.TryParse(View.Id.text, out int id))
            {
                _resultMessage.ShowError();
                return;
            }
            
            var post = new PostUpdateRequest()
            {
                Title = View.Title.text,
                Body = View.Body.text,
            };

            try
            {
                _client.UpdatePost(id, post);
            }
            catch 
            {
                _resultMessage.ShowError();
                return;
            }
            
            _resultMessage.ShowSuccess();
        }

        private void Cancel()
        {
            Close();
        }
    }
}