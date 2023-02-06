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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListOutposts operation.
    /// Lists the Outposts for your Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// Use filters to return specific results. If you specify multiple filters, the results
    /// include only the resources that match all of the specified filters. For a filter where
    /// you can specify multiple values, the results include items that match any of the values
    /// that you specify for the filter.
    /// </para>
    /// </summary>
    public partial class ListOutpostsRequest : AmazonOutpostsRequest
    {
        private List<string> _availabilityZoneFilter = new List<string>();
        private List<string> _availabilityZoneIdFilter = new List<string>();
        private List<string> _lifeCycleStatusFilter = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneFilter. 
        /// <para>
        /// Filters the results by Availability Zone (for example, <code>us-east-1a</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> AvailabilityZoneFilter
        {
            get { return this._availabilityZoneFilter; }
            set { this._availabilityZoneFilter = value; }
        }

        // Check to see if AvailabilityZoneFilter property is set
        internal bool IsSetAvailabilityZoneFilter()
        {
            return this._availabilityZoneFilter != null && this._availabilityZoneFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneIdFilter. 
        /// <para>
        /// Filters the results by AZ ID (for example, <code>use1-az1</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> AvailabilityZoneIdFilter
        {
            get { return this._availabilityZoneIdFilter; }
            set { this._availabilityZoneIdFilter = value; }
        }

        // Check to see if AvailabilityZoneIdFilter property is set
        internal bool IsSetAvailabilityZoneIdFilter()
        {
            return this._availabilityZoneIdFilter != null && this._availabilityZoneIdFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LifeCycleStatusFilter. 
        /// <para>
        /// Filters the results by the lifecycle status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> LifeCycleStatusFilter
        {
            get { return this._lifeCycleStatusFilter; }
            set { this._lifeCycleStatusFilter = value; }
        }

        // Check to see if LifeCycleStatusFilter property is set
        internal bool IsSetLifeCycleStatusFilter()
        {
            return this._lifeCycleStatusFilter != null && this._lifeCycleStatusFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
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
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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