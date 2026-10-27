/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// This is the response object from the ListTables operation.
    /// </summary>
    public partial class ListTablesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LastEvaluatedTableName. 
        /// <para>
        /// The name of the last table in the current page of results. Use this value as the <c>ExclusiveStartTableName</c>
        /// in a new request to obtain the next page of results, until all the table names are
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// If you do not receive a <c>LastEvaluatedTableName</c> value in the response, this
        /// means that there are no more table names to be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string LastEvaluatedTableName { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluatedTableName property is set.
        /// </summary>
        internal bool IsSetLastEvaluatedTableName() => this.LastEvaluatedTableName != null;

        /// <summary>
        /// Gets and sets the property TableNames. 
        /// <para>
        /// The names of the tables associated with the current account at the current endpoint.
        /// The maximum size of this array is 100.
        /// </para>
        ///  
        /// <para>
        /// If <c>LastEvaluatedTableName</c> also appears in the output, you can use this value
        /// as the <c>ExclusiveStartTableName</c> parameter in a subsequent <c>ListTables</c>
        /// request and obtain the next page of results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TableNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TableNames property is set.
        /// </summary>
        internal bool IsSetTableNames() => this.TableNames != null && (this.TableNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
