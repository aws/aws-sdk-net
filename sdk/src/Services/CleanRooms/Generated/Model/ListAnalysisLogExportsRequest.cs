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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the ListAnalysisLogExports operation.
    /// Lists analysis log exports, sorted by the most recent export. Results are paginated.
    /// Use the <c>nextToken</c> parameter to retrieve additional results.
    /// </summary>
    public partial class ListAnalysisLogExportsRequest : AmazonCleanRoomsRequest
    {
        private string _analysisIdentifier;
        private int? _maxResults;
        private string _membershipIdentifier;
        private string _nextToken;
        private AnalysisLogExportStatus _status;

        /// <summary>
        /// Gets and sets the property AnalysisIdentifier. 
        /// <para>
        /// A filter on the unique identifier of the protected query that the analysis logs were
        /// exported for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AnalysisIdentifier
        {
            get { return this._analysisIdentifier; }
            set { this._analysisIdentifier = value; }
        }

        // Check to see if AnalysisIdentifier property is set
        internal bool IsSetAnalysisIdentifier()
        {
            return this._analysisIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that are returned for an API request call. The service
        /// chooses a default number if you don't set one. The service might return a <c>nextToken</c>
        /// even if the <c>maxResults</c> value has not been met.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for the membership to list analysis log exports for. Currently
        /// accepts the membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that's used to fetch the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10240)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A filter on the status of the analysis log export.
        /// </para>
        /// </summary>
        public AnalysisLogExportStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}