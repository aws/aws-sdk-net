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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A WAF feature that is not supported by the CloudFront pricing plan associated with
    /// the web ACL.
    /// </summary>
    public partial class DisallowedFeature
    {
        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// The name of the disallowed WAF feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Feature { get; set; }

        /// <summary>
        /// Checks to see if the Feature property is set.
        /// </summary>
        internal bool IsSetFeature() => this.Feature != null;

        /// <summary>
        /// Gets and sets the property RequiredPricingPlan. 
        /// <para>
        /// The name of the CloudFront pricing plan required to use the WAF feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RequiredPricingPlan { get; set; }

        /// <summary>
        /// Checks to see if the RequiredPricingPlan property is set.
        /// </summary>
        internal bool IsSetRequiredPricingPlan() => this.RequiredPricingPlan != null;
    }
}
