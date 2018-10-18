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
    /// Container for the parameters to the ListTrafficPolicies operation.
    /// Gets information about the latest version for every traffic policy that is associated
    /// with the current AWS account. Policies are listed in the order that they were created
    /// in.
    /// </summary>
    public partial class ListTrafficPoliciesRequest : AmazonRoute53Request
    {
        private string _trafficPolicyIdMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property TrafficPolicyIdMarker. 
        /// <para>
        /// (Conditional) For your first request to <code>ListTrafficPolicies</code>, don't include
        /// the <code>TrafficPolicyIdMarker</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have more traffic policies than the value of <code>MaxItems</code>, <code>ListTrafficPolicies</code>
        /// returns only the first <code>MaxItems</code> traffic policies. To get the next group
        /// of policies, submit another request to <code>ListTrafficPolicies</code>. For the value
        /// of <code>TrafficPolicyIdMarker</code>, specify the value of <code>TrafficPolicyIdMarker</code>
        /// that was returned in the previous response.
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
        /// (Optional) The maximum number of traffic policies that you want Amazon Route 53 to
        /// return in response to this request. If you have more than <code>MaxItems</code> traffic
        /// policies, the value of <code>IsTruncated</code> in the response is <code>true</code>,
        /// and the value of <code>TrafficPolicyIdMarker</code> is the ID of the first traffic
        /// policy that Route 53 will return if you submit another request.
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