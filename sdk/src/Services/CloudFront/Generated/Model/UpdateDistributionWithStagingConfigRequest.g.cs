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
    /// Container for the parameters to the UpdateDistributionWithStagingConfig operation.
    /// Copies the staging distribution's configuration to its corresponding primary distribution.
    /// The primary distribution retains its <c>Aliases</c> (also known as alternate domain
    /// names or CNAMEs) and <c>ContinuousDeploymentPolicyId</c> value, but otherwise its
    /// configuration is overwritten to match the staging distribution. <para> You can use
    /// this operation in a continuous deployment workflow after you have tested configuration
    /// changes on the staging distribution. After using a continuous deployment policy to
    /// move a portion of your domain name's traffic to the staging distribution and verifying
    /// that it works as intended, you can use this operation to copy the staging distribution's
    /// configuration to the primary distribution. This action will disable the continuous
    /// deployment policy and move your domain's traffic back to the primary distribution.
    /// </para> <para> This API operation requires the following IAM permissions: </para>
    /// <ul> <li> <para> <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_GetDistribution.html">GetDistribution</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
    /// </para> </li> </ul>
    /// </summary>
    public partial class UpdateDistributionWithStagingConfigRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the primary distribution to which you are copying a staging distribution's
        /// configuration.
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
        /// The current versions (<c>ETag</c> values) of both primary and staging distributions.
        /// Provide these in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>&lt;primary ETag&gt;, &lt;staging ETag&gt;</c> 
        /// </para>
        /// </summary>
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;

        /// <summary>
        /// Gets and sets the property StagingDistributionId. 
        /// <para>
        /// The identifier of the staging distribution whose configuration you are copying to
        /// the primary distribution.
        /// </para>
        /// </summary>
        public string StagingDistributionId { get; set; }

        /// <summary>
        /// Checks to see if the StagingDistributionId property is set.
        /// </summary>
        internal bool IsSetStagingDistributionId() => this.StagingDistributionId != null;
    }
}
