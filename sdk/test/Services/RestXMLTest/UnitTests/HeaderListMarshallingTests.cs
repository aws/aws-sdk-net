using Amazon.RestXMLTest;
using Amazon.RestXMLTest.Model;
using Amazon.RestXMLTest.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AWSSDK.UnitTests.RestJsonTest
{
    [TestClass]
    public class HeaderListMarshallingTests
    {
        private const string ExpectedStringHeaderKey = "x-amz-content-language";
        private const string ExpectedEnumHeaderKey = "x-amz-content-language-as-enums";

        [TestMethod]
        public void SimpleStrings()
        {
            var marshaller = new TestOperationRequestMarshaller();
            var request = new TestOperationRequest();
            request.ContentLanguage = new List<string>(new[] { "English", "French", "German" });

            var internalRequest = marshaller.Marshall(request);

            Assert.IsTrue(internalRequest.Headers.ContainsKey(ExpectedStringHeaderKey));
            Assert.AreEqual("English,French,German", internalRequest.Headers[ExpectedStringHeaderKey]);
        }

        [TestMethod]
        public void EscapedStrings()
        {
            var marshaller = new TestOperationRequestMarshaller();
            var request = new TestOperationRequest();
            request.ContentLanguage = new List<string>(new[] { "\"English\"", "French,German", "'German'" });

            var internalRequest = marshaller.Marshall(request);

            Assert.IsTrue(internalRequest.Headers.ContainsKey(ExpectedStringHeaderKey));
            Assert.AreEqual("\"\\\"English\\\"\",\"French,German\",'German'", internalRequest.Headers[ExpectedStringHeaderKey]);
        }

        [TestMethod]
        public void Enums()
        {
            var marshaller = new TestOperationRequestMarshaller();
            var request = new TestOperationRequest();
            request.ContentLanguageEnums = new List<string> { LanguageEnum.English, LanguageEnum.French, LanguageEnum.German };

            var internalRequest = marshaller.Marshall(request);

            Assert.IsTrue(internalRequest.Headers.ContainsKey(ExpectedEnumHeaderKey));
            Assert.AreEqual("English,French,German", internalRequest.Headers[ExpectedEnumHeaderKey]);
        }
    }
}
