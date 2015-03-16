/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// A strongly-typed interface for retrieving search results (Query or Scan)
    /// from DynamoDB.
    /// </summary>
    public partial interface IAsyncSearch
    {
        /// <summary>
        /// Flag that, if true, indicates that the search is done
        /// </summary>
        bool IsDone { get; }
    }
}
