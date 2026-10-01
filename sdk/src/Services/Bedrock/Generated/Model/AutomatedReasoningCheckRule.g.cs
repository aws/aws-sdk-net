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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// References a specific automated reasoning policy rule that was applied during evaluation.
    /// </summary>
    public partial class AutomatedReasoningCheckRule
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the automated reasoning rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PolicyVersionArn. 
        /// <para>
        /// The ARN of the automated reasoning policy version that contains this rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PolicyVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyVersionArn property is set.
        /// </summary>
        internal bool IsSetPolicyVersionArn() => this.PolicyVersionArn != null;
    }
}
