using Xunit;
using Amazon.DynamoDBv2.Model;

namespace AWSSDK_NetStandard.UnitTests
{
    public class DynamoDBTests
    {
        [Fact]
        [Trait("Category", "DynamoDBv2.Model.AttributeValue")]
        public void AttributeValueIsBOOLSetTest()
        {
            var boolAV = new AttributeValue();
            Assert.False(boolAV.IsBOOLSet);
            Assert.False(boolAV.BOOL);

            boolAV.BOOL = false;
            Assert.True(boolAV.IsBOOLSet);
            Assert.False(boolAV.BOOL);

            boolAV.BOOL = true;
            Assert.True(boolAV.IsBOOLSet);
            Assert.True(boolAV.BOOL);

            boolAV.IsBOOLSet = true;
            Assert.True(boolAV.IsBOOLSet);
            Assert.True(boolAV.BOOL);

            boolAV.IsBOOLSet = false;
            Assert.False(boolAV.IsBOOLSet);
            Assert.False(boolAV.BOOL);
        }
    }
}
