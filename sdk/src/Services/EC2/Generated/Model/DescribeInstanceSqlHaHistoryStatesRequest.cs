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
    /// Container for the parameters to the DescribeInstanceSqlHaHistoryStates operation.
    /// Describes the historical SQL Server High Availability states for Amazon EC2 instances
    /// that are enabled for Amazon EC2 High Availability for SQL Server monitoring.
    /// </summary>
    public partial class DescribeInstanceSqlHaHistoryStatesRequest : AmazonEC2Request
    {
        private DateTime? _endTime;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end data and time of the period for which to get historical SQL Server High Availability
        /// states. If omitted, the API returns historical states up to the current date and time.
        /// </para>
        ///  
        /// <para>
        /// Timezone: UTC
        /// </para>
        ///  
        /// <para>
        /// Format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c> 
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters to apply to the results. Supported filters include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tag:&lt;key&gt;</c> - The tag key and value pair assigned to the instance. For
        /// example, to find all instances tagged with <c>Owner:TeamA</c>, specify <c>tag:Owner</c>
        /// for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The tag key assigned to the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>haStatus</c> - The SQL Server High Availability status of the SQL Server High
        /// Availability instance (<c>processing</c> | <c>active</c> | <c>standby</c> | <c>invalid</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlServerLicenseUsage</c> - The license type for the SQL Server license (<c>full</c>
        /// | <c>waived</c>).
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the SQL Server High Availability instances to describe. If omitted, the
        /// API returns historical states for all SQL Server High Availability instances.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results can be seen by sending another request with the returned <c>nextToken</c>
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The token to use to retrieve the next page of results.
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

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start data and time of the period for which to get the historical SQL Server High
        /// Availability states. If omitted, the API returns all available historical states.
        /// </para>
        ///  
        /// <para>
        /// Timezone: UTC
        /// </para>
        ///  
        /// <para>
        /// Format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c> 
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}