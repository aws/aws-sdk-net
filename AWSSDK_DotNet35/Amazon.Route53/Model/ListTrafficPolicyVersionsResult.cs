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
    public partial class ListTrafficPolicyVersionsResult : AmazonWebServiceResponse
    {
        private List<TrafficPolicy> _trafficPolicies = new List<TrafficPolicy>();
        private bool? _isTruncated;
        private string _trafficPolicyVersionMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property TrafficPolicies. 
        /// <para>
        /// A list that contains one <code>TrafficPolicy</code> element for each traffic policy
        /// version that is associated with the specified traffic policy.
        /// </para>
        /// </summary>
        public List<TrafficPolicy> TrafficPolicies
        {
            get { return this._trafficPolicies; }
            set { this._trafficPolicies = value; }
        }

        // Check to see if TrafficPolicies property is set
        internal bool IsSetTrafficPolicies()
        {
            return this._trafficPolicies != null && this._trafficPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more traffic policies to be listed. If the
        /// response was truncated, you can get the next group of <code>maxitems</code> traffic
        /// policies by calling <code>ListTrafficPolicyVersions</code> again and specifying the
        /// value of the <code>NextMarker</code> element in the marker parameter.
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
        /// Gets and sets the property TrafficPolicyVersionMarker. 
        /// <para>
        /// If <code>IsTruncated</code> is <code>true</code>, the value of <code>TrafficPolicyVersionMarker</code>
        /// identifies the first traffic policy in the next group of <code>MaxItems</code> traffic
        /// policies. Call <code>ListTrafficPolicyVersions</code> again and specify the value
        /// of <code>TrafficPolicyVersionMarker</code> in the <code>TrafficPolicyVersionMarker</code>
        /// request parameter.
        /// </para>
        ///  
        /// <para>
        /// This element is present only if <code>IsTruncated</code> is <code>true</code>.
        /// </para>
        /// </summary>
        public string TrafficPolicyVersionMarker
        {
            get { return this._trafficPolicyVersionMarker; }
            set { this._trafficPolicyVersionMarker = value; }
        }

        // Check to see if TrafficPolicyVersionMarker property is set
        internal bool IsSetTrafficPolicyVersionMarker()
        {
            return this._trafficPolicyVersionMarker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for the <code>maxitems</code> parameter in the call to
        /// <code>ListTrafficPolicyVersions</code> that produced the current response.
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