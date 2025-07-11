using UI.Abstracts;
using UnityEngine;

namespace UI
{
    public class PostsTableView : UIViewBase
    {
        public PostView PostPrefab => _postPrefab;
        public GameObject ContainerObject => _containerObject;
        
        [SerializeField] private PostView _postPrefab;
        [SerializeField] private GameObject _containerObject;
    }
}