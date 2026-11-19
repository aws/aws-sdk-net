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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The cross-Region traffic cap for an endpoint. The cap limits the requests per second
    /// that the endpoint accepts from inference routers in other Amazon Web Services Regions.
    /// The cap is <c>MaxCrossRegionPercentPerEndpoint</c> percent of <c>MaxInvocationsPerSecondPerInstance</c>
    /// multiplied by the number of <c>InService</c> instances, rounded up. All production
    /// variants and inference components of the endpoint share it. Requests that you send
    /// to the endpoint directly aren't counted. A request over the cap fails with a <c>ThrottlingException</c>.
    /// </summary>
    public partial class CrossRegionTrafficConfig
    {
        /// <summary>
        /// Gets and sets the property MaxCrossRegionPercentPerEndpoint. 
        /// <para>
        /// The percentage of the endpoint's capacity that requests from inference routers in
        /// other Amazon Web Services Regions can use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public int? MaxCrossRegionPercentPerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the MaxCrossRegionPercentPerEndpoint property is set.
        /// </summary>
        internal bool IsSetMaxCrossRegionPercentPerEndpoint() => this.MaxCrossRegionPercentPerEndpoint.HasValue;

        /// <summary>
        /// Gets and sets the property MaxInvocationsPerSecondPerInstance. 
        /// <para>
        /// The number of invocations per second that you expect one <c>InService</c> instance
        /// to serve. One value applies to every production variant, whatever its instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10000)]
        public int? MaxInvocationsPerSecondPerInstance { get; set; }

        /// <summary>
        /// Checks to see if the MaxInvocationsPerSecondPerInstance property is set.
        /// </summary>
        internal bool IsSetMaxInvocationsPerSecondPerInstance() => this.MaxInvocationsPerSecondPerInstance.HasValue;
    }
}
