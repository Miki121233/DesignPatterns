namespace DesignPatterns.Builder
{
    internal class UserBuilder
    {
        private User _user;
        public UserBuilder() 
        {
            _user = new User();
        }
        public UserBuilder SetFirstName(string firstName)
        {
            _user.FirstName = firstName;
            return this;
        }

        public UserBuilder SetLastName(string lastName)
        {
            _user.LastName = lastName;
            return this;
        }

        public UserBuilder SetAge(int age)
        {
            _user.Age = age;
            return this;
        }

        public User Build()
        {
            return _user;
        }
    }
}
