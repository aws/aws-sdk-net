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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Contains the <c>PolicyType</c>, <c>PolicyId</c>, and the <c>ObjectIdentifier</c> to
    /// which it is attached. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/key_concepts_directory.html#key_concepts_policies">Policies</a>.
    /// </summary>
    public partial class PolicyAttachment
    {
        /// <summary>
        /// Gets and sets the property ObjectIdentifier. 
        /// <para>
        /// The <c>ObjectIdentifier</c> that is associated with <c>PolicyAttachment</c>.
        /// </para>
        /// </summary>
        public string ObjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ObjectIdentifier property is set.
        /// </summary>
        internal bool IsSetObjectIdentifier() => this.ObjectIdentifier != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of <c>PolicyAttachment</c>.
        /// </para>
        /// </summary>
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy that can be associated with <c>PolicyAttachment</c>.
        /// </para>
        /// </summary>
        public string PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;
    }
}
