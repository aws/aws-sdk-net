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

        /// <summary>
        /// Scripted condition evaluator which returns a pre-set bool per condition
        /// index so tests exercise BddEvaluator traversal without any real Fn evaluation.
        /// </summary>
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
            var decoded = BddNodeDecoder.Decode(EncodeNodes(expected));
            CollectionAssert.AreEqual(expected, decoded);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void Decode_EmptyString_ReturnsEmptyArray()
        {
            var decoded = BddNodeDecoder.Decode("");
            Assert.AreEqual(0, decoded.Length);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void Evaluate_ConditionTrue_FollowsHighBranch()
        {
            var nodes = BddNodeDecoder.Decode(EncodeNodes(
                -1, 1, -1,
                0, ResultOffset + 7, ResultOffset + 3));
            var conditions = new StubConditions(new Dictionary<int, bool> { { 0, true } });

            var result = BddEvaluator.Evaluate<object>(nodes, 2, conditions, null);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void Evaluate_ConditionFalse_FollowsLowBranch()
        {
            var nodes = BddNodeDecoder.Decode(EncodeNodes(
                -1, 1, -1,
                0, ResultOffset + 7, ResultOffset + 3));
            var conditions = new StubConditions(new Dictionary<int, bool> { { 0, false } });

            var result = BddEvaluator.Evaluate<object>(nodes, 2, conditions, null);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void Evaluate_ComplementRoot_SwapsBranches()
        {
            var nodes = BddNodeDecoder.Decode(EncodeNodes(
                -1, 1, -1,
                0, ResultOffset + 7, ResultOffset + 3));
            var conditions = new StubConditions(new Dictionary<int, bool> { { 0, true } });

            var result = BddEvaluator.Evaluate<object>(nodes, -2, conditions, null);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void Evaluate_TrueTerminalRoot_ReturnsZeroNoMatchRule()
        {
            // Terminal refs are never dereferenced, Evaluate returns 0
            var conditions = new StubConditions(new Dictionary<int, bool>());

            var result = BddEvaluator.Evaluate<object>(Array.Empty<int>(), 1, conditions, null);

            Assert.AreEqual(0, result);
            Assert.AreEqual(0, conditions.EvaluatedCount); // no condition evaluated for a terminal
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void Evaluate_FalseTerminalRoot_ReturnsZeroNoMatchRule()
        {
            var conditions = new StubConditions(new Dictionary<int, bool>());

            var result = BddEvaluator.Evaluate<object>(Array.Empty<int>(), -1, conditions, null);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void Evaluate_ResultRefRoot_ReturnsDecodedIndexWithoutEvaluating()
        {
            // A root that is already a result reference resolves directly to its index
            var conditions = new StubConditions(new Dictionary<int, bool>());

            var result = BddEvaluator.Evaluate<object>(Array.Empty<int>(), ResultOffset + 42, conditions, null);

            Assert.AreEqual(42, result);
            Assert.AreEqual(0, conditions.EvaluatedCount);
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void Evaluate_MultiHop_WalksToNextNodeBeforeResult()
        {
            var nodes = BddNodeDecoder.Decode(EncodeNodes(
                -1, 1, -1,
                0, 3, ResultOffset + 9,
                1, ResultOffset + 5, ResultOffset + 1));
            var conditions = new StubConditions(new Dictionary<int, bool> { { 0, true }, { 1, true } });

            var result = BddEvaluator.Evaluate<object>(nodes, 2, conditions, null);

            Assert.AreEqual(5, result);
            Assert.AreEqual(2, conditions.EvaluatedCount); // both nodes visited
        }
    }
}
