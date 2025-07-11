using TMPro;
using UnityEngine;

namespace UI
{
    public class PostView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _userId;
        [SerializeField] private TMP_Text _id;
        [SerializeField] private TMP_Text _title;
        [SerializeField] private TMP_Text _body;

        public void InitializeData(int userId, int id, string title, string body)
        {
            _userId.text = userId.ToString();
            _id.text = id.ToString();
            _title.text = title;
            _body.text = body;
        }
    }
}