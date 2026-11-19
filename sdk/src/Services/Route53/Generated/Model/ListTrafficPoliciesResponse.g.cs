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
    /// This is the response object from the ListTrafficPolicies operation.
    /// </summary>
    public partial class ListTrafficPoliciesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property TrafficPolicySummaries. 
        /// <para>
        /// A list that contains one <c>TrafficPolicySummary</c> element for each traffic policy
        /// that was created by the current Amazon Web Services account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TrafficPolicySummary> TrafficPolicySummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<TrafficPolicySummary>() : null;

        /// <summary>
        /// Checks to see if the TrafficPolicySummaries property is set.
        /// </summary>
        internal bool IsSetTrafficPolicySummaries() => this.TrafficPolicySummaries != null && (this.TrafficPolicySummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more traffic policies to be listed. If the
        /// response was truncated, you can get the next group of traffic policies by submitting
        /// another <c>ListTrafficPolicies</c> request and specifying the value of <c>TrafficPolicyIdMarker</c>
        /// in the <c>TrafficPolicyIdMarker</c> request parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// Checks to see if the IsTruncated property is set.
        /// </summary>
        internal bool IsSetIsTruncated() => this.IsTruncated.HasValue;

        /// <summary>
        /// Gets and sets the property TrafficPolicyIdMarker. 
        /// <para>
        /// If the value of <c>IsTruncated</c> is <c>true</c>, <c>TrafficPolicyIdMarker</c> is
        /// the ID of the first traffic policy in the next group of <c>MaxItems</c> traffic policies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string TrafficPolicyIdMarker { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyIdMarker property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyIdMarker() => this.TrafficPolicyIdMarker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for the <c>MaxItems</c> parameter in the <c>ListTrafficPolicies</c>
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
