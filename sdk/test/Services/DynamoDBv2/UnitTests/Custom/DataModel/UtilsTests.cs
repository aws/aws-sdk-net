using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class UtilsTests
    {
        [TestMethod]
        public void ValidateTimestampType_WithNullableDateTime_DoesNotThrow()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateTimestampType(typeof(DateTime?));
        }

        [TestMethod]
        public void ValidateTimestampType_WithNullableDateTimeOffset_DoesNotThrow()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateTimestampType(typeof(DateTimeOffset?));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateTimestampType_WithDateTime_ThrowsException()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateTimestampType(typeof(DateTime));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateTimestampType_WithDateTimeOffset_ThrowsException()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateTimestampType(typeof(DateTimeOffset));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateTimestampType_WithString_ThrowsException()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateTimestampType(typeof(string));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateTimestampType_WithInt_ThrowsException()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateTimestampType(typeof(int));
        }

        [TestMethod]
        public void ValidateNumericType_WithNullableInt_DoesNotThrow()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateNumericType(typeof(int?));
        }

        [TestMethod]
        public void ValidateNumericType_WithNullableLong_DoesNotThrow()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateNumericType(typeof(long?));
        }

        [TestMethod]
        public void ValidateNumericType_WithNullableByte_DoesNotThrow()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateNumericType(typeof(byte?));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateNumericType_WithInt_ThrowsException()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateNumericType(typeof(int));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateNumericType_WithString_ThrowsException()
        {
            Amazon.DynamoDBv2.DataModel.Utils.ValidateNumericType(typeof(string));
        }
    }
}
