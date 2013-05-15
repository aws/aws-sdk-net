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
    /// <para>Represents the output of a <i>GetItem</i> operation.</para>
    /// </summary>
    public class GetItemResult
    {
        
        private Dictionary<string,AttributeValue> item = new Dictionary<string,AttributeValue>();
        private ConsumedCapacity consumedCapacity;

        /// <summary>
        /// A map of attribute names to <i>AttributeValue</i> objects, as specified by <i>AttributesToGet</i>.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> Item
        {
            get { return this.item; }
            set { this.item = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Item dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Item dictionary.</param>
        /// <returns>this instance</returns>
        public GetItemResult WithItem(params KeyValuePair<string, AttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, AttributeValue> pair in pairs)
            {
                this.Item[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Item property is set
        internal bool IsSetItem()
        {
            return this.item != null;
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
        public GetItemResult WithConsumedCapacity(ConsumedCapacity consumedCapacity)
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
