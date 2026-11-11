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
    /// Identifies one or more policies as a union type. Specify exactly one of <c>PolicyType</c>,
    /// <c>PolicyArn</c>, or <c>InlinePolicyIdentifier</c> to identify policies by their type,
    /// by Amazon Resource Name (ARN), or by the name of an inline policy and the entity it
    /// is attached to.
    /// </summary>
    public partial class PolicyIdentifier
    {
        /// <summary>
        /// Gets and sets the property InlinePolicyIdentifier. 
        /// <para>
        /// An inline policy identifier consisting of a policy name and the entity it is attached
        /// to. Wildcard characters (<c>*</c> and <c>?</c>) in the entity name can match multiple
        /// entities.
        /// </para>
        /// </summary>
        public InlinePolicyIdentifierType InlinePolicyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the InlinePolicyIdentifier property is set.
        /// </summary>
        internal bool IsSetInlinePolicyIdentifier() => this.InlinePolicyIdentifier != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Web Services managed policy or a customer
        /// managed policy that is attached to an IAM user, group, or role. Wildcard characters
        /// are supported in the resource name portion of the ARN to match multiple managed policies:
        /// use at most one <c>*</c> (matches any sequence of characters, including none), and
        /// any number of <c>?</c> (each matches exactly one character).
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The policy type to identify. All policies of the specified type are matched.
        /// </para>
        /// </summary>
        public PolicyIdentifierPolicyType PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;
    }
}
