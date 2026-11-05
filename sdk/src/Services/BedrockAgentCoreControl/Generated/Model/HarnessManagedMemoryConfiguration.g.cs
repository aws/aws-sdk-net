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
    /// Configuration for managed memory creation.
    /// </summary>
    public partial class HarnessManagedMemoryConfiguration
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the managed AgentCore Memory resource. Read-only on Get, ignored on Create/Update
        /// input.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// Customer-managed KMS key. Defaults to Amazon Web Services-owned key. Not updatable
        /// after creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property EventExpiryDuration. 
        /// <para>
        /// Event retention in days. Defaults to 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 365)]
        public int? EventExpiryDuration { get; set; }

        /// <summary>
        /// Checks to see if the EventExpiryDuration property is set.
        /// </summary>
        internal bool IsSetEventExpiryDuration() => this.EventExpiryDuration.HasValue;

        /// <summary>
        /// Gets and sets the property Strategies. 
        /// <para>
        /// Strategy types to enable. Defaults to [SEMANTIC, SUMMARIZATION].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<string> Strategies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Strategies property is set.
        /// </summary>
        internal bool IsSetStrategies() => this.Strategies != null && (this.Strategies.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
