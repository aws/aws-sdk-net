using Amazon.WAF;
using Amazon.WAF.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    [TestCategory("WAF")]
    public class WAF : TestBase<AmazonWAFClient>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        public async Task TestByteMatchSet()
        {
            var token1 = (await Client.GetChangeTokenAsync()).ChangeToken;
            var token2 = (await Client.GetChangeTokenAsync()).ChangeToken;
            Assert.AreEqual(token1, token2);

            var tokenStatus = (await Client.GetChangeTokenStatusAsync(token1)).ChangeTokenStatus;
            var setName = "BMS-net-test-" + DateTime.UtcNow.ToFileTime();
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

            var createResponse = await Client.CreateByteMatchSetAsync(setName, (await Client.GetChangeTokenAsync()).ChangeToken);
            var createdSet = createResponse.ByteMatchSet;
            var changeToken = createResponse.ChangeToken;

            var sets = (await GetAllbyteMatchSets()).ToList();
            var foundSet = sets.SingleOrDefault(s => string.Equals(s.ByteMatchSetId, createdSet.ByteMatchSetId, StringComparison.Ordinal));
            Assert.IsNotNull(foundSet);

            var retrievedSet = (await Client.GetByteMatchSetAsync(createdSet.ByteMatchSetId)).ByteMatchSet;
            Assert.IsNotNull(retrievedSet);
            Assert.AreEqual(createdSet.ByteMatchSetId, retrievedSet.ByteMatchSetId);
            Assert.AreEqual(createdSet.Name, retrievedSet.Name);
            Assert.AreEqual(createdSet.ByteMatchTuples.Count, retrievedSet.ByteMatchTuples.Count);

            await Client.UpdateByteMatchSetAsync(
                createdSet.ByteMatchSetId,
                new List<ByteMatchSetUpdate>
                {
                    new ByteMatchSetUpdate
                    {
                        Action = ChangeAction.INSERT,
                        ByteMatchTuple = tuple
                    }
                },
                (await Client.GetChangeTokenAsync()).ChangeToken
            );

            retrievedSet = (await Client.GetByteMatchSetAsync(createdSet.ByteMatchSetId)).ByteMatchSet;
            Assert.IsNotNull(retrievedSet);
            Assert.AreEqual(createdSet.ByteMatchSetId, retrievedSet.ByteMatchSetId);
            Assert.AreEqual(createdSet.Name, retrievedSet.Name);
            Assert.AreEqual(1, retrievedSet.ByteMatchTuples.Count);
            Assert.AreEqual(tuple.TargetString, retrievedSet.ByteMatchTuples[0].TargetString);

            await Client.UpdateByteMatchSetAsync(
                createdSet.ByteMatchSetId,
                new List<ByteMatchSetUpdate>
                {
                    new ByteMatchSetUpdate
                    {
                        Action = ChangeAction.DELETE,
                        ByteMatchTuple = tuple
                    }
                },
                (await Client.GetChangeTokenAsync()).ChangeToken
            );

            await Client.DeleteByteMatchSetAsync(createdSet.ByteMatchSetId, (await Client.GetChangeTokenAsync()).ChangeToken);

            sets = (await GetAllbyteMatchSets()).ToList();
            foundSet = sets.SingleOrDefault(s => string.Equals(s.ByteMatchSetId, createdSet.ByteMatchSetId, StringComparison.Ordinal));
            Assert.IsNull(foundSet);
        }

        private static async Task<IEnumerable<ByteMatchSetSummary>> GetAllbyteMatchSets()
        {
            var summaries = new List<ByteMatchSetSummary>();
            var request = new ListByteMatchSetsRequest { Limit = 1 };
            do
            {
                var response = await Client.ListByteMatchSetsAsync(request);
                request.NextMarker = response.NextMarker;
                
                if (response.ByteMatchSets != null)
                {
                    summaries.AddRange(response.ByteMatchSets);
                }
            } while (!string.IsNullOrEmpty(request.NextMarker));
            return summaries;
        }
    }
}
