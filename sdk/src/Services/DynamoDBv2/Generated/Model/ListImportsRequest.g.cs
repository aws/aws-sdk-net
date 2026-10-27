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
    /// Container for the parameters to the ListImports operation. Lists completed imports
    /// within the past 90 days.
    /// </summary>
    public partial class ListImportsRequest : AmazonDynamoDBRequest
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An optional string that, if supplied, must be copied from the output of a previous
        /// call to <c>ListImports</c>. When provided in this manner, the API fetches the next
        /// page of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 112, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        ///  The number of <c>ImportSummary </c>objects returned in a single page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) associated with the table that was imported to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TableArn { get; set; }

        /// <summary>
        /// Checks to see if the TableArn property is set.
        /// </summary>
        internal bool IsSetTableArn() => this.TableArn != null;
    }
}
