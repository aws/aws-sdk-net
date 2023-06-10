using System;
using NUnit.Framework;

namespace TestCases
{
    public class MismatchTest
    {

        [Test]
        public void SignatureMismatch()
        {
            throw new Exception("The request signature we calculated does not match the signature you provided.");
        }
    }
}
