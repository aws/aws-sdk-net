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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A continuous deployment policy.
    /// </summary>
    public partial class ContinuousDeploymentPolicy
    {
        private ContinuousDeploymentPolicyConfig _continuousDeploymentPolicyConfig;
        private string _id;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property ContinuousDeploymentPolicyConfig.
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

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the continuous deployment policy.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the continuous deployment policy was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}