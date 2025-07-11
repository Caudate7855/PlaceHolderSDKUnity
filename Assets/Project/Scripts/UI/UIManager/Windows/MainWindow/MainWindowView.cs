using UI.Abstracts;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UI
{
    public class MainWindowView : UIViewBase
    {
        public Button GetPostsButton => _getPostsButton;
        public Button CreatePostButton => createPostButton;
        public Button EditPostButton => _editPostButton;
        public Button DeletePostButton => _deletePostButton;
        
        
        [SerializeField] private Button _getPostsButton;
        [FormerlySerializedAs("_addPostButton")] [SerializeField] private Button createPostButton;
        [SerializeField] private Button _editPostButton;
        [SerializeField] private Button _deletePostButton;
    }
}