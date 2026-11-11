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
    /// This is the response object from the ListTrafficPolicyInstancesByPolicy operation.
    /// </summary>
    public partial class ListTrafficPolicyInstancesByPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property TrafficPolicyInstances. 
        /// <para>
        /// A list that contains one <c>TrafficPolicyInstance</c> element for each traffic policy
        /// instance that matches the elements in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TrafficPolicyInstance> TrafficPolicyInstances { get; set; } = AWSConfigs.InitializeCollections ? new List<TrafficPolicyInstance>() : null;

        /// <summary>
        /// Checks to see if the TrafficPolicyInstances property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyInstances() => this.TrafficPolicyInstances != null && (this.TrafficPolicyInstances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HostedZoneIdMarker. 
        /// <para>
        /// If <c>IsTruncated</c> is <c>true</c>, <c>HostedZoneIdMarker</c> is the ID of the hosted
        /// zone of the first traffic policy instance in the next group of traffic policy instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string HostedZoneIdMarker { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneIdMarker property is set.
        /// </summary>
        internal bool IsSetHostedZoneIdMarker() => this.HostedZoneIdMarker != null;

        /// <summary>
        /// Gets and sets the property TrafficPolicyInstanceNameMarker. 
        /// <para>
        /// If <c>IsTruncated</c> is <c>true</c>, <c>TrafficPolicyInstanceNameMarker</c> is the
        /// name of the first traffic policy instance in the next group of <c>MaxItems</c> traffic
        /// policy instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TrafficPolicyInstanceNameMarker { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyInstanceNameMarker property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyInstanceNameMarker() => this.TrafficPolicyInstanceNameMarker != null;

        /// <summary>
        /// Gets and sets the property TrafficPolicyInstanceTypeMarker. 
        /// <para>
        /// If <c>IsTruncated</c> is <c>true</c>, <c>TrafficPolicyInstanceTypeMarker</c> is the
        /// DNS type of the resource record sets that are associated with the first traffic policy
        /// instance in the next group of <c>MaxItems</c> traffic policy instances.
        /// </para>
        /// </summary>
        public RRType TrafficPolicyInstanceTypeMarker { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPolicyInstanceTypeMarker property is set.
        /// </summary>
        internal bool IsSetTrafficPolicyInstanceTypeMarker() => this.TrafficPolicyInstanceTypeMarker != null;

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more traffic policy instances to be listed.
        /// If the response was truncated, you can get the next group of traffic policy instances
        /// by calling <c>ListTrafficPolicyInstancesByPolicy</c> again and specifying the values
        /// of the <c>HostedZoneIdMarker</c>, <c>TrafficPolicyInstanceNameMarker</c>, and <c>TrafficPolicyInstanceTypeMarker</c>
        /// elements in the corresponding request parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// Checks to see if the IsTruncated property is set.
        /// </summary>
        internal bool IsSetIsTruncated() => this.IsTruncated.HasValue;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The value that you specified for the <c>MaxItems</c> parameter in the call to <c>ListTrafficPolicyInstancesByPolicy</c>
        /// that produced the current response.
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
