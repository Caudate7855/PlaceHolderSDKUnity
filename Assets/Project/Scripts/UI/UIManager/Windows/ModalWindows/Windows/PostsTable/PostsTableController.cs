using System.Collections.Generic;
using JetBrains.Annotations;
using PlaceHolderSDK;
using UI.Abstracts;
using UI.Attributes;
using UnityEngine;

namespace UI
{
    [AssetAddress("UI/PostsTableWindow"), UsedImplicitly]
    public class PostsTableController : UIControllerBase<PostsTableView>
    {
        private PostView _postPrefab;
        private Transform _containerObjectTransform;
        
        private readonly PlaceholderClient _client =  new();
        
        protected override void Initialize()
        {
            _containerObjectTransform = View.ContainerObject.transform;
        }

        protected override void OnOpen()
        {
            CreatePostsList(_client.GetPosts());
        }

        public void CreatePostsList(List<Post> posts)
        {
            _postPrefab = View.PostPrefab;
            
            for (int i = 0, count = posts.Count; i < count; i++)
            {
                var instance = Object.Instantiate(_postPrefab, _containerObjectTransform);
                instance.InitializeData(posts[i].UserId, posts[i].Id,posts[i].Title, posts[i].Body);
            }
        }
    }
}