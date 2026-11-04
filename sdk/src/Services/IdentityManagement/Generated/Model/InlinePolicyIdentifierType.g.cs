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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Identifies one or more inline policies that are embedded in IAM users, groups, or
    /// roles, by the name of the policy together with the type and name of the entity that
    /// it is attached to. Wildcard characters in the entity name can match multiple entities,
    /// so a single identifier can select more than one attached inline policy.
    /// </summary>
    public partial class InlinePolicyIdentifierType
    {
        /// <summary>
        /// Gets and sets the property AttachmentName. 
        /// <para>
        /// The name of the IAM user, group, or role that the inline policy is attached to. Wildcard
        /// characters are supported to match multiple entities: use at most one <c>*</c> (matches
        /// any sequence of characters, including none), and any number of <c>?</c> (each matches
        /// exactly one character).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string AttachmentName { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentName property is set.
        /// </summary>
        internal bool IsSetAttachmentName() => this.AttachmentName != null;

        /// <summary>
        /// Gets and sets the property AttachmentType. 
        /// <para>
        /// The type of IAM entity that the inline policy is attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AttachmentType AttachmentType { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentType property is set.
        /// </summary>
        internal bool IsSetAttachmentType() => this.AttachmentType != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the inline policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;
    }
}
