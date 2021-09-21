using ConsoleApplication;

namespace TestProject1
{
    public class UserBuilder : EntityBuilder<User>
    {
        private string name;

        public override User Build()
        {
            return new User(id, name);
        }

        public UserBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }
    }
}