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
using System;

namespace Amazon.Runtime.Internal.Endpoints
{
    /// <summary>
    /// Shared BDD traversal used by generated endpoint providers to resolve
    /// an endpoint result index from a flat node array.
    /// </summary>
    public static class BddEvaluator
    {
        // Result references at or above this value encode a result index
        private const int ResultOffset = 100_000_000;

        /// <summary>
        /// Walks the BDD from the root reference, evaluating one condition per node
        /// until a terminal or result reference is reached, and returns the matched
        /// result index. 0 is the implicit NoMatchRule.
        /// </summary>
        public static int Evaluate<TContext>(
            ReadOnlySpan<int> nodes,
            int rootRef,
            IBddConditionEvaluator<TContext> conditions,
            TContext context)
        {
            var reference = rootRef;

            while (reference != 1 && reference != -1)
            {
                var absRef = Math.Abs(reference);

                if (absRef >= ResultOffset)
                {
                    return absRef - ResultOffset;
                }

                var nodeIndex = (absRef - 1) * 3;
                var conditionTrue = conditions.EvaluateCondition(nodes[nodeIndex], context);

                if (reference < 0)
                {
                    conditionTrue = !conditionTrue;
                }

                reference = conditionTrue ? nodes[nodeIndex + 1] : nodes[nodeIndex + 2];
            }

            return 0;
        }
    }
}
