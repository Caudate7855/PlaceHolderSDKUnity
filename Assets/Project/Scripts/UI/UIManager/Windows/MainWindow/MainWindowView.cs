using UI.Abstracts;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class MainWindowView : UIViewBase
    {
        public Button GetPostsButton => _getPostsButton;
        public Button CreatePostButton => _createPostButton;
        public Button EditPostButton => _editPostButton;
        public Button DeletePostButton => _deletePostButton;
        public PostsTableView PostsTableView  => _postsTableView;
        
        
        [SerializeField] private Button _getPostsButton;
        [SerializeField] private Button _createPostButton;
        [SerializeField] private Button _editPostButton;
        [SerializeField] private Button _deletePostButton;
        [SerializeField] private PostsTableView _postsTableView;
    }
}