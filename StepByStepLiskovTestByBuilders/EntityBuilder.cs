using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication;

namespace StepByStepLiskovTestByBuilders
{
    abstract public class EntityBuilder<TEntity, TSelf>
        where TEntity:Entity
        where TSelf:EntityBuilder<TEntity,TSelf>
    {
        protected int id;

        public TSelf WithId(int id)
        {
            this.id = id;
            return (TSelf)this;
        }

        public abstract TEntity Build();
    }
}
