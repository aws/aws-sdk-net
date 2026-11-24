/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime.Internal.Endpoints;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class BddEvaluatorTests
    {
        private const int ResultOffset = 100_000_000;

        // Returns a pre-set bool per condition index, so the traversal is tested without any real Fn evaluation.
        private sealed class StubConditions : IBddConditionEvaluator<object>
        {
            private readonly Dictionary<int, bool> _results;
            public int EvaluatedCount { get; private set; }

            public StubConditions(Dictionary<int, bool> results)
            {
                _results = results;
            }

            public bool EvaluateCondition(int conditionIndex, object context)
            {
                EvaluatedCount++;
                return _results[conditionIndex];
            }
        }

        private static string EncodeNodes(params int[] nodes)
        {
            var bytes = new byte[nodes.Length * 4];
            for (int i = 0; i < nodes.Length; i++)
            {
                BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(i * 4), nodes[i]);
            }
            return Convert.ToBase64String(bytes);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void Decode_KnownBytes_ReadsBigEndianInt32Triples()
        {
            var expected = new[] { 5, ResultOffset + 2, -1 };
            CollectionAssert.AreEqual(expected, BddNodeDecoder.Decode(EncodeNodes(expected)));
            Assert.AreEqual(0, BddNodeDecoder.Decode("").Length);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [DataRow(true, false, 7, 1)]
        [DataRow(false, true, 1, 2)]
        [DataRow(false, false, 5, 2)]
        public void Evaluate_FollowsBranchesAndComplementedEdges(bool condition0, bool condition1, int expectedResult, int expectedEvaluations)
        {
            var nodes = BddNodeDecoder.Decode(EncodeNodes(
                -1, 1, -1,
                0, ResultOffset + 7, -3,
                1, ResultOffset + 5, ResultOffset + 1));
            var conditions = new StubConditions(new Dictionary<int, bool> { { 0, condition0 }, { 1, condition1 } });

            Assert.AreEqual(expectedResult, BddEvaluator.Evaluate<object>(nodes, 2, conditions, null));
            Assert.AreEqual(expectedEvaluations, conditions.EvaluatedCount);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        [DataRow(1, 0)]
        [DataRow(-1, 0)]
        [DataRow(ResultOffset + 42, 42)]
        public void Evaluate_TerminalAndResultRoots_ResolveWithoutEvaluatingConditions(int root, int expectedResult)
        {
            var conditions = new StubConditions(new Dictionary<int, bool>());

            Assert.AreEqual(expectedResult, BddEvaluator.Evaluate<object>(Array.Empty<int>(), root, conditions, null));
            Assert.AreEqual(0, conditions.EvaluatedCount);
        }
    }
}
