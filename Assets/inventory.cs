namespace DefaultNamespace
{
    public class inventory
    {
        private string name;
        private item[] backpack;
        private item chest; // 0
        private item head; // 1
        private item feet; // 2
        private item wielded; //3

        public item getChest()
        {
            return chest;
        }

        public item getHead()
        {
            return head;
        }

        public item getFeet()
        {
            return feet;
        }

        public item getWeilded()
        {
            return wielded;
        }


    }
}