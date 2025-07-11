using UI.Abstracts;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class MainWindowView : UIViewBase
    {
        public Button GetPostsButton => _getPostsButton;
        public Button AddPostButton => _addPostButton;
        public Button EditPostButton => _editPostButton;
        public Button DeletePostButton => _deletePostButton;
        
        
        [SerializeField] private Button _getPostsButton;
        [SerializeField] private Button _addPostButton;
        [SerializeField] private Button _editPostButton;
        [SerializeField] private Button _deletePostButton;
    }
}