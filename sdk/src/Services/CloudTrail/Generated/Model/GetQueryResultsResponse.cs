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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
        private string _errorMessage;
        private string _nextToken;
        private List<List<Dictionary<string, string>>> _queryResultRows = AWSConfigs.InitializeCollections ? new List<List<Dictionary<string, string>>>() : null;
        private QueryStatistics _queryStatistics;
        private QueryStatus _queryStatus;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message returned if a query failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1000)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token you can use to get the next page of query results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property QueryResultRows. 
        /// <para>
        /// Contains the individual event results of the query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<Dictionary<string, string>>> QueryResultRows
        {
            get { return this._queryResultRows; }
            set { this._queryResultRows = value; }
        }

        // Check to see if QueryResultRows property is set
        internal bool IsSetQueryResultRows()
        {
            return this._queryResultRows != null && (this._queryResultRows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryStatistics. 
        /// <para>
        /// Shows the count of query results.
        /// </para>
        /// </summary>
        public QueryStatistics QueryStatistics
        {
            get { return this._queryStatistics; }
            set { this._queryStatistics = value; }
        }

        // Check to see if QueryStatistics property is set
        internal bool IsSetQueryStatistics()
        {
            return this._queryStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStatus. 
        /// <para>
        /// The status of the query. Values include <c>QUEUED</c>, <c>RUNNING</c>, <c>FINISHED</c>,
        /// <c>FAILED</c>, <c>TIMED_OUT</c>, or <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        public QueryStatus QueryStatus
        {
            get { return this._queryStatus; }
            set { this._queryStatus = value; }
        }

        // Check to see if QueryStatus property is set
        internal bool IsSetQueryStatus()
        {
            return this._queryStatus != null;
        }

    }
}