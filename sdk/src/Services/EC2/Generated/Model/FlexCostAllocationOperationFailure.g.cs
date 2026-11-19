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
    /// Describes a policy, association, or network resource that a Networking Flexible Cost
    /// Allocation operation failed to process.
    /// </summary>
    public partial class FlexCostAllocationOperationFailure
    {
        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The code that identifies the type of failure. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ResourceNotFound</c> - (<c>DeleteNetworkingFlexCostAllocationPolicies</c>) The
        /// policy doesn't exist or isn't owned by your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidResourceState</c> - (<c>DeleteNetworkingFlexCostAllocationPolicies</c>)
        /// The policy has active associations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidResource</c> - (<c>AssociateNetworkingFlexCostAllocationPolicy</c>) The
        /// resource ID is malformed, the resource type doesn't match the policy, or the scope
        /// is an account other than yours. (<c>DisassociateNetworkingFlexCostAllocationPolicy</c>)
        /// The association doesn't exist or was already removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceAlreadyAssociated</c> - (<c>AssociateNetworkingFlexCostAllocationPolicy</c>)
        /// The resource already has an active association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InternalError</c> - An internal error occurred. Retry the request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for the failure.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource that could not be processed.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;
    }
}
