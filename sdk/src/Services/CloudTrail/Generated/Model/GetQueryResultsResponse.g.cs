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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the GetQueryResults operation.
    /// </summary>
    public partial class GetQueryResultsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message returned if a query failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1000)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token you can use to get the next page of query results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property QueryResultRows. 
        /// <para>
        /// Contains the individual event results of the query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<Dictionary<string, string>>> QueryResultRows { get; set; } = AWSConfigs.InitializeCollections ? new List<List<Dictionary<string, string>>>() : null;

        /// <summary>
        /// Checks to see if the QueryResultRows property is set.
        /// </summary>
        internal bool IsSetQueryResultRows() => this.QueryResultRows != null && (this.QueryResultRows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryStatistics. 
        /// <para>
        /// Shows the count of query results.
        /// </para>
        /// </summary>
        public QueryStatistics QueryStatistics { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatistics property is set.
        /// </summary>
        internal bool IsSetQueryStatistics() => this.QueryStatistics != null;

        /// <summary>
        /// Gets and sets the property QueryStatus. 
        /// <para>
        /// The status of the query. Values include <c>QUEUED</c>, <c>RUNNING</c>, <c>FINISHED</c>,
        /// <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        public QueryStatus QueryStatus { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatus property is set.
        /// </summary>
        internal bool IsSetQueryStatus() => this.QueryStatus != null;
    }
}
