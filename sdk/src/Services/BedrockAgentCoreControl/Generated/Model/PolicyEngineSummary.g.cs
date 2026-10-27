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
    /// Represents a metadata-only summary of a policy engine resource. This structure contains
    /// resource identifiers, status, and timestamps without customer-encrypted fields such
    /// as description or status reasons. Policy engine summaries are returned by operations
    /// that do not require access to the customer's KMS key.
    /// </summary>
    public partial class PolicyEngineSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the policy engine was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the policy engine data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-assigned name of the policy engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyEngineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 76, Max = 136)]
        public string PolicyEngineArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyEngineArn property is set.
        /// </summary>
        internal bool IsSetPolicyEngineArn() => this.PolicyEngineArn != null;

        /// <summary>
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The unique identifier for the policy engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyEngineId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyEngineId property is set.
        /// </summary>
        internal bool IsSetPolicyEngineId() => this.PolicyEngineId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the policy engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyEngineStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the policy engine was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
