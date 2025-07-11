using JetBrains.Annotations;
using PlaceHolderSDK;
using UI.Abstracts;
using UI.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    [AssetAddress("UI/CreatePostModalWindow"), UsedImplicitly]
    public class CreatePostModalWindowController : UIControllerBase<CreatePostModalWindowView>
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
        }

        protected override void OnClose()
        {
            _cancelButton.onClick.RemoveListener(Cancel);
            _acceptButton.onClick.RemoveListener(Send);
            
            _resultMessage.HideMessage();
        }
        
        private void Send()
        {
            PostCreateRequest post = new PostCreateRequest
            {
                UserId = int.Parse(View.UserId.text),
                Title = View.Title.text,
                Body = View.Body.text,
            };
            
            _client.CreatePost(post);
            _resultMessage.ShowSuccess();
        }

        private void Cancel()
        {
            Close();
        }
    }
}