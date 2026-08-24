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

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Represents an item returned from a vector search operation in DynamoDB.
    /// </summary>
    /// <typeparam name="T">The type of the item.</typeparam>
    public class SearchVectorsItem<T>
    {
        internal SearchVectorsItem(T instance, double? score)
        {
            this.Item = instance;
            Score = score;
        }

        /// <summary>
        /// The item returned from the search.
        /// </summary>
        public T Item { get; internal set; }

        /// <summary>
        /// The score of the item returned from the search.
        /// </summary>
        public double? Score { get; internal set; }
    }
}
