# PrivateObject
This is a simple example of one technique for accessing private methods in unit tests.

A word of warning.  the testing of private methods is considered an anti-pattern.  And rightly so.
However we don't live in a erfect world and sometimes it's just unavoidable.  

If you do need to be able to test a private method then this PrivateObject can help.

Use the following example to get started:

 
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

