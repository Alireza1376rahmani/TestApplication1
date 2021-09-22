using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication;

namespace StepByStepLiskovTestByBuilders
{
    abstract class EntityBuilder<TEntity>
        where TEntity:Entity
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
