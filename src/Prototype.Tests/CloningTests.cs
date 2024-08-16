using Prototype.Model;
using Prototype.Model.Components;

namespace Prototype.Tests
{
    public class CloningTests
    {
        private HouseKeeper androidSusan;

        public CloningTests()
        {
        }

        [SetUp]
        public void Setup()
        {
            androidSusan = new HouseKeeper()
            {
                Name = "Susan",
                Platform = new MovingPlatform() { Name = "Weels" },
                ServingArea = new ServingArea() { Name = "Outdoor activity" },
                ResetKeyword = "resetSusan"
            };
        }

        [Test]
        public void ConstructorCopyTest()
        {
            var anddroidMary = new HouseKeeper(androidSusan);
            anddroidMary.Name = "Mary";
            anddroidMary.Platform.Name = "Feet";
            anddroidMary.ServingArea.Name = "Indoor activity";
            anddroidMary.ResetKeyword = "resetMary";

            //check that value type are copied 
            Assert.IsTrue(anddroidMary.Name != androidSusan.Name);
            Assert.IsTrue(anddroidMary.ResetKeyword != androidSusan.ResetKeyword);

            //check that reference types are the same
            Assert.IsFalse(anddroidMary.ServingArea.Name != androidSusan.ServingArea.Name);
            Assert.IsFalse(anddroidMary.Platform.Name != androidSusan.Platform.Name);
        }

        [Test] 
        public void DeepCloneTest()
        {
            var anddroidMary = androidSusan.DeepClone();
            anddroidMary.Name = "Mary";
            anddroidMary.Platform.Name = "Feet";
            anddroidMary.ServingArea.Name = "Indoor activity";
            anddroidMary.ResetKeyword = "resetMary";

            //check that value type are copied 
            Assert.IsTrue(anddroidMary.Name != androidSusan.Name);
            Assert.IsTrue(anddroidMary.ResetKeyword != androidSusan.ResetKeyword);

            //check that reference types also copied
            Assert.IsTrue(anddroidMary.ServingArea.Name != androidSusan.ServingArea.Name);
            Assert.IsTrue(anddroidMary.Platform.Name != androidSusan.Platform.Name);
        }
    }
}