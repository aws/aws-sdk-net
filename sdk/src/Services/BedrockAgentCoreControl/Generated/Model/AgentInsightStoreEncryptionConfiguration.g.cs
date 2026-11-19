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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Contains the encryption mode and key configuration used to encrypt new Agent Insights
    /// in an Agent Insight Store.
    /// </summary>
    public partial class AgentInsightStoreEncryptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the customer managed AWS KMS key that
        /// you use to encrypt new Agent Insights. This field is required when <c>mode</c> is
        /// <c>CUSTOMER_MANAGED_KMS</c> and cannot be specified when <c>mode</c> is <c>AWS_OWNED_KMS_KEY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Specifies the encryption mode used to protect new Agent Insights.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentInsightStoreEncryptionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;
    }
}
