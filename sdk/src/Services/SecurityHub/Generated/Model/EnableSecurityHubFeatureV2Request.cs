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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the EnableSecurityHubFeatureV2 operation.
    /// Enables an opt-in feature for the calling account in the current Amazon Web Services
    /// Region. The service must be enabled before you can enable a feature. The operation
    /// is idempotent. If the feature is already enabled, no changes are made. You cannot
    /// enable a feature that is managed by an organization policy.
    /// </summary>
    public partial class EnableSecurityHubFeatureV2Request : AmazonSecurityHubRequest
    {
        private FeatureName _featureName;

        /// <summary>
        /// Gets and sets the property FeatureName. 
        /// <para>
        /// The name of the feature to enable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeatureName FeatureName
        {
            get { return this._featureName; }
            set { this._featureName = value; }
        }

        // Check to see if FeatureName property is set
        internal bool IsSetFeatureName()
        {
            return this._featureName != null;
        }

    }
}