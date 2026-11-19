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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the PutAgentProfilePolicy operation. Attaches or replaces
    /// a resource-based policy on an Agent Profile. The policy controls cross-account access
    /// to the profile and its child resources such as recommendations, goals, and contexts.
    /// Only the profile owner can call this operation. The policy must be valid IAM JSON
    /// with Allow-only statements and no negation condition operators.
    /// </summary>
    public partial class PutAgentProfilePolicyRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The IAM resource-based policy document in JSON format. Maximum size 50KB.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 51200)]
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The ARN of the Agent Profile to attach the policy to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileArn property is set.
        /// </summary>
        internal bool IsSetProfileArn() => this.ProfileArn != null;
    }
}
