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
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDB.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetItem operation.
    /// <para>Retrieves the attributes for multiple items from multiple tables using their primary keys.</para> <para>The maximum number of item
    /// attributes that can be retrieved for a single operation is 100. Also, the number of items retrieved is constrained by a 1 MB the size limit.
    /// If the response size limit is exceeded or a partial result is returned due to an internal processing failure, Amazon DynamoDB returns an
    /// <c>UnprocessedKeys</c> value so you can retry the operation starting with the next item to get.</para> <para>Amazon DynamoDB automatically
    /// adjusts the number of items returned per page to enforce this limit. For example, even if you ask to retrieve 100 items, but each individual
    /// item is 50k in size, the system returns 20 items and an appropriate <c>UnprocessedKeys</c> value so you can get the next page of results. If
    /// necessary, your application needs its own logic to assemble the pages of results into one set.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.BatchGetItem"/>
    public class BatchGetItemRequest : AmazonWebServiceRequest
    {
        private Dictionary<string,KeysAndAttributes> requestItems = new Dictionary<string,KeysAndAttributes>();

        /// <summary>
        /// A map of the table name and corresponding items to get by primary key. While requesting items, each table name can be invoked only once per
        /// operation.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Dictionary<string,KeysAndAttributes> RequestItems
        {
            get { return this.requestItems; }
            set { this.requestItems = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the RequestItems dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the RequestItems dictionary.</param>
        /// <returns>this instance</returns>
        public BatchGetItemRequest WithRequestItems(params KeyValuePair<string, KeysAndAttributes>[] pairs)
        {
            foreach (KeyValuePair<string, KeysAndAttributes> pair in pairs)
            {
                this.RequestItems[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if RequestItems property is set
        internal bool IsSetRequestItems()
        {
            return this.requestItems != null;       
        }
    }
}
    
