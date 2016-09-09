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
    /// Container for the parameters to the ListTrafficPolicyVersions operation.
    /// Gets information about all of the versions for a specified traffic policy.
    /// 
    ///  
    /// <para>
    /// Send a <code>GET</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicy</code>
    /// resource and specify the ID of the traffic policy for which you want to list versions.
    /// </para>
    ///  
    /// <para>
    /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
    /// of traffic policies, you can use the <code>maxitems</code> parameter to list them
    /// in groups of up to 100.
    /// </para>
    ///  
    /// <para>
    /// The response includes three values that help you navigate from one group of <code>maxitems</code>maxitems
    /// traffic policies to the next:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>IsTruncated</b> 
    /// </para>
    ///  
    /// <para>
    /// If the value of <code>IsTruncated</code> in the response is <code>true</code>, there
    /// are more traffic policy versions associated with the specified traffic policy.
    /// </para>
    ///  
    /// <para>
    /// If <code>IsTruncated</code> is <code>false</code>, this response includes the last
    /// traffic policy version that is associated with the specified traffic policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>TrafficPolicyVersionMarker</b> 
    /// </para>
    ///  
    /// <para>
    /// The ID of the next traffic policy version that is associated with the current AWS
    /// account. If you want to list more traffic policies, make another call to <code>ListTrafficPolicyVersions</code>,
    /// and specify the value of the <code>TrafficPolicyVersionMarker</code> element in the
    /// <code>TrafficPolicyVersionMarker</code> request parameter.
    /// </para>
    ///  
    /// <para>
    /// If <code>IsTruncated</code> is <code>false</code>, Amazon Route 53 omits the <code>TrafficPolicyVersionMarker</code>
    /// element from the response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>MaxItems</b> 
    /// </para>
    ///  
    /// <para>
    /// The value that you specified for the <code>MaxItems</code> parameter in the request
    /// that produced the current response.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListTrafficPolicyVersionsRequest : AmazonRoute53Request
    {
        private string _id;
        private string _trafficPolicyVersionMarker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Specify the value of <code>Id</code> of the traffic policy for which you want to list
        /// all versions.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyVersionMarker. 
        /// <para>
        /// For your first request to <code>ListTrafficPolicyVersions</code>, do not include the
        /// <code>TrafficPolicyVersionMarker</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have more traffic policy versions than the value of <code>MaxItems</code>,
        /// <code>ListTrafficPolicyVersions</code> returns only the first group of <code>MaxItems</code>
        /// versions. To get the next group of <code>MaxItems</code> traffic policy versions,
        /// submit another request to <code>ListTrafficPolicyVersions</code>. For the value of
        /// <code>TrafficPolicyVersionMarker</code>, specify the value of the <code>TrafficPolicyVersionMarker</code>
        /// element that was returned in the previous response.
        /// </para>
        ///  
        /// <para>
        /// Traffic policy versions are listed in sequential order.
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
        /// The maximum number of traffic policy versions that you want Amazon Route 53 to include
        /// in the response body for this request. If the specified traffic policy has more than
        /// <code>MaxItems</code> versions, the value of the <code>IsTruncated</code> element
        /// in the response is <code>true</code>, and the value of the <code>TrafficPolicyVersionMarker</code>
        /// element is the ID of the first version in the next group of <code>MaxItems</code>
        /// traffic policy versions.
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