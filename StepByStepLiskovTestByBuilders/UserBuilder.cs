using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication;

namespace StepByStepLiskovTestByBuilders
{
    class UserBuilder : EntityBuilder<User>
    {
        private string username;

        public UserBuilder WithName(string name)
        {
            this.username = name;
            return this;
        }

        public override User Build()
        {
            return new User(id, username);
        }
    }
}
