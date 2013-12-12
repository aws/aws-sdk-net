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
    /// <para>Represents the output of an <i>UpdateItem</i> operation.</para>
    /// </summary>
    public partial class UpdateItemResult : AmazonWebServiceResponse
    {
        
        private Dictionary<string,AttributeValue> attributes = new Dictionary<string,AttributeValue>();
        private ConsumedCapacity consumedCapacity;
        private ItemCollectionMetrics itemCollectionMetrics;


        /// <summary>
        /// A map of attribute values as they appeared before the <i>UpdateItem</i> operation, but only if <i>ReturnValues</i> was specified as
        /// something other than <c>NONE</c> in the request. Each element represents one attribute.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
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

        /// <summary>
        /// Information about item collections, if any, that were affected by the operation. <i>ItemCollectionMetrics</i> is only returned if it was
        /// asked for in the request. If the table does not have any secondary indexes, this information is not returned in the response.
        ///  
        /// </summary>
        public ItemCollectionMetrics ItemCollectionMetrics
        {
            get { return this.itemCollectionMetrics; }
            set { this.itemCollectionMetrics = value; }
        }

        // Check to see if ItemCollectionMetrics property is set
        internal bool IsSetItemCollectionMetrics()
        {
            return this.itemCollectionMetrics != null;
        }
    }
}
