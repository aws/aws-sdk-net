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
using Amazon.Runtime;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents the output of a <i>Scan</i> operation.</para>
    /// </summary>
    public partial class ScanResult : AmazonWebServiceResponse
    {
        
        private List<Dictionary<string,AttributeValue>> items = new List<Dictionary<string,AttributeValue>>();
        private int? count;
        private int? scannedCount;
        private Dictionary<string,AttributeValue> lastEvaluatedKey = new Dictionary<string,AttributeValue>();
        private ConsumedCapacity consumedCapacity;


        /// <summary>
        /// An array of item attributes that match the scan criteria. Each element in this array consists of an attribute name and the value for that
        /// attribute.
        ///  
        /// </summary>
        public List<Dictionary<string,AttributeValue>> Items
        {
            get { return this.items; }
            set { this.items = value; }
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

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this.count.HasValue;
        }

        /// <summary>
        /// The number of items in the complete scan, before any filters are applied. A high <i>ScannedCount</i> value with few, or no, <i>Count</i>
        /// results indicates an inefficient <i>Scan</i> operation. For more information, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html#Count">Count and ScannedCount</a> in the Amazon
        /// DynamoDB Developer Guide.
        ///  
        /// </summary>
        public int ScannedCount
        {
            get { return this.scannedCount ?? default(int); }
            set { this.scannedCount = value; }
        }

        // Check to see if ScannedCount property is set
        internal bool IsSetScannedCount()
        {
            return this.scannedCount.HasValue;
        }

        /// <summary>
        /// The primary key of the item where the operation stopped, inclusive of the previous result set. Use this value to start a new operation,
        /// excluding this value in the new request. <i>LastEvaluatedKey</i> is null when the entire result set is complete (in other words, when the
        /// operation processed the "last page" of results). If there are no remaining table or segment items to be scanned, <i>LastEvaluatedKey</i> is
        /// returned as null.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> LastEvaluatedKey
        {
            get { return this.lastEvaluatedKey; }
            set { this.lastEvaluatedKey = value; }
        }

        // Check to see if LastEvaluatedKey property is set
        internal bool IsSetLastEvaluatedKey()
        {
            return this.lastEvaluatedKey != null;
        }

        /// <summary>
        /// The table name that consumed provisioned throughput, and the number of capacity units consumed by it. <i>ConsumedCapacity</i> is only
        /// returned if it was asked for in the request. For more information, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ProvisionedThroughputIntro.html">Provisioned Throughput</a> in the
        /// Amazon DynamoDB Developer Guide.
        ///  
        /// </summary>
        public ConsumedCapacity ConsumedCapacity
        {
            get { return this.consumedCapacity; }
            set { this.consumedCapacity = value; }
        }

        // Check to see if ConsumedCapacity property is set
        internal bool IsSetConsumedCapacity()
        {
            return this.consumedCapacity != null;
        }
    }
}
