using System.Threading.Tasks;
using JetBrains.Annotations;
using PlaceHolderSDK;
using UI.Abstracts;
using UI.Attributes;
using UI.UIManager;
using UnityEngine.UI;

namespace UI
{
    [AssetAddress("UI/MainWindow"), UsedImplicitly]
    public class MainWindowController : UIControllerBase<MainWindowView>
    {
        private Button _getPostsButton;
        private Button _createPostButton;
        private Button _editPostButton;
        private Button _deletePostButton;

        private readonly IUIManager _uiManager = new UIManager.UIManager();

        private CreatePostModalWindowController _createPostModalWindowController;
        private EditPostModalWindowController _editPostModalWindowController;
        private DeletePostModalWindowController _deletePostModalWindowController;
        private PostsTableController _postsTableController;
        
        private readonly PlaceholderClient _client =  new();
        
        protected override void Initialize()
        {
            _getPostsButton = View.GetPostsButton;
            _createPostButton = View.CreatePostButton;
            _editPostButton = View.EditPostButton;
            _deletePostButton = View.DeletePostButton;

            SubscribeButtons();
        }

        private void SubscribeButtons()
        {
            _getPostsButton.onClick.AddListener(OnGetPostsButtonClick);
            _createPostButton.onClick.AddListener(OnCreatePostButtonClick);
            _editPostButton.onClick.AddListener(OnEditPostButtonClick);
            _deletePostButton.onClick.AddListener(OnDeletePostButtonClick);
        }

        private void OnGetPostsButtonClick()
        {
            _postsTableController = _uiManager.Load<PostsTableController>();
            _postsTableController.Open();
        }

        private void OnCreatePostButtonClick()
        {
            _createPostModalWindowController = _uiManager.Load<CreatePostModalWindowController>();
            _createPostModalWindowController.Open();
        }

        private void OnEditPostButtonClick()
        {
            _editPostModalWindowController = _uiManager.Load<EditPostModalWindowController>();
            _editPostModalWindowController.Open();
        }

        private void OnDeletePostButtonClick()
        {
            _deletePostModalWindowController = _uiManager.Load<DeletePostModalWindowController>();
            _deletePostModalWindowController.Open();
        }
    }
}