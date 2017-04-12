using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using AWSSDK_DotNet35.UnitTests;
using ThirdParty.Json.LitJson;
using System;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class LitJsonModificationTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void EmptyListTest()
        {
            string emptyListJson =
@"{
    ""emptyList"" : []
}";
            JsonData data = JsonMapper.ToObject(emptyListJson);
            string propertyName = data.PropertyNames.ToArray<string>()[0];

            Assert.AreEqual<string>(propertyName, "emptyList");
            Assert.IsTrue(data[propertyName].IsArray);
            Assert.IsTrue(data[propertyName].Count == 0);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void IntLongConversionTest()
        {
            string numberJson =
@"{
    ""Int""   : 13,
    ""UInt""  : 4294967295,
    ""Long""  : 4294967296,
    ""ULong"" : 18446744073709551615
}";
            JsonData data = JsonMapper.ToObject(numberJson);

            Assert.AreEqual<int>(13, (int)data["Int"]);
            Assert.AreEqual<uint>(4294967295, (uint)data["UInt"]);
            Assert.AreEqual<long>(4294967296, (long)data["Long"]);
            Assert.AreEqual<ulong>(18446744073709551615, (ulong)data["ULong"]);

            Assert.AreEqual<long>(13, (long)data["Int"]);
            Assert.AreEqual<ulong>(4294967295, (ulong)data["UInt"]);

            Utils.AssertExceptionExpected(() => { int t = (int)data["Long"]; });
            Utils.AssertExceptionExpected(() => { int t = (int)data["UInt"]; });
            Utils.AssertExceptionExpected(() => { int t = (int)data["ULong"]; });
            Utils.AssertExceptionExpected(() => { uint t = (uint)data["ULong"]; });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void IsNumberTypeTest()
        {
            string numberJson =
@"{
    ""Zero""   : 0,
    ""PInt""   : 2147483647,
    ""NInt""   : -2147483648,
    ""UInt""   : 4294967295,
    ""Long""   : 4294967296,
    ""PLong""  : 9223372036854775807,
    ""NLong""  : -9223372036854775808, 
    ""ULong""  : 18446744073709551615,
    ""Double"" : 0.0,
    ""PDouble"": 1.7976931348623157E+308,
    ""NDouble"": -1.7976931348623157E+308
}";
            JsonData data = JsonMapper.ToObject(numberJson);

            Assert.IsTrue(data["Zero"].IsInt);
            Assert.IsTrue(data["PInt"].IsInt);
            Assert.IsTrue(data["NInt"].IsInt);
            Assert.IsTrue(data["UInt"].IsUInt);

            Assert.IsTrue(data["Long"].IsLong);
            Assert.IsTrue(data["PLong"].IsLong);
            Assert.IsTrue(data["NLong"].IsLong);
            Assert.IsTrue(data["ULong"].IsULong);

            Assert.IsTrue(data["Double"].IsDouble);
            Assert.IsTrue(data["PDouble"].IsDouble);
            Assert.IsTrue(data["NDouble"].IsDouble);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void MapAndCompareTest()
    
        {
            var sb = new StringBuilder();
            var writer = new JsonWriter(sb) { PrettyPrint = true };
            string jsonDocument =
@"{
    ""Zero""   : 0,
    ""PInt""   : 2147483647,
    ""NInt""   : -2147483648,
    ""UInt""   : 4294967295,
    ""Long""   : 4294967296,
    ""PLong""  : 9223372036854775807,
    ""NLong""  : -9223372036854775808, 
    ""ULong""  : 18446744073709551615,
    ""Double"" : 0.0,
    ""PDouble"": 1.7976931348623157E+308,
    ""NDouble"": -1.7976931348623157E+308
}";
            JsonData jsonOriginal = JsonMapper.ToObject(jsonDocument);
            JsonMapper.ToJson(jsonOriginal, writer);
            string jsonDcoumentGenerated  = sb.ToString();

            JsonData jsonNew = JsonMapper.ToObject(jsonDcoumentGenerated);

            foreach (string property in jsonOriginal.PropertyNames)
            {
                jsonOriginal[property].Equals(jsonNew[property]);
                Assert.AreEqual(jsonOriginal[property].ToString(), jsonNew[property].ToString());
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ConstructorAndEqualTest()
        {
            int signedInteger = 47472;
            long signedLong = 47472;
            Assert.IsTrue(new JsonData(signedInteger).Equals(new JsonData(signedInteger)));
            Assert.IsTrue(new JsonData(signedInteger).Equals(new JsonData(signedLong)));
            Assert.IsTrue(new JsonData(signedLong).Equals(new JsonData(signedLong)));

            uint unsignedInteger = 474722;
            ulong unsignedLong = 474722;
            Assert.IsTrue(new JsonData(unsignedInteger).Equals(new JsonData(unsignedInteger)));
            Assert.IsTrue(new JsonData(unsignedInteger).Equals(new JsonData(unsignedLong)));
            Assert.IsTrue(new JsonData(unsignedLong).Equals(new JsonData(unsignedLong)));

            long signedLongBig = 829496729622;
            Assert.IsTrue(new JsonData(signedLongBig).Equals(new JsonData(signedLongBig)));

            ulong unsignedLongBig = 829496729622;
            Assert.IsTrue(new JsonData(unsignedLongBig).Equals(new JsonData(unsignedLongBig)));
        }
    }
}
