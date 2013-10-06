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
    /// <summary>
    /// <para>A container for a Put BatchWrite request</para>
    /// </summary>
    public class PutRequest  
    {
        
        private Dictionary<string,AttributeValue> item = new Dictionary<string,AttributeValue>();

        /// <summary>
        /// The item to put
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutRequest WithItem(params KeyValuePair<string, AttributeValue>[] pairs)
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
    }
}
