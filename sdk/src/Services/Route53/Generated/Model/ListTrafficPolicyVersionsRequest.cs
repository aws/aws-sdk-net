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
    /// Container for the parameters to the ListTrafficPolicyVersions operation.
    /// Gets information about all of the versions for a specified traffic policy.
    /// 
    ///  
    /// <para>
    /// Traffic policy versions are listed in numerical order by <code>VersionNumber</code>.
    /// </para>
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
        [AWSProperty(Required=true, Min=1, Max=36)]
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
        /// For your first request to <code>ListTrafficPolicyVersions</code>, don't include the
        /// <code>TrafficPolicyVersionMarker</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have more traffic policy versions than the value of <code>MaxItems</code>,
        /// <code>ListTrafficPolicyVersions</code> returns only the first group of <code>MaxItems</code>
        /// versions. To get more traffic policy versions, submit another <code>ListTrafficPolicyVersions</code>
        /// request. For the value of <code>TrafficPolicyVersionMarker</code>, specify the value
        /// of <code>TrafficPolicyVersionMarker</code> in the previous response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4)]
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
        /// <code>MaxItems</code> versions, the value of <code>IsTruncated</code> in the response
        /// is <code>true</code>, and the value of the <code>TrafficPolicyVersionMarker</code>
        /// element is the ID of the first version that Route 53 will return if you submit another
        /// request.
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