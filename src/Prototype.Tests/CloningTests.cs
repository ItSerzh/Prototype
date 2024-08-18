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
            androidSusan = new HouseKeeper(
                resetKeyword: "resetSusan",
                servingArea: new ServingArea("Outdoor activity") ,
                movingPlatform: new MovingPlatform("Weels"),
                name: "Susan");
        }

        [Test]
        public void ConstructorCopyTest()
        {
            var anddroidMary = androidSusan.MyClone();

            //check that properties are copied 
            Assert.IsTrue(anddroidMary.Name == androidSusan.Name);
            Assert.IsTrue(anddroidMary.ResetKeyword == androidSusan.ResetKeyword);
            Assert.IsTrue(anddroidMary.Area.Name == androidSusan.Area.Name);
            Assert.IsTrue(anddroidMary.Platform.Name == androidSusan.Platform.Name);


            anddroidMary.Name = "Mary";
            anddroidMary.Platform.Name = "Feet";
            anddroidMary.Area.Name = "Indoor activity";
            anddroidMary.ResetKeyword = "resetMary";

            //check that value type are copied 
            Assert.IsTrue(anddroidMary.Name != androidSusan.Name);
            Assert.IsTrue(anddroidMary.ResetKeyword != androidSusan.ResetKeyword);

            //check that reference types are the same
            Assert.IsFalse(anddroidMary.Area.Name != androidSusan.Area.Name);
            Assert.IsFalse(anddroidMary.Platform.Name != androidSusan.Platform.Name);
        }

        [Test] 
        public void DeepCloneTest()
        {
            var anddroidMary = (HouseKeeper)androidSusan.Clone();

            //check that properties are copied 
            Assert.IsTrue(anddroidMary.Name == androidSusan.Name);
            Assert.IsTrue(anddroidMary.ResetKeyword == androidSusan.ResetKeyword);
            Assert.IsTrue(anddroidMary.Area.Name == androidSusan.Area.Name);
            Assert.IsTrue(anddroidMary.Platform.Name == androidSusan.Platform.Name);


            anddroidMary.Name = "Mary";
            anddroidMary.Platform.Name = "Feet";
            anddroidMary.Area.Name = "Indoor activity";
            anddroidMary.ResetKeyword = "resetMary";

            //check that value type are copied 
            Assert.IsTrue(anddroidMary.Name != androidSusan.Name);
            Assert.IsTrue(anddroidMary.ResetKeyword != androidSusan.ResetKeyword);

            //check that reference types also copied
            Assert.IsTrue(anddroidMary.Area.Name != androidSusan.Area.Name);
            Assert.IsTrue(anddroidMary.Platform.Name != androidSusan.Platform.Name);
        }
    }
}