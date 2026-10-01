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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Attributes that define a secret resource, which references a secret from AWS Secrets
    /// Manager. AWS IoT Greengrass stores a local, encrypted copy of the secret on the Greengrass
    /// core, where it can be securely accessed by connectors and Lambda functions.
    /// </summary>
    public partial class SecretsManagerSecretResourceData
    {
        /// <summary>
        /// Gets and sets the property ARN. The ARN of the Secrets Manager secret to make available
        /// on the core. The value of the secret's latest version (represented by the ''AWSCURRENT''
        /// staging label) is included by default.
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property AdditionalStagingLabelsToDownload. Optional. The staging
        /// labels whose values you want to make available on the core, in addition to ''AWSCURRENT''.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalStagingLabelsToDownload { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalStagingLabelsToDownload property is set.
        /// </summary>
        internal bool IsSetAdditionalStagingLabelsToDownload() => this.AdditionalStagingLabelsToDownload != null && (this.AdditionalStagingLabelsToDownload.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
