using JetBrains.Annotations;
using PlaceHolderSDK;
using UI.Abstracts;
using UI.Attributes;

namespace UI
{
    [AssetAddress("UI/EditPostModalWindow"), UsedImplicitly]
    public class EditPostModalWindowController : UIControllerBase<EditPostModalWindowView>
    {
        private int _userId;
        private string _title;
        private string _body;
        
        PlaceholderClient _client =  new PlaceholderClient();
        
        protected override void Initialize()
        {
            
        }
        
        public void Send()
        {
            var post = new PostCreateRequest
            {
                UserId = _userId,
                Title = _title,
                Body = _body
            };

            _client.CreatePost(post);
        }
    }
}