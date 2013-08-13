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
    /// Container for the parameters to the BatchWriteItem operation.
    /// <para>Allows to execute a batch of Put and/or Delete Requests for many tables in a single call. A total of 25 requests are allowed.</para>
    /// <para>There are no transaction guarantees provided by this API. It does not allow conditional puts nor does it support return values.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.BatchWriteItem"/>
    public class BatchWriteItemRequest : AmazonWebServiceRequest
    {
        private Dictionary<string,List<WriteRequest>> requestItems = new Dictionary<string,List<WriteRequest>>();

        /// <summary>
        /// A map of table name to list-of-write-requests. Used as input to the <c>BatchWriteItem</c> API call
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 25</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Dictionary<string,List<WriteRequest>> RequestItems
        {
            get { return this.requestItems; }
            set { this.requestItems = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the RequestItems dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the RequestItems dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BatchWriteItemRequest WithRequestItems(params KeyValuePair<string, List<WriteRequest>>[] pairs)
        {
            foreach (KeyValuePair<string, List<WriteRequest>> pair in pairs)
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
    
