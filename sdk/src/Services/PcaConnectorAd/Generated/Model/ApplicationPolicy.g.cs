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

namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Application policies describe what the certificate can be used for.
    /// </summary>
    public partial class ApplicationPolicy
    {
        /// <summary>
        /// Gets and sets the property PolicyObjectIdentifier. 
        /// <para>
        /// The object identifier (OID) of an application policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string PolicyObjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PolicyObjectIdentifier property is set.
        /// </summary>
        internal bool IsSetPolicyObjectIdentifier() => this.PolicyObjectIdentifier != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of application policy
        /// </para>
        /// </summary>
        public ApplicationPolicyType PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;
    }
}
