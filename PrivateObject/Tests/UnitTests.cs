using Sailr.PrivateObject;
using SampleTest;

namespace Tests;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void TestPrivateMethod()
    {
        var obj = new SomeClass();

        // Create an instance of the PrivateObject class, passing in the object
        var privateObject = new PrivateObject(obj);

        // Invoke the private method using the Invoke method of the PrivateObject class
        var result = privateObject.Invoke("SomePrivateMethod", "left", "right");

        // Assert that the result is what you expect
        Assert.AreEqual("left right", result);
    }
}

