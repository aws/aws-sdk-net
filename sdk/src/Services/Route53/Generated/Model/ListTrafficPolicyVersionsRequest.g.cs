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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListTrafficPolicyVersions operation. Gets information
    /// about all of the versions for a specified traffic policy. <para> Traffic policy versions
    /// are listed in numerical order by <c>VersionNumber</c>. </para>
    /// </summary>
    public partial class ListTrafficPolicyVersionsRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Specify the value of <c>Id</c> of the traffic policy for which you want to list all
        /// versions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property TrafficPolicyVersionMarker. 
        /// <para>
        /// For your first request to <c>ListTrafficPolicyVersions</c>, don't include the <c>TrafficPolicyVersionMarker</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have more traffic policy versions than the value of <c>MaxItems</c>, <c>ListTrafficPolicyVersions</c>
        /// returns only the first group of <c>MaxItems</c> versions. To get more traffic policy
        /// versions, submit another <c>ListTrafficPolicyVersions</c> request. For the value of
        /// <c>TrafficPolicyVersionMarker</c>, specify the value of <c>TrafficPolicyVersionMarker</c>
        /// in the previous response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public string TrafficPolicyVersionMarker { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyVersionMarker property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyVersionMarker() => this.TrafficPolicyVersionMarker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of traffic policy versions that you want Amazon Route 53 to include
        /// in the response body for this request. If the specified traffic policy has more than
        /// <c>MaxItems</c> versions, the value of <c>IsTruncated</c> in the response is <c>true</c>,
        /// and the value of the <c>TrafficPolicyVersionMarker</c> element is the ID of the first
        /// version that Route 53 will return if you submit another request.
        /// </para>
        /// </summary>
        public string MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems != null;
    }
}
