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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Per-policy guardrail assessment result. Captures which policy triggered, its outcome,
    /// and a policy-specific detail string.
    /// </summary>
    public partial class GuardrailPolicyResult
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Outcome of this specific policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Policy-specific detail.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Details { get; set; }

        /// <summary>
        /// Checks to see if the Details property is set.
        /// </summary>
        internal bool IsSetDetails() => this.Details != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of guardrail policy that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailPolicyType PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;
    }
}
