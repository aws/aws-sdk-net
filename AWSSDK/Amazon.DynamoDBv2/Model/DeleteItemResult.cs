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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents the output of a <i>DeleteItem</i> operation.</para>
    /// </summary>
    public class DeleteItemResult
    {
        
        private Dictionary<string,AttributeValue> attributes = new Dictionary<string,AttributeValue>();
        private ConsumedCapacity consumedCapacity;
        private ItemCollectionMetrics itemCollectionMetrics;

        /// <summary>
        /// A map of attribute names to <i>AttributeValue</i> objects, representing the item as it appeared before the <i>DeleteItem</i> operation. This
        /// map appears in the response only if <i>ReturnValues</i> was specified as <c>ALL_OLD</c> in the request.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Attributes dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Attributes dictionary.</param>
        /// <returns>this instance</returns>
        public DeleteItemResult WithAttributes(params KeyValuePair<string, AttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, AttributeValue> pair in pairs)
            {
                this.Attributes[pair.Key] = pair.Value;
            }

            return this;
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
        /// <i>Amazon DynamoDB Developer Guide</i>.
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
        public DeleteItemResult WithConsumedCapacity(ConsumedCapacity consumedCapacity)
        {
            this.consumedCapacity = consumedCapacity;
            return this;
        }
            

        // Check to see if ConsumedCapacity property is set
        internal bool IsSetConsumedCapacity()
        {
            return this.consumedCapacity != null;
        }

        /// <summary>
        /// Information about item collections, if any, that were affected by the operation. <i>ItemCollectionMetrics</i> is only returned if it was
        /// asked for in the request. If the table does not have any secondary indexes, this information is not returned in the response. Each
        /// <i>ItemCollectionMetrics</i> element consists of: <ul> <li><i>ItemCollectionKey</i> - The hash key value of the item collection. This is the
        /// same as the hash key of the item.</li> <li><i>SizeEstimateRange</i> - An estimate of item collection size, measured in gigabytes. This is a
        /// two-element array containing a lower bound and an upper bound for the estimate. The estimate includes the size of all the items in the
        /// table, plus the size of all attributes projected into all of the secondary indexes on that table. Use this estimate to measure whether a
        /// secondary index is approaching its size limit. The estimate is subject to change over time; therefore, do not rely on the precision or
        /// accuracy of the estimate. </li> </ul>
        ///  
        /// </summary>
        public ItemCollectionMetrics ItemCollectionMetrics
        {
            get { return this.itemCollectionMetrics; }
            set { this.itemCollectionMetrics = value; }
        }

        /// <summary>
        /// Sets the ItemCollectionMetrics property
        /// </summary>
        /// <param name="itemCollectionMetrics">The value to set for the ItemCollectionMetrics property </param>
        /// <returns>this instance</returns>
        public DeleteItemResult WithItemCollectionMetrics(ItemCollectionMetrics itemCollectionMetrics)
        {
            this.itemCollectionMetrics = itemCollectionMetrics;
            return this;
        }
            

        // Check to see if ItemCollectionMetrics property is set
        internal bool IsSetItemCollectionMetrics()
        {
            return this.itemCollectionMetrics != null;
        }
    }
}
