using UnityEngine;

namespace DefaultNamespace
{
    public class item : MonoBehaviour
    {
        private string name;
        private string description;
        private SpriteRenderer spr = new SpriteRenderer();
        public item(string newName, string newDescription)
        {
            name = newName;
            description = newDescription;
        }

        public void del()
        {
            name = null;
            description = null;
            spr.sprite = null;
        }
    }
}