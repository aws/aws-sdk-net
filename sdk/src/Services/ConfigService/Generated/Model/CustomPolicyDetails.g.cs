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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides the runtime system, policy definition, and whether debug logging enabled.
    /// You can specify the following CustomPolicyDetails parameter values only for Config
    /// Custom Policy rules.
    /// </summary>
    public partial class CustomPolicyDetails
    {
        /// <summary>
        /// Gets and sets the property EnableDebugLogDelivery. 
        /// <para>
        /// The boolean expression for enabling debug logging for your Config Custom Policy rule.
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnableDebugLogDelivery { get; set; }

        /// <summary>
        /// Checks to see if the EnableDebugLogDelivery property is set.
        /// </summary>
        internal bool IsSetEnableDebugLogDelivery() => this.EnableDebugLogDelivery.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyRuntime. 
        /// <para>
        /// The runtime system for your Config Custom Policy rule. Guard is a policy-as-code language
        /// that allows you to write policies that are enforced by Config Custom Policy rules.
        /// For more information about Guard, see the <a href="https://github.com/aws-cloudformation/cloudformation-guard">Guard
        /// GitHub Repository</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PolicyRuntime { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRuntime property is set.
        /// </summary>
        internal bool IsSetPolicyRuntime() => this.PolicyRuntime != null;

        /// <summary>
        /// Gets and sets the property PolicyText. 
        /// <para>
        /// The policy definition containing the logic for your Config Custom Policy rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public string PolicyText { get; set; }

        /// <summary>
        /// Checks to see if the PolicyText property is set.
        /// </summary>
        internal bool IsSetPolicyText() => this.PolicyText != null;
    }
}
