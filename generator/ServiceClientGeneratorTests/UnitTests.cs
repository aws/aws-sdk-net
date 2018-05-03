using ServiceClientGenerator;
using System;
using System.Collections.Generic;
using Xunit;

namespace ServiceClientGeneratorTests
{
    [Trait("Category", "UnitTests")]
    public class UnitTests
    {
        // This goes serviceAbbreviation : serviceFullName : serviceId
        static readonly IList<Tuple<string, string, string>> serviceIDMetadata = new List<Tuple<string, string, string>>();

        public UnitTests()
        {
            serviceIDMetadata.Add(Tuple.Create("Amazon EC2", "Amazon Elastic Compute Cloud", "EC2"));
            serviceIDMetadata.Add(Tuple.Create("AWS IoT", string.Empty, "IoT"));
            serviceIDMetadata.Add(Tuple.Create(string.Empty, "Amazon DynamoDB Streams", "DynamoDB Streams"));
            serviceIDMetadata.Add(Tuple.Create("Route 53", "Amazon Route 53", "Route 53"));
            serviceIDMetadata.Add(Tuple.Create(string.Empty, "AWS Import/Export", "ImportExport"));
        }
        [Fact]
        public void TestDetermineServiceId()
        {
            foreach (var tuple in serviceIDMetadata)
            {
                Assert.Equal(tuple.Item3, Utils.DetermineServiceId(tuple.Item1, tuple.Item2));
            }
        }
    }
}
