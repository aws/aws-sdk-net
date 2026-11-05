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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Metadata for a service policy disassociated event.
    /// </summary>
    public partial class ServicePolicyDisassociatedMetadata
    {
        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Min = 31)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the disassociated policy.
        /// </para>
        /// </summary>
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property PolicyOwnerAccountId. 
        /// <para>
        /// The account that owns the policy.
        /// </para>
        /// </summary>
        public string PolicyOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetPolicyOwnerAccountId() => this.PolicyOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property PolicySource. 
        /// <para>
        /// The source of the policy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SELF — the policy belongs to the account that owns the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CROSS_ACCOUNT — the policy belongs to another account and was shared with the organization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PolicyValueSource PolicySource { get; set; }

        /// <summary>
        /// Checks to see if the PolicySource property is set.
        /// </summary>
        internal bool IsSetPolicySource() => this.PolicySource != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason the policy was disassociated from the service.
        /// </para>
        /// </summary>
        public PolicyDisassociationReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
