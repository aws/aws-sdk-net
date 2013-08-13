/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.DynamoDB.Model
{
    /// <summary>Query Result
    /// </summary>
    public class QueryResult  
    {
        
        private List<Dictionary<string,AttributeValue>> items = new List<Dictionary<string,AttributeValue>>();
        private int? count;
        private Key lastEvaluatedKey;
        private double? consumedCapacityUnits;
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
        /// Number of items in the response.
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
        /// Primary key of the item where the query operation stopped, inclusive of the previous result set. Use this value to start a new operation
        /// excluding this value in the new request. The <c>LastEvaluatedKey</c> is null when the entire query result set is complete (i.e. the
        /// operation processed the "last page").
        ///  
        /// </summary>
        public Key LastEvaluatedKey
        {
            get { return this.lastEvaluatedKey; }
            set { this.lastEvaluatedKey = value; }
        }

        /// <summary>
        /// Sets the LastEvaluatedKey property
        /// </summary>
        /// <param name="lastEvaluatedKey">The value to set for the LastEvaluatedKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryResult WithLastEvaluatedKey(Key lastEvaluatedKey)
        {
            this.lastEvaluatedKey = lastEvaluatedKey;
            return this;
        }
            

        // Check to see if LastEvaluatedKey property is set
        internal bool IsSetLastEvaluatedKey()
        {
            return this.lastEvaluatedKey != null;       
        }

        /// <summary>
        /// The number of Capacity Units of the provisioned throughput of the table consumed during the operation. <c>GetItem</c>, <c>BatchGetItem</c>,
        /// <c>BatchWriteItem</c>, <c>Query</c>, and <c>Scan</c> operations consume <c>ReadCapacityUnits</c>, while <c>PutItem</c>, <c>UpdateItem</c>,
        /// and <c>DeleteItem</c> operations consume <c>WriteCapacityUnits</c>.
        ///  
        /// </summary>
        public double ConsumedCapacityUnits
        {
            get { return this.consumedCapacityUnits ?? default(double); }
            set { this.consumedCapacityUnits = value; }
        }

        /// <summary>
        /// Sets the ConsumedCapacityUnits property
        /// </summary>
        /// <param name="consumedCapacityUnits">The value to set for the ConsumedCapacityUnits property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryResult WithConsumedCapacityUnits(double consumedCapacityUnits)
        {
            this.consumedCapacityUnits = consumedCapacityUnits;
            return this;
        }
            

        // Check to see if ConsumedCapacityUnits property is set
        internal bool IsSetConsumedCapacityUnits()
        {
            return this.consumedCapacityUnits.HasValue;       
        }
    }
}
