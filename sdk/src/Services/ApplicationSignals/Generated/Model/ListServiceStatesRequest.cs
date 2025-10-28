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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the ListServiceStates operation.
    /// Retrieves the current state information for services monitored by Application Signals.
    /// Service states include health status, recent change events, and other operational
    /// metadata.
    /// 
    ///  
    /// <para>
    /// You can filter results by time range, AWS account, and service attributes to focus
    /// on specific services or time periods. This operation supports pagination and can include
    /// data from linked accounts.
    /// </para>
    /// </summary>
    public partial class ListServiceStatesRequest : AmazonApplicationSignalsRequest
    {
        private List<AttributeFilter> _attributeFilters = AWSConfigs.InitializeCollections ? new List<AttributeFilter>() : null;
        private string _awsAccountId;
        private DateTime? _endTime;
        private bool? _includeLinkedAccounts;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AttributeFilters. 
        /// <para>
        /// An array of attribute filters to narrow down the service states returned. Each filter
        /// specifies an attribute name and the values to match against.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<AttributeFilter> AttributeFilters
        {
            get { return this._attributeFilters; }
            set { this._attributeFilters = value; }
        }

        // Check to see if AttributeFilters property is set
        internal bool IsSetAttributeFilters()
        {
            return this._attributeFilters != null && (this._attributeFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID to filter service states. If specified, only service states from
        /// this account will be returned. If not specified, service states from the current account
        /// (and linked accounts if enabled) are returned.
        /// </para>
        /// </summary>
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time for the service states query. Only service states before this time will
        /// be included. Specify the time as the number of milliseconds since January 1, 1970,
        /// 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IncludeLinkedAccounts. 
        /// <para>
        /// Specifies whether to include service states from linked AWS accounts in the results.
        /// Set to <c>true</c> to include linked accounts, or <c>false</c> to only include the
        /// current account. Defaults to <c>false</c>.
        /// </para>
        /// </summary>
        public bool IncludeLinkedAccounts
        {
            get { return this._includeLinkedAccounts.GetValueOrDefault(); }
            set { this._includeLinkedAccounts = value; }
        }

        // Check to see if IncludeLinkedAccounts property is set
        internal bool IsSetIncludeLinkedAccounts()
        {
            return this._includeLinkedAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of service states to return in a single request. Valid range is
        /// 1 to 100. If not specified, defaults to 50.
        /// </para>
        /// </summary>
        [AWSProperty(Max=250)]
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
        /// The token for the next set of results. Use this token to retrieve additional pages
        /// of service states when the result set is large.
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
        /// The start time for the service states query. Only service states from this time onward
        /// will be included. Specify the time as the number of milliseconds since January 1,
        /// 1970, 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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