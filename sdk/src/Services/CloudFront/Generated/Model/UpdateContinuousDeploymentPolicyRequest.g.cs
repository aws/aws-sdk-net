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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateContinuousDeploymentPolicy operation. Updates
    /// a continuous deployment policy. You can update a continuous deployment policy to enable
    /// or disable it, to change the percentage of traffic that it sends to the staging distribution,
    /// or to change the staging distribution that it sends traffic to. <para> When you update
    /// a continuous deployment policy configuration, all the fields are updated with the
    /// values that are provided in the request. You cannot update some fields independent
    /// of others. To update a continuous deployment policy configuration: </para> <ol> <li>
    /// <para> Use <c>GetContinuousDeploymentPolicyConfig</c> to get the current configuration.
    /// </para> </li> <li> <para> Locally modify the fields in the continuous deployment policy
    /// configuration that you want to update. </para> </li> <li> <para> Use <c>UpdateContinuousDeploymentPolicy</c>,
    /// providing the entire continuous deployment policy configuration, including the fields
    /// that you modified and those that you didn't. </para> </li> </ol>
    /// </summary>
    public partial class UpdateContinuousDeploymentPolicyRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property ContinuousDeploymentPolicyConfig. 
        /// <para>
        /// The continuous deployment policy configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContinuousDeploymentPolicyConfig ContinuousDeploymentPolicyConfig { get; set; }

        /// <summary>
        /// Checks to see if the ContinuousDeploymentPolicyConfig property is set.
        /// </summary>
        internal bool IsSetContinuousDeploymentPolicyConfig() => this.ContinuousDeploymentPolicyConfig != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the continuous deployment policy that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (<c>ETag</c> value) of the continuous deployment policy that you
        /// are updating.
        /// </para>
        /// </summary>
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;
    }
}
