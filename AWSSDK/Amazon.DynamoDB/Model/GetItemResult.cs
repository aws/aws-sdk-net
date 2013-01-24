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
    /// <summary>Get Item Result
    /// </summary>
    public class GetItemResult  
    {
        
        private Dictionary<string,AttributeValue> item = new Dictionary<string,AttributeValue>();
        private double? consumedCapacityUnits;

        /// <summary>
        /// Contains the requested attributes.
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
        public GetItemResult WithConsumedCapacityUnits(double consumedCapacityUnits)
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
