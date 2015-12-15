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
    /// with the current AWS account. To get the information, send a <code>GET</code> request
    /// to the <code>2013-04-01/trafficpolicy</code> resource.
    /// 
    ///  
    /// <para>
    /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
    /// of traffic policies, you can use the <code>maxitems</code> parameter to list them
    /// in groups of up to 100.
    /// </para>
    ///  
    /// <para>
    /// The response includes three values that help you navigate from one group of <code>maxitems</code>
    /// traffic policies to the next:
    /// </para>
    ///  <ul> <li><b>IsTruncated</b></li> 
    /// <para>
    /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
    /// are more traffic policies associated with the current AWS account.
    /// </para>
    ///  
    /// <para>
    /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
    /// traffic policy that is associated with the current account.
    /// </para>
    ///  <li><b>TrafficPolicyIdMarker</b></li> 
    /// <para>
    /// If <code>IsTruncated</code> is <code>true</code>, <code>TrafficPolicyIdMarker</code>
    /// is the ID of the first traffic policy in the next group of <code>MaxItems</code> traffic
    /// policies. If you want to list more traffic policies, make another call to <code>ListTrafficPolicies</code>,
    /// and specify the value of the <code>TrafficPolicyIdMarker</code> element from the response
    /// in the <code>TrafficPolicyIdMarker</code> request parameter.
    /// </para>
    ///  
    /// <para>
    /// If <code>IsTruncated</code> is <code>false</code>, the <code>TrafficPolicyIdMarker</code>
    /// element is omitted from the response.
    /// </para>
    ///  <li><b>MaxItems</b></li> 
    /// <para>
    /// The value that you specified for the <code>MaxItems</code> parameter in the request
    /// that produced the current response.
    /// </para>
    ///  </ul>
    /// </summary>
    public partial class ListTrafficPoliciesRequest : AmazonRoute53Request
    {
        private string _trafficPolicyIdMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property TrafficPolicyIdMarker. 
        /// <para>
        /// For your first request to <code>ListTrafficPolicies</code>, do not include the <code>TrafficPolicyIdMarker</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have more traffic policies than the value of <code>MaxItems</code>, <code>ListTrafficPolicies</code>
        /// returns only the first <code>MaxItems</code> traffic policies. To get the next group
        /// of <code>MaxItems</code> policies, submit another request to <code>ListTrafficPolicies</code>.
        /// For the value of <code>TrafficPolicyIdMarker</code>, specify the value of the <code>TrafficPolicyIdMarker</code>
        /// element that was returned in the previous response.
        /// </para>
        ///  
        /// <para>
        /// Policies are listed in the order in which they were created.
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
        /// The maximum number of traffic policies to be included in the response body for this
        /// request. If you have more than <code>MaxItems</code> traffic policies, the value of
        /// the <code>IsTruncated</code> element in the response is <code>true</code>, and the
        /// value of the <code>TrafficPolicyIdMarker</code> element is the ID of the first traffic
        /// policy in the next group of <code>MaxItems</code> traffic policies.
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