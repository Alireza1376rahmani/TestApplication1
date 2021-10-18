namespace TestProject1
{
    public class TestEntityBuilder : EntityBuilder<TestEntity>
    {
        public override TestEntity Build()
        {
            return new TestEntity(id);
        }
    }
}
