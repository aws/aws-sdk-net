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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the PutIntelligenceConfiguration operation. Creates
    /// or updates the intelligence configuration for the calling account. Account is identified
    /// via FAS (caller identity).
    /// </summary>
    public partial class PutIntelligenceConfigurationRequest : AmazonCloudWatchOmniRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. Idempotency token for safe retries. Repeating
        /// a request with the same token applies the update at most once instead of reprocessing
        /// it.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. Optional KMS key ARN to configure customer-managed
        /// encryption for anomaly data.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property RemoveKmsKey. Set to true to disassociate the configured
        /// KMS key. Mutually exclusive with kmsKeyArn; the service returns ValidationException
        /// if both are provided.
        /// </summary>
        public bool? RemoveKmsKey { get; set; }

        /// <summary>
        /// Checks to see if the RemoveKmsKey property is set.
        /// </summary>
        internal bool IsSetRemoveKmsKey() => this.RemoveKmsKey.HasValue;
    }
}
