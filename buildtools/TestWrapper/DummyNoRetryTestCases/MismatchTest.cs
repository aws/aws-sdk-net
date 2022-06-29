using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCases
{
    [TestClass]
    public class MismatchTest
    {

        [DataTestMethod]
        public void SignatureMismatch()
        {
            throw new Exception("The request signature we calculated does not match the signature you provided.");
        }
    }
}
