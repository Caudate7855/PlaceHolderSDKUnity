using JetBrains.Annotations;
using UI.Abstracts;
using UI.Attributes;
using UnityEngine.UI;

namespace UI
{
    [AssetAddress("UI/MainWindow"), UsedImplicitly]
    public class MainWindowController : UIControllerBase<MainWindowView>
    {
        private Button _getPostsButton;
        private Button _addPostButton;
        private Button _editPostButton;
        private Button _deletePostButton;
        
        protected override void Initialize()
        {
            _getPostsButton = View.GetPostsButton;
            _addPostButton = View.AddPostButton;
            _editPostButton = View.EditPostButton;
            _deletePostButton = View.DeletePostButton;

            SubscribeButtons();
        }

        private void SubscribeButtons()
        {
            _getPostsButton.onClick.AddListener(OnGetPostsButtonClick);
            _addPostButton.onClick.AddListener(OnAddPostButtonClick);
            _editPostButton.onClick.AddListener(OnEditPostButtonClick);
            _deletePostButton.onClick.AddListener(OnDeletePostButtonClick);
        }

        private void OnGetPostsButtonClick()
        {
            
        }

        private void OnAddPostButtonClick()
        {
            
        }

        private void OnEditPostButtonClick()
        {
            
        }

        private void OnDeletePostButtonClick()
        {
            
        }
    }
}