using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Amazon.EC2.Model;
using Amazon;
namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Protocol tests already exists to test the marshalling and unmarshalling of request and responses in json, but they don't test very
    /// large payloads, which would trigger the logic for getting more bytes from the stream. 
    /// This class just tests the wrapper class StreamingUtf8JsonReader. 
    /// </summary>
    [TestClass]
    public class StreamingUtf8JsonReaderTests
    {
        [TestMethod]
        public void SkipsUtf8BOM()
        {
            // we can't use reflection to access the private fields of StreamingUtf8JsonReader since it is a ref struct so we have to test it this way.
            var a = Convert.ToByte('{');
            var b = Convert.ToByte('x');
            var c = Convert.ToByte(':');
            var d = Convert.ToByte('y');
            var e = Convert.ToByte('}');

            byte[] payload = new byte[] { 0xEF, 0xBB, 0xBF, a, b, c, d, e };
            MemoryStream stream = new MemoryStream(payload);
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(stream);
            while (reader.Read())
            {
                Assert.IsTrue(reader.Reader.TokenType == JsonTokenType.StartObject);
                return;
            }
        }

        // This method tests that if the json token starts in one buffer but continues into the next buffer
        // the reader can handle parsing it correctly.
        [TestMethod]
        public void StreamingUtf8JsonReaderHandlesJsonTokenThatSpansMultipleBuffers()
        {
            // Arrange
            // here we're creating a json string that is greater than the default buffer size to test the GetMoreBytesFromStream logic
            var sb = new StringBuilder();
            sb.Append("{ \"key\": \"");
            var size = 4096 + 500;
            sb.Append(new string('x', size));
            sb.Append("\" }");
            string largeJson = sb.ToString();

            byte[] payload = Encoding.UTF8.GetBytes(largeJson);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                string key = null, value = null;

                while (reader.Read())
                {
                    if (reader.Reader.TokenType == JsonTokenType.PropertyName)
                    {
                        key = reader.Reader.GetString();
                    }
                    else if (reader.Reader.TokenType == JsonTokenType.String)
                    {
                        value = reader.Reader.GetString();
                    }
                }
                Assert.AreEqual<string>("key", key);
                Assert.AreEqual<string>(new string('x', size), value);
            }
        }

        [TestMethod]
        public void StreamingUtf8JsonReaderHandlesNormalPayload()
        {
            // Arrange
            var sb = new StringBuilder();
            sb.Append("{ \"key\": \"");
            sb.Append(new string('x', 1));
            sb.Append("\" }");
            string largeJson = sb.ToString();

            byte[] payload = Encoding.UTF8.GetBytes(largeJson);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                string key = null, value = null;

                while (reader.Read())
                {
                    if (reader.Reader.TokenType == JsonTokenType.PropertyName)
                    {
                        key = reader.Reader.GetString();
                    }
                    else if (reader.Reader.TokenType == JsonTokenType.String)
                    {
                        value = reader.Reader.GetString();
                    }
                }
                Assert.AreEqual<string>("key", key);
                Assert.AreEqual<string>(new string('x', 1), value);
            }
        }

        [TestMethod]
        public void StreamingUtf8JsonReaderHandlesExactBufferSize()
        {
            var sb = new StringBuilder();
            // everything other than the 'x' is 13 bytes
            var size = 4096 - 13;
            sb.Append("{ \"key\": \"");
            sb.Append(new string('x', size));
            sb.Append("\" }");
            string largeJson = sb.ToString();
            Assert.AreEqual<int>(4096, Encoding.UTF8.GetByteCount(largeJson));


            byte[] payload = Encoding.UTF8.GetBytes(largeJson);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                string key = null, value = null;

                while (reader.Read())
                {
                    if (reader.Reader.TokenType == JsonTokenType.PropertyName)
                    {
                        key = reader.Reader.GetString();
                    }
                    else if (reader.Reader.TokenType == JsonTokenType.String)
                    {
                        value = reader.Reader.GetString();
                    }
                }
                Assert.AreEqual<string>("key", key);
                Assert.AreEqual<string>(new string('x', size), value);
            }
        }

        [TestMethod]
        public void StreamingUtf8JsonReaderHandlesBufferSizePlusOne()
        {
            var sb = new StringBuilder();
            // everything other than the 'x' is 13 bytes
            var size = 4096 - 13 + 1;
            sb.Append("{ \"key\": \"");
            sb.Append(new string('x', size));
            sb.Append("\" }");
            string largeJson = sb.ToString();


            byte[] payload = Encoding.UTF8.GetBytes(largeJson);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                string key = null, value = null;

                while (reader.Read())
                {
                    if (reader.Reader.TokenType == JsonTokenType.PropertyName)
                    {
                        key = reader.Reader.GetString();
                    }
                    else if (reader.Reader.TokenType == JsonTokenType.String)
                    {
                        value = reader.Reader.GetString();
                    }
                }
                Assert.AreEqual<string>("key", key);
                Assert.AreEqual<string>(new string('x', size), value);
            }
        }

        [TestMethod]
        public void StreamingUtf8JsonReaderHandlesBufferSizeMinusOne()
        {
            var sb = new StringBuilder();
            // everything other than the 'x' is 13 bytes
            var size = 4096 - 13 - 1;
            sb.Append("{ \"key\": \"");
            sb.Append(new string('x', size));
            sb.Append("\" }");
            string largeJson = sb.ToString();


            byte[] payload = Encoding.UTF8.GetBytes(largeJson);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                string key = null, value = null;

                while (reader.Read())
                {
                    if (reader.Reader.TokenType == JsonTokenType.PropertyName)
                    {
                        key = reader.Reader.GetString();
                    }
                    else if (reader.Reader.TokenType == JsonTokenType.String)
                    {
                        value = reader.Reader.GetString();
                    }
                }
                Assert.AreEqual<string>("key", key);
                Assert.AreEqual<string>(new string('x', size), value);
            }
        }
    }
}
