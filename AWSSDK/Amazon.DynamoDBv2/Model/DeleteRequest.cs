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
    /// <para>Represents a request to perform a <i>DeleteItem</i> operation on an item.</para>
    /// </summary>
    public class DeleteRequest
    {
        
        private Dictionary<string,AttributeValue> key = new Dictionary<string,AttributeValue>();

        /// <summary>
        /// A map of attribute name to attribute values, representing the primary key of the item to delete. All of the table's primary key attributes
        /// must be specified, and their data types must match those of the table's key schema.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Key dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Key dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteRequest WithKey(params KeyValuePair<string, AttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, AttributeValue> pair in pairs)
            {
                this.Key[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }
    }
}
