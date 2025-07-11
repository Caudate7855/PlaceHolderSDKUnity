using UnityEngine;

namespace UI
{
    public class PostView : MonoBehaviour
    {
        private int _userId;
        private int _id;
        private string _title;
        private string _body;

        public void InitializeData(int userId, int id, string title, string body)
        {
            _userId = userId;
            _id = id;
            _title = title;
            _body = body;
        }
    }
}