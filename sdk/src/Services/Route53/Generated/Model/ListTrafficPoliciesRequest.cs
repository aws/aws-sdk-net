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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListTrafficPolicies operation.
    /// Gets information about the latest version for every traffic policy that is associated
    /// with the current Amazon Web Services account. Policies are listed in the order that
    /// they were created in. 
    /// 
    ///  
    /// <para>
    /// For information about how of deleting a traffic policy affects the response from <c>ListTrafficPolicies</c>,
    /// see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_DeleteTrafficPolicy.html">DeleteTrafficPolicy</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class ListTrafficPoliciesRequest : AmazonRoute53Request
    {
        private string _trafficPolicyIdMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property TrafficPolicyIdMarker. 
        /// <para>
        /// (Conditional) For your first request to <c>ListTrafficPolicies</c>, don't include
        /// the <c>TrafficPolicyIdMarker</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have more traffic policies than the value of <c>MaxItems</c>, <c>ListTrafficPolicies</c>
        /// returns only the first <c>MaxItems</c> traffic policies. To get the next group of
        /// policies, submit another request to <c>ListTrafficPolicies</c>. For the value of <c>TrafficPolicyIdMarker</c>,
        /// specify the value of <c>TrafficPolicyIdMarker</c> that was returned in the previous
        /// response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
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
        /// return in response to this request. If you have more than <c>MaxItems</c> traffic
        /// policies, the value of <c>IsTruncated</c> in the response is <c>true</c>, and the
        /// value of <c>TrafficPolicyIdMarker</c> is the ID of the first traffic policy that Route
        /// 53 will return if you submit another request.
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