using NUnit.Framework;

namespace DILight.Tests.Unit
{
    [TestFixture]
    public class ConfigurationStoreTest
    {
        [Test]
        public void ConfigurationStore_should_return_correct_type()
        {
            var configStore = new ConfigurationStore();
            configStore.Mapping<ITest, Test>();

            var a = configStore._pairings.Count;

            var obj = Locator.Resolve<ITest>(configStore._pairings);

            string hi = obj.Hi();

        }

    }

    public class Test : ITest
    {
        public string Hi()
        {
            return "hi";
        }
    }

    public interface ITest
    {
        string Hi();
    }
}
