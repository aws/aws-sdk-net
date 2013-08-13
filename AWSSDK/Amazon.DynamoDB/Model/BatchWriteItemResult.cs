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
    /// <para>A container for <c>BatchWriteItem</c> response</para>
    /// </summary>
    public class BatchWriteItemResult  
    {
        
        private Dictionary<string,BatchWriteResponse> responses = new Dictionary<string,BatchWriteResponse>();
        private Dictionary<string,List<WriteRequest>> unprocessedItems = new Dictionary<string,List<WriteRequest>>();

        /// <summary>
        /// The response object as a result of <c>BatchWriteItem</c> call. This is essentially a map of table name to <c>ConsumedCapacityUnits</c>.
        ///  
        /// </summary>
        public Dictionary<string,BatchWriteResponse> Responses
        {
            get { return this.responses; }
            set { this.responses = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Responses dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Responses dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BatchWriteItemResult WithResponses(params KeyValuePair<string, BatchWriteResponse>[] pairs)
        {
            foreach (KeyValuePair<string, BatchWriteResponse> pair in pairs)
            {
                this.Responses[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Responses property is set
        internal bool IsSetResponses()
        {
            return this.responses != null;       
        }

        /// <summary>
        /// The Items which we could not successfully process in a <c>BatchWriteItem</c> call is returned as <c>UnprocessedItems</c>
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
        public Dictionary<string,List<WriteRequest>> UnprocessedItems
        {
            get { return this.unprocessedItems; }
            set { this.unprocessedItems = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the UnprocessedItems dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the UnprocessedItems dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BatchWriteItemResult WithUnprocessedItems(params KeyValuePair<string, List<WriteRequest>>[] pairs)
        {
            foreach (KeyValuePair<string, List<WriteRequest>> pair in pairs)
            {
                this.UnprocessedItems[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if UnprocessedItems property is set
        internal bool IsSetUnprocessedItems()
        {
            return this.unprocessedItems != null;       
        }
    }
}
