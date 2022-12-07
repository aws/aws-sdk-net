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
    /// Container for the parameters to the UpdateDistributionWithStagingConfig operation.
    /// Copies the staging distribution's configuration to its corresponding primary distribution.
    /// The primary distribution retains its <code>Aliases</code> (also known as alternate
    /// domain names or CNAMEs) and <code>ContinuousDeploymentPolicyId</code> value, but otherwise
    /// its configuration is overwritten to match the staging distribution.
    /// 
    ///  
    /// <para>
    /// You can use this operation in a continuous deployment workflow after you have tested
    /// configuration changes on the staging distribution. After using a continuous deployment
    /// policy to move a portion of your domain name’s traffic to the staging distribution
    /// and verifying that it works as intended, you can use this operation to copy the staging
    /// distribution’s configuration to the primary distribution. This action will disable
    /// the continuous deployment policy and move your domain’s traffic back to the primary
    /// distribution.
    /// </para>
    /// </summary>
    public partial class UpdateDistributionWithStagingConfigRequest : AmazonCloudFrontRequest
    {
        private string _id;
        private string _ifMatch;
        private string _stagingDistributionId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the primary distribution to which you are copying a staging distribution's
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current versions (<code>ETag</code> values) of both primary and staging distributions.
        /// Provide these in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;primary ETag&gt;, &lt;staging ETag&gt;</code> 
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property StagingDistributionId. 
        /// <para>
        /// The identifier of the staging distribution whose configuration you are copying to
        /// the primary distribution.
        /// </para>
        /// </summary>
        public string StagingDistributionId
        {
            get { return this._stagingDistributionId; }
            set { this._stagingDistributionId = value; }
        }

        // Check to see if StagingDistributionId property is set
        internal bool IsSetStagingDistributionId()
        {
            return this._stagingDistributionId != null;
        }

    }
}