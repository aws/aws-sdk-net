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
    /// This is the response object from the ListTrafficPolicyVersions operation.
    /// </summary>
    public partial class ListTrafficPolicyVersionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property TrafficPolicies. 
        /// <para>
        /// A list that contains one <c>TrafficPolicy</c> element for each traffic policy version
        /// that is associated with the specified traffic policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TrafficPolicy> TrafficPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<TrafficPolicy>() : null;

        /// <summary>
        /// Checks to see if the TrafficPolicies property is set.
        /// </summary>
        internal bool IsSetTrafficPolicies() => this.TrafficPolicies != null && (this.TrafficPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more traffic policies to be listed. If the
        /// response was truncated, you can get the next group of traffic policies by submitting
        /// another <c>ListTrafficPolicyVersions</c> request and specifying the value of <c>NextMarker</c>
        /// in the <c>marker</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// Checks to see if the IsTruncated property is set.
        /// </summary>
        internal bool IsSetIsTruncated() => this.IsTruncated.HasValue;

        /// <summary>
        /// Gets and sets the property TrafficPolicyVersionMarker. 
        /// <para>
        /// If <c>IsTruncated</c> is <c>true</c>, the value of <c>TrafficPolicyVersionMarker</c>
        /// identifies the first traffic policy that Amazon Route 53 will return if you submit
        /// another request. Call <c>ListTrafficPolicyVersions</c> again and specify the value
        /// of <c>TrafficPolicyVersionMarker</c> in the <c>TrafficPolicyVersionMarker</c> request
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// This element is present only if <c>IsTruncated</c> is <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 4)]
        public string TrafficPolicyVersionMarker { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyVersionMarker property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyVersionMarker() => this.TrafficPolicyVersionMarker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for the <c>maxitems</c> parameter in the <c>ListTrafficPolicyVersions</c>
        /// request that produced the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems != null;
    }
}
