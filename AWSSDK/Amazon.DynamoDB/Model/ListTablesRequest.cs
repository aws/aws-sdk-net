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
    /// Container for the parameters to the ListTables operation.
    /// <para>Retrieves a paginated list of table names created by the AWS Account of the caller in the AWS Region (e.g. <c>us-east-1</c> ).</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.ListTables"/>
    public class ListTablesRequest : AmazonWebServiceRequest
    {
        private string exclusiveStartTableName;
        private int? limit;

        /// <summary>
        /// The name of the table that starts the list. If you already ran a <c>ListTables</c> operation and received a <c>LastEvaluatedTableName</c>
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

        /// <summary>
        /// Sets the ExclusiveStartTableName property
        /// </summary>
        /// <param name="exclusiveStartTableName">The value to set for the ExclusiveStartTableName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListTablesRequest WithExclusiveStartTableName(string exclusiveStartTableName)
        {
            this.exclusiveStartTableName = exclusiveStartTableName;
            return this;
        }
            

        // Check to see if ExclusiveStartTableName property is set
        internal bool IsSetExclusiveStartTableName()
        {
            return this.exclusiveStartTableName != null;       
        }

        /// <summary>
        /// A number of maximum table names to return.
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

        /// <summary>
        /// Sets the Limit property
        /// </summary>
        /// <param name="limit">The value to set for the Limit property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListTablesRequest WithLimit(int limit)
        {
            this.limit = limit;
            return this;
        }
            

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;       
        }
    }
}
    
