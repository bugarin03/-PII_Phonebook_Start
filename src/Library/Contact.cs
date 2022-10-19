namespace Library
{
    public class Contact
    {
        public Contact(string name, string phone, string email, string twitterId)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.TwitterId = twitterId;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        public string TwitterId { get; set; }
    }
}