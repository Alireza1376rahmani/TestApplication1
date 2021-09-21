using ConsoleApplication;
using System;

namespace TestProject1
{
    public abstract class EntityBuilder<TEntity> where TEntity : Entity
    {
        protected int id;

        public EntityBuilder<TEntity> WithId(int id)
        {
            this.id = id;
            return this;
        }

        public abstract TEntity Build();
    }
}