using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class DocumentJsonTests
    {
        [TestMethod]
        public void FromJson_Decimal()
        {
            var json = $@"
            {{
                ""min"": {decimal.MinValue},
                ""max"": {decimal.MaxValue},
                ""zero"": {decimal.Zero},
                ""one"": {decimal.One},
                ""17digits"": 1584097275961.1234
            }}";
            
            var doc = Document.FromJson(json);

            Assert.AreEqual(decimal.MinValue, doc["min"].AsDecimal());
            Assert.AreEqual(decimal.MaxValue, doc["max"].AsDecimal());
            Assert.AreEqual(decimal.Zero, doc["zero"].AsDecimal());
            Assert.AreEqual(decimal.One, doc["one"].AsDecimal());
            Assert.AreEqual(1584097275961.1234m, doc["17digits"].AsDecimal());
        }

        [TestMethod]
        public void ToJson_Decimal()
        {
            var document = new Document();
            document["min"] = decimal.MinValue;
            document["max"] = decimal.MaxValue;
            document["zero"] = decimal.Zero;
            document["one"] = decimal.One;
            document["17digits"] = 1584097275961.1234m;

            var json = document.ToJsonPretty();

            var expectedJson = $@"{{
  ""min"": {decimal.MinValue},
  ""max"": {decimal.MaxValue},
  ""zero"": {decimal.Zero},
  ""one"": {decimal.One},
  ""17digits"": 1584097275961.1234
}}";

            Assert.AreEqual(expectedJson, json);
        }

        [TestMethod]
        public void FromJson_Double()
        {
            var json = $@"
            {{
                ""min"": {double.MinValue.ToString("G17")},
                ""max"": {double.MaxValue.ToString("G17")},
                ""zero"": 0,
                ""one"": 1.0,
                ""17digits"": 1584097275961.1234
            }}";

            var doc = Document.FromJson(json);

            Assert.AreEqual(double.MinValue, doc["min"].AsDouble());
            Assert.AreEqual(double.MaxValue, doc["max"].AsDouble());
            Assert.AreEqual(0.0, doc["zero"].AsDouble());
            Assert.AreEqual(1.0, doc["one"].AsDouble());
            Assert.AreEqual(1584097275961.1234d, doc["17digits"].AsDouble());
        }

        [TestMethod]
        public void ToJson_Double()
        {
            var document = new Document();
            document["min"] = double.MinValue;
            document["max"] = double.MaxValue;
            document["zero"] = 0.0;
            document["one"] = 1.0;
            document["17digits"] = 1584097275961.1234d; // because we're forcing this to a double, we're expecting it to lose precision

            var json = document.ToJsonPretty();

            var expectedJson = $@"{{
  ""min"": {double.MinValue.ToString("G17")},
  ""max"": {double.MaxValue.ToString("G17")},
  ""zero"": 0,
  ""one"": 1,
  ""17digits"": 1584097275961.1233
}}";
            Assert.AreEqual(expectedJson, json);
        }

            [TestMethod]
        public void FromJson_Int()
        {
            var json = $@"
            {{
                ""min"": {int.MinValue:G17},
                ""max"": {int.MaxValue.ToString("G17")},
                ""zero"": 0,
                ""one"": 1
            }}";

            var doc = Document.FromJson(json);

            Assert.AreEqual(int.MinValue, doc["min"].AsInt());
            Assert.AreEqual(int.MaxValue, doc["max"].AsInt());
            Assert.AreEqual(0, doc["zero"].AsInt());
            Assert.AreEqual(1, doc["one"].AsInt());
        }

        [TestMethod]
        public void ToJson_Int()
        {
            var document = new Document();
            document["min"] = int.MinValue;
            document["max"] = int.MaxValue;
            document["zero"] = 0;
            document["one"] = 1;

            var json = document.ToJsonPretty();

            var expectedJson = $@"{{
  ""min"": {int.MinValue.ToString("G17")},
  ""max"": {int.MaxValue.ToString("G17")},
  ""zero"": 0,
  ""one"": 1
}}";

            Assert.AreEqual(expectedJson, json);
        }

        [TestMethod]
        public void FromJson_Long()
        {
            var json = $@"
            {{
                ""key"": 9223372036854775806
            }}";

            var doc = Document.FromJson(json);

            Assert.AreEqual(9223372036854775806, (long)doc["key"]);
        }

        [TestMethod]
        public void ToJson_Long()
        {
            var longValue = long.MaxValue - 100;
            var document = new Document();
            document["key"] = longValue;

            var json = document.ToJsonPretty();

            var expectedJson = $@"{{
  ""key"": {longValue}
}}";

            Assert.AreEqual(expectedJson, json);
        }
    }
}
