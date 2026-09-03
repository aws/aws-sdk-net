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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApplicationStatusChecks operation.
    /// Describes application status checks, including configuration details such as protocol,
    /// port, path, thresholds, and associations. Results are paginated. Use the <c>NextToken</c>
    /// parameter to retrieve additional results. The following rules apply:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If you do not specify any application status check IDs, all checks in your account
    /// are returned.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>DescribeApplicationStatus</c> to see the actual health status of instances.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeApplicationStatusChecksRequest : AmazonEC2Request
    {
        private List<string> _applicationStatusCheckIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private bool? _includeAll;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApplicationStatusCheckIds. 
        /// <para>
        /// The IDs of the application status checks to describe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApplicationStatusCheckIds
        {
            get { return this._applicationStatusCheckIds; }
            set { this._applicationStatusCheckIds = value; }
        }

        // Check to see if ApplicationStatusCheckIds property is set
        internal bool IsSetApplicationStatusCheckIds()
        {
            return this._applicationStatusCheckIds != null && (this._applicationStatusCheckIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aggregation</c> – The aggregation setting. Valid values: <c>included</c> and <c>excluded</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeAll. 
        /// <para>
        /// Specifies whether to include recently deleted application status checks that remain
        /// available during the deletion grace period. If you omit this parameter or set it to
        /// <c>false</c>, the response includes only active checks.
        /// </para>
        /// </summary>
        public bool? IncludeAll
        {
            get { return this._includeAll; }
            set { this._includeAll = value; }
        }

        // Check to see if IncludeAll property is set
        internal bool IsSetIncludeAll()
        {
            return this._includeAll.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=100)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
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

    }
}