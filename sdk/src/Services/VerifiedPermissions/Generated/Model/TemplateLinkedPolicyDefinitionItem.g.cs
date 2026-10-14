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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains information about a policy created by instantiating a policy template.
    /// </summary>
    public partial class TemplateLinkedPolicyDefinitionItem
    {
        /// <summary>
        /// Gets and sets the property PolicyTemplateId. 
        /// <para>
        /// The unique identifier of the policy template used to create this policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyTemplateId property is set.
        /// </summary>
        internal bool IsSetPolicyTemplateId() => this.PolicyTemplateId != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal associated with this template-linked policy. Verified Permissions substitutes
        /// this principal for the <c>?principal</c> placeholder in the policy template when it
        /// evaluates an authorization request.
        /// </para>
        /// </summary>
        public EntityIdentifier Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource associated with this template-linked policy. Verified Permissions substitutes
        /// this resource for the <c>?resource</c> placeholder in the policy template when it
        /// evaluates an authorization request.
        /// </para>
        /// </summary>
        public EntityIdentifier Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
