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

using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Per-item configuration for a TransactGet operation in the object-persistence programming model.
    /// </summary>
    public class TransactGetItemConfig
    {
        /// <summary>
        /// A projection expression that identifies one or more attributes to retrieve from the item.
        /// Uses DynamoDB projection expression syntax (e.g. "Id, Title, #yr").
        /// </summary>
        public string ProjectionExpression { get; set; }

        /// <summary>
        /// Substitution tokens for attribute names in the <see cref="ProjectionExpression"/>.
        /// Use this when attribute names are reserved words in DynamoDB.
        /// </summary>
        public Dictionary<string, string> ExpressionAttributeNames { get; set; }
    }
}
