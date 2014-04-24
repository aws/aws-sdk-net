/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents the output of a <i>Query</i> operation.</para>
    /// </summary>
    public partial class QueryResult
    {
        
        private List<Dictionary<string,AttributeValue>> items = new List<Dictionary<string,AttributeValue>>();
        private int? count;
        private int? scannedCount;
        private Dictionary<string,AttributeValue> lastEvaluatedKey = new Dictionary<string,AttributeValue>();
        private ConsumedCapacity consumedCapacity;

        /// <summary>
        /// An array of item attributes that match the query criteria. Each element in this array consists of an attribute name and the value for that
        /// attribute.
        ///  
        /// </summary>
        public List<Dictionary<string,AttributeValue>> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }
        /// <summary>
        /// Adds elements to the Items collection
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryResult WithItems(params Dictionary<string,AttributeValue>[] items)
        {
            foreach (Dictionary<string,AttributeValue> element in items)
            {
                this.items.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Items collection
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryResult WithItems(IEnumerable<Dictionary<string,AttributeValue>> items)
        {
            foreach (Dictionary<string,AttributeValue> element in items)
            {
                this.items.Add(element);
            }

            return this;
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this.items.Count > 0;
        }

        /// <summary>
        /// The number of items in the response.
        ///  
        /// </summary>
        public int Count
        {
            get { return this.count ?? default(int); }
            set { this.count = value; }
        }

        /// <summary>
        /// Sets the Count property
        /// </summary>
        /// <param name="count">The value to set for the Count property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryResult WithCount(int count)
        {
            this.count = count;
            return this;
        }
            

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this.count.HasValue;
        }

        /// <summary>
        /// The number of items in the complete query, before any filters are applied. A high <i>ScannedCount</i> value with few, or no, <i>Count</i>
        /// results indicates an inefficient <i>Query</i> operation. For more information, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html#Count">Count and ScannedCount</a> in the Amazon
        /// DynamoDB Developer Guide.
        ///  
        /// </summary>
        public int ScannedCount
        {
            get { return this.scannedCount ?? default(int); }
            set { this.scannedCount = value; }
        }

        /// <summary>
        /// Sets the ScannedCount property
        /// </summary>
        /// <param name="scannedCount">The value to set for the ScannedCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryResult WithScannedCount(int scannedCount)
        {
            this.scannedCount = scannedCount;
            return this;
        }
            

        // Check to see if ScannedCount property is set
        internal bool IsSetScannedCount()
        {
            return this.scannedCount.HasValue;
        }

        /// <summary>
        /// The primary key of the item where the operation stopped, inclusive of the previous result set. Use this value to start a new operation,
        /// excluding this value in the new request. If <i>LastEvaluatedKey</i> is null, then the "last page" of results has been processed and there is
        /// no more data to be retrieved. If <i>LastEvaluatedKey</i> is anything other than null, this does not necessarily mean that there is more data
        /// in the result set. The only way to know when you have reached the end of the result set is when <i>LastEvaluatedKey</i> is null.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> LastEvaluatedKey
        {
            get { return this.lastEvaluatedKey; }
            set { this.lastEvaluatedKey = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the LastEvaluatedKey dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the LastEvaluatedKey dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryResult WithLastEvaluatedKey(params KeyValuePair<string, AttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, AttributeValue> pair in pairs)
            {
                this.LastEvaluatedKey[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if LastEvaluatedKey property is set
        internal bool IsSetLastEvaluatedKey()
        {
            return this.lastEvaluatedKey != null;
        }

        /// <summary>
        /// Represents the capacity units consumed by an operation. The data returned includes the total provisioned throughput consumed, along with
        /// statistics for the table and any indexes involved in the operation. <i>ConsumedCapacity</i> is only returned if it was asked for in the
        /// request. For more information, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ProvisionedThroughputIntro.html">Provisioned Throughput</a> in the
        /// Amazon DynamoDB Developer Guide.
        ///  
        /// </summary>
        public ConsumedCapacity ConsumedCapacity
        {
            get { return this.consumedCapacity; }
            set { this.consumedCapacity = value; }
        }

        /// <summary>
        /// Sets the ConsumedCapacity property
        /// </summary>
        /// <param name="consumedCapacity">The value to set for the ConsumedCapacity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryResult WithConsumedCapacity(ConsumedCapacity consumedCapacity)
        {
            this.consumedCapacity = consumedCapacity;
            return this;
        }
            

        // Check to see if ConsumedCapacity property is set
        internal bool IsSetConsumedCapacity()
        {
            return this.consumedCapacity != null;
        }
    }
}
