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
    /// <summary>Batch Get Item Result
    /// </summary>
    public class BatchGetItemResult  
    {
        
        private Dictionary<string,BatchResponse> responses = new Dictionary<string,BatchResponse>();
        private Dictionary<string,KeysAndAttributes> unprocessedKeys = new Dictionary<string,KeysAndAttributes>();

        /// <summary>
        /// Table names and the respective item attributes from the tables.
        ///  
        /// </summary>
        public Dictionary<string,BatchResponse> Responses
        {
            get { return this.responses; }
            set { this.responses = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Responses dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Responses dictionary.</param>
        /// <returns>this instance</returns>
        public BatchGetItemResult WithResponses(params KeyValuePair<string, BatchResponse>[] pairs)
        {
            foreach (KeyValuePair<string, BatchResponse> pair in pairs)
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
        /// Contains a map of tables and their respective keys that were not processed with the current response, possibly due to reaching a limit on
        /// the response size. The <c>UnprocessedKeys</c> value is in the same form as a <c>RequestItems</c> parameter (so the value can be provided
        /// directly to a subsequent <c>BatchGetItem</c> operation). For more information, see the above <c>RequestItems</c> parameter.
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
        public Dictionary<string,KeysAndAttributes> UnprocessedKeys
        {
            get { return this.unprocessedKeys; }
            set { this.unprocessedKeys = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the UnprocessedKeys dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the UnprocessedKeys dictionary.</param>
        /// <returns>this instance</returns>
        public BatchGetItemResult WithUnprocessedKeys(params KeyValuePair<string, KeysAndAttributes>[] pairs)
        {
            foreach (KeyValuePair<string, KeysAndAttributes> pair in pairs)
            {
                this.UnprocessedKeys[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if UnprocessedKeys property is set
        internal bool IsSetUnprocessedKeys()
        {
            return this.unprocessedKeys != null;       
        }
    }
}
