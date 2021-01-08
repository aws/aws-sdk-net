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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the response information for the request.
    /// </summary>
    public partial class ListTrafficPolicyVersionsResponse : AmazonWebServiceResponse
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
        [AWSProperty(Required=true)]
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
        /// response was truncated, you can get the next group of traffic policies by submitting
        /// another <code>ListTrafficPolicyVersions</code> request and specifying the value of
        /// <code>NextMarker</code> in the <code>marker</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// identifies the first traffic policy that Amazon Route 53 will return if you submit
        /// another request. Call <code>ListTrafficPolicyVersions</code> again and specify the
        /// value of <code>TrafficPolicyVersionMarker</code> in the <code>TrafficPolicyVersionMarker</code>
        /// request parameter.
        /// </para>
        ///  
        /// <para>
        /// This element is present only if <code>IsTruncated</code> is <code>true</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4)]
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
        /// The value that you specified for the <code>maxitems</code> parameter in the <code>ListTrafficPolicyVersions</code>
        /// request that produced the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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