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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContinuousDeploymentPolicy operation.
    /// Creates a continuous deployment policy that distributes traffic for a custom domain
    /// name to two different CloudFront distributions.
    /// 
    ///  
    /// <para>
    /// To use a continuous deployment policy, first use <code>CopyDistribution</code> to
    /// create a staging distribution, then use <code>UpdateDistribution</code> to modify
    /// the staging distribution's configuration.
    /// </para>
    ///  
    /// <para>
    /// After you create and update a staging distribution, you can use a continuous deployment
    /// policy to incrementally move traffic to the staging distribution. This workflow enables
    /// you to test changes to a distribution's configuration before moving all of your domain's
    /// production traffic to the new configuration.
    /// </para>
    /// </summary>
    public partial class CreateContinuousDeploymentPolicyRequest : AmazonCloudFrontRequest
    {
        private ContinuousDeploymentPolicyConfig _continuousDeploymentPolicyConfig;

        /// <summary>
        /// Gets and sets the property ContinuousDeploymentPolicyConfig. 
        /// <para>
        /// Contains the configuration for a continuous deployment policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContinuousDeploymentPolicyConfig ContinuousDeploymentPolicyConfig
        {
            get { return this._continuousDeploymentPolicyConfig; }
            set { this._continuousDeploymentPolicyConfig = value; }
        }

        // Check to see if ContinuousDeploymentPolicyConfig property is set
        internal bool IsSetContinuousDeploymentPolicyConfig()
        {
            return this._continuousDeploymentPolicyConfig != null;
        }

    }
}