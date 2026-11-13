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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an association between a flex cost allocation policy and a network resource.
    /// </summary>
    public partial class FlexCostAllocationPolicyAssociationDescription
    {
        /// <summary>
        /// Gets and sets the property AssociatedAt. 
        /// <para>
        /// The date and time when the association was created.
        /// </para>
        /// </summary>
        public DateTime? AssociatedAt { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedAt property is set.
        /// </summary>
        internal bool IsSetAssociatedAt() => this.AssociatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property AssociationMode. 
        /// <para>
        /// The mode of the association. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>direct</c> - The policy is associated with specific resources by resource ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>scope</c> - The policy is associated with a scope of resources in an account,
        /// Amazon VPC, or subnet.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FlexCostAllocationAssociationMode AssociationMode { get; set; }

        /// <summary>
        /// Checks to see if the AssociationMode property is set.
        /// </summary>
        internal bool IsSetAssociationMode() => this.AssociationMode != null;

        /// <summary>
        /// Gets and sets the property ExpectedEffectiveAt. 
        /// <para>
        /// The date and time when the association is expected to apply to network traffic.
        /// </para>
        /// </summary>
        public DateTime? ExpectedEffectiveAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedEffectiveAt property is set.
        /// </summary>
        internal bool IsSetExpectedEffectiveAt() => this.ExpectedEffectiveAt.HasValue;

        /// <summary>
        /// Gets and sets the property FcaPolicyAssociationId. 
        /// <para>
        /// The ID of the policy association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 27, Max = 27)]
        public string FcaPolicyAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the FcaPolicyAssociationId property is set.
        /// </summary>
        internal bool IsSetFcaPolicyAssociationId() => this.FcaPolicyAssociationId != null;

        /// <summary>
        /// Gets and sets the property FcaPolicyId. 
        /// <para>
        /// The ID of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string FcaPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the FcaPolicyId property is set.
        /// </summary>
        internal bool IsSetFcaPolicyId() => this.FcaPolicyId != null;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages the association. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account</c> - The account that owns the association created it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>declarative-policy</c> - An Amazon Web Services Organizations declarative policy
        /// created the association. You can't remove the association.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property NetworkResourceId. 
        /// <para>
        /// The ID of the associated network resource.
        /// </para>
        /// </summary>
        public string NetworkResourceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkResourceId property is set.
        /// </summary>
        internal bool IsSetNetworkResourceId() => this.NetworkResourceId != null;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the account that owns the association.
        /// </para>
        /// </summary>
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;
    }
}
