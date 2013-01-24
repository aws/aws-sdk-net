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
using System.Collections.Generic;

using Amazon.DynamoDB.Model;

namespace Amazon.DynamoDB.DocumentModel
{
    /// <summary>
    /// Configuration for the Table.PutItem operation
    /// </summary>
    public class PutItemOperationConfig
    {
        /// <summary>
        /// Document representing the expected state
        /// </summary>
        public Document Expected { get; set; }

        /// <summary>
        /// Flag specifying what values should be returned.
        /// 
        /// PutItem only supports ReturnValues.AllOldAttributes and ReturnValues.None
        /// </summary>
        public ReturnValues ReturnValues { get; set; }
    }

    /// <summary>
    /// Configuration for the Table.GetItem operation
    /// </summary>
    public class GetItemOperationConfig
    {
        /// <summary>
        /// List of attributes to retrieve
        /// </summary>
        public List<string> AttributesToGet { get; set; }

        /// <summary>
        /// If set to true, this flag ensures that the most recently written data is
        /// returned.
        /// </summary>
        public bool ConsistentRead { get; set; }
    }

    /// <summary>
    /// Configuration for the Table.UpdateItem operation
    /// </summary>
    public class UpdateItemOperationConfig
    {
        /// <summary>
        /// Document representing the expected state
        /// </summary>
        public Document Expected { get; set; }

        /// <summary>
        /// Flag specifying what values should be returned.
        /// </summary>
        public ReturnValues ReturnValues { get; set; }
    }

    /// <summary>
    /// Configuration for the Table.DeleteItem operation
    /// </summary>
    public class DeleteItemOperationConfig
    {
        /// <summary>
        /// Document representing the expected state
        /// </summary>
        public Document Expected { get; set; }

        /// <summary>
        /// Flag specifying what values should be returned.
        /// 
        /// DeleteItem only supports ReturnValues.AllOldAttributes and ReturnValues.None
        /// </summary>
        public ReturnValues ReturnValues { get; set; }
    }

    /// <summary>
    /// Configuration for the Table.Scan operation
    /// </summary>
    public class ScanOperationConfig
    {
        /// <summary>
        /// Initializes a default Table.Scan config object
        /// Filter is empty, Limit is Int32.MaxValue
        /// </summary>
        public ScanOperationConfig()
        {
            Filter = new ScanFilter();
            Limit = Int32.MaxValue;
        }

        /// <summary>
        /// List of attributes to retrieve as part of the search
        /// </summary>
        public List<string> AttributesToGet { get; set; }

        /// <summary>
        /// Upper limit on the number of items scanned per request
        /// for matching conditions.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Filter for the search operation
        /// </summary>
        public ScanFilter Filter { get; set; }
    }

    /// <summary>
    /// Configuration for the Table.Query operation
    /// </summary>
    public class QueryOperationConfig
    {
        /// <summary>
        /// Initializes a default Table.Query config object
        /// Filter is empty, Limit is Int32.MaxValue
        /// </summary>
        public QueryOperationConfig()
        {
            Filter = new RangeFilter();
            Limit = Int32.MaxValue;
        }

        /// <summary>
        /// HashKey value associated with the search
        /// </summary>
        public Primitive HashKey { get; set; }

        /// <summary>
        /// Filter for the search operation
        /// </summary>
        public RangeFilter Filter { get; set; }

        /// <summary>
        /// If set to true, this flag ensures that the most recently written data is
        /// returned.
        /// </summary>
        public bool ConsistentRead { get; set; }

        /// <summary>
        /// List of attributes to retrieve as part of the search
        /// </summary>
        public List<string> AttributesToGet { get; set; }

        /// <summary>
        /// Upper limit on the number of items to return per request
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Flag that signals if the search is traversing backwards
        /// </summary>
        public bool BackwardSearch { get; set; }
    }
}
