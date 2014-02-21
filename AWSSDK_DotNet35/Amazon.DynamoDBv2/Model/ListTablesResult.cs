/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents the output of a <i>ListTables</i> operation.</para>
    /// </summary>
    public partial class ListTablesResult : AmazonWebServiceResponse
    {
        
        private List<string> tableNames = new List<string>();
        private string lastEvaluatedTableName;


        /// <summary>
        /// The names of the tables associated with the current account at the current endpoint. The maximum size of this array is 100. If
        /// <i>LastEvaluatedTableName</i> also appears in the output, you can use this value as the <i>ExclusiveStartTableName</i> parameter in a
        /// subsequent <i>ListTables</i> request and obtain the next page of results.
        ///  
        /// </summary>
        public List<string> TableNames
        {
            get { return this.tableNames; }
            set { this.tableNames = value; }
        }

        // Check to see if TableNames property is set
        internal bool IsSetTableNames()
        {
            return this.tableNames.Count > 0;
        }

        /// <summary>
        /// The name of the last table in the current page of results. Use this value as the <i>ExclusiveStartTableName</i> in a new request to obtain
        /// the next page of results, until all the table names are returned. If you do not receive a <i>LastEvaluatedTableName</i> value in the
        /// response, this means that there are no more table names to be retrieved.
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
        public string LastEvaluatedTableName
        {
            get { return this.lastEvaluatedTableName; }
            set { this.lastEvaluatedTableName = value; }
        }

        // Check to see if LastEvaluatedTableName property is set
        internal bool IsSetLastEvaluatedTableName()
        {
            return this.lastEvaluatedTableName != null;
        }
    }
}
