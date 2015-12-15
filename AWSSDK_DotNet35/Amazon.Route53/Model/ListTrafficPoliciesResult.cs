/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the response information for the request.
    /// </summary>
    public partial class ListTrafficPoliciesResult : AmazonWebServiceResponse
    {
        private List<TrafficPolicySummary> _trafficPolicySummaries = new List<TrafficPolicySummary>();
        private bool? _isTruncated;
        private string _trafficPolicyIdMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property TrafficPolicySummaries. 
        /// <para>
        /// A list that contains one <code>TrafficPolicySummary</code> element for each traffic
        /// policy that was created by the current AWS account.
        /// </para>
        /// </summary>
        public List<TrafficPolicySummary> TrafficPolicySummaries
        {
            get { return this._trafficPolicySummaries; }
            set { this._trafficPolicySummaries = value; }
        }

        // Check to see if TrafficPolicySummaries property is set
        internal bool IsSetTrafficPolicySummaries()
        {
            return this._trafficPolicySummaries != null && this._trafficPolicySummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more traffic policies to be listed. If the
        /// response was truncated, you can get the next group of <code>MaxItems</code> traffic
        /// policies by calling <code>ListTrafficPolicies</code> again and specifying the value
        /// of the <code>TrafficPolicyIdMarker</code> element in the <code>TrafficPolicyIdMarker</code>
        /// request parameter.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code>
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyIdMarker. 
        /// <para>
        /// If the value of <code>IsTruncated</code> is <code>true</code>, <code>TrafficPolicyIdMarker</code>
        /// is the ID of the first traffic policy in the next group of <code>MaxItems</code> traffic
        /// policies.
        /// </para>
        /// </summary>
        public string TrafficPolicyIdMarker
        {
            get { return this._trafficPolicyIdMarker; }
            set { this._trafficPolicyIdMarker = value; }
        }

        // Check to see if TrafficPolicyIdMarker property is set
        internal bool IsSetTrafficPolicyIdMarker()
        {
            return this._trafficPolicyIdMarker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for the <code>MaxItems</code> parameter in the call to
        /// <code>ListTrafficPolicies</code> that produced the current response.
        /// </para>
        /// </summary>
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}