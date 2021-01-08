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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetOpsSummary operation.
    /// View a summary of OpsItems based on specified filters and aggregators.
    /// </summary>
    public partial class GetOpsSummaryRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<OpsAggregator> _aggregators = new List<OpsAggregator>();
        private List<OpsFilter> _filters = new List<OpsFilter>();
        private int? _maxResults;
        private string _nextToken;
        private List<OpsResultAttribute> _resultAttributes = new List<OpsResultAttribute>();
        private string _syncName;

        /// <summary>
        /// Gets and sets the property Aggregators. 
        /// <para>
        /// Optional aggregators that return counts of OpsItems based on one or more expressions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public List<OpsAggregator> Aggregators
        {
            get { return this._aggregators; }
            set { this._aggregators = value; }
        }

        // Check to see if Aggregators property is set
        internal bool IsSetAggregators()
        {
            return this._aggregators != null && this._aggregators.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Optional filters used to scope down the returned OpsItems. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<OpsFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// A token to start the list. Use this token to get the next set of results. 
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
        /// Gets and sets the property ResultAttributes. 
        /// <para>
        /// The OpsItem data type to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<OpsResultAttribute> ResultAttributes
        {
            get { return this._resultAttributes; }
            set { this._resultAttributes = value; }
        }

        // Check to see if ResultAttributes property is set
        internal bool IsSetResultAttributes()
        {
            return this._resultAttributes != null && this._resultAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SyncName. 
        /// <para>
        /// Specify the name of a resource data sync to get.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SyncName
        {
            get { return this._syncName; }
            set { this._syncName = value; }
        }

        // Check to see if SyncName property is set
        internal bool IsSetSyncName()
        {
            return this._syncName != null;
        }

    }
}