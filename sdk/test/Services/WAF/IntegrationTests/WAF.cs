using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.WAF;
using Amazon.WAF.Model;
using Amazon;
using System.Text;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class WAF : TestBase<AmazonWAFClient>
    {

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("WAF")]
        public void TestByteMatchSet()
        {
            var token1 = Client.GetChangeToken().ChangeToken;
            var token2 = Client.GetChangeToken().ChangeToken;
            Assert.AreEqual(token1, token2);

            var tokenStatus = Client.GetChangeTokenStatus(token1).ChangeTokenStatus;

            var setName = "BMS-net-test-" + DateTime.Now.ToFileTime();
            var tupleTargetString = "aws";
            var tuple = new ByteMatchTuple
            {
                FieldToMatch = new FieldToMatch
                {
                    Data = "User-Agent",
                    Type = MatchFieldType.HEADER
                },
                TargetString = tupleTargetString,
                PositionalConstraint = PositionalConstraint.STARTS_WITH,
                TextTransformation = TextTransformation.NONE
            };
            Assert.IsNotNull(tuple.TargetStream);
            Assert.AreEqual(tupleTargetString, Encoding.UTF8.GetString(tuple.TargetStream.ToArray()));

            var createResponse = Client.CreateByteMatchSet(setName, Client.GetChangeToken().ChangeToken);
            var createdSet = createResponse.ByteMatchSet;
            var changeToken = createResponse.ChangeToken;

            var sets = GetAllbyteMatchSets().ToList();
            var foundSet = sets.SingleOrDefault(s => string.Equals(s.ByteMatchSetId, createdSet.ByteMatchSetId, StringComparison.Ordinal));
            Assert.IsNotNull(foundSet);

            var retrievedSet = Client.GetByteMatchSet(createdSet.ByteMatchSetId).ByteMatchSet;
            Assert.IsNotNull(retrievedSet);
            Assert.AreEqual(createdSet.ByteMatchSetId, retrievedSet.ByteMatchSetId);
            Assert.AreEqual(createdSet.Name, retrievedSet.Name);
            Assert.AreEqual(createdSet.ByteMatchTuples.Count, retrievedSet.ByteMatchTuples.Count);

            Client.UpdateByteMatchSet(
                createdSet.ByteMatchSetId,
                new List<ByteMatchSetUpdate>
                {
                    new ByteMatchSetUpdate
                    {
                        Action = ChangeAction.INSERT,
                        ByteMatchTuple = tuple
                    }
                },
                Client.GetChangeToken().ChangeToken);

            retrievedSet = Client.GetByteMatchSet(createdSet.ByteMatchSetId).ByteMatchSet;
            Assert.IsNotNull(retrievedSet);
            Assert.AreEqual(createdSet.ByteMatchSetId, retrievedSet.ByteMatchSetId);
            Assert.AreEqual(createdSet.Name, retrievedSet.Name);
            Assert.AreEqual(1, retrievedSet.ByteMatchTuples.Count);
            Assert.AreEqual(tuple.TargetString, retrievedSet.ByteMatchTuples[0].TargetString);

            Client.UpdateByteMatchSet(
                createdSet.ByteMatchSetId,
                new List<ByteMatchSetUpdate>
                {
                    new ByteMatchSetUpdate
                    {
                        Action = ChangeAction.DELETE,
                        ByteMatchTuple = tuple
                    }
                },
                Client.GetChangeToken().ChangeToken);

            Client.DeleteByteMatchSet(createdSet.ByteMatchSetId, Client.GetChangeToken().ChangeToken);

            sets = GetAllbyteMatchSets().ToList();
            foundSet = sets.SingleOrDefault(s => string.Equals(s.ByteMatchSetId, createdSet.ByteMatchSetId, StringComparison.Ordinal));
            Assert.IsNull(foundSet);
        }

        private static IEnumerable<ByteMatchSetSummary> GetAllbyteMatchSets()
        {
            var request = new ListByteMatchSetsRequest { Limit = 1 };
            do
            {
                var response = Client.ListByteMatchSets(request);
                request.NextMarker = response.NextMarker;
                foreach (var set in response.ByteMatchSets)
                    yield return set;
            } while (!string.IsNullOrEmpty(request.NextMarker));
        }
    }
}
