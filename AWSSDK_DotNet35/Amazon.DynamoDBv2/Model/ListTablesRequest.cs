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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the ListTables operation.
    /// <para>Returns an array of all the tables associated with the current account and endpoint. </para>
    /// </summary>
    public partial class ListTablesRequest : AmazonDynamoDBv2Request
    {
        private string exclusiveStartTableName;
        private int? limit;


        /// <summary>
        /// The name of the table that starts the list. If you already ran a <i>ListTables</i> operation and received a <i>LastEvaluatedTableName</i>
        /// value in the response, use that value here to continue the list.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ExclusiveStartTableName
        {
            get { return this.exclusiveStartTableName; }
            set { this.exclusiveStartTableName = value; }
        }

        // Check to see if ExclusiveStartTableName property is set
        internal bool IsSetExclusiveStartTableName()
        {
            return this.exclusiveStartTableName != null;
        }

        /// <summary>
        /// A maximum number of table names to return.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;
        }

    }
}
    
