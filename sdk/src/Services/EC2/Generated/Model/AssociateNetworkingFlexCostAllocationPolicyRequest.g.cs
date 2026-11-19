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
    /// Container for the parameters to the AssociateNetworkingFlexCostAllocationPolicy operation.
    /// Associates a flex cost allocation policy with one or more network resources. You can
    /// associate the policy directly with specific resources by resource ID, or you can associate
    /// it with a scope of resources in an account, Amazon VPC, or subnet. <para> The following
    /// limits apply: </para> <ul> <li> <para> A request can associate up to 20 resources.
    /// </para> </li> <li> <para> A policy can have up to 100 active associations. </para>
    /// </li> <li> <para> A network resource can have only one active association, across
    /// all policies. If a resource is already associated, the response includes it in the
    /// failures with the code <c>ResourceAlreadyAssociated</c>. </para> </li> </ul>
    /// </summary>
    public partial class AssociateNetworkingFlexCostAllocationPolicyRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property FcaPolicyId. 
        /// <para>
        /// The ID of the flex cost allocation policy to associate. This parameter is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 22, Max = 22)]
        public string FcaPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the FcaPolicyId property is set.
        /// </summary>
        internal bool IsSetFcaPolicyId() => this.FcaPolicyId != null;

        /// <summary>
        /// Gets and sets the property NetworkResourceIds. 
        /// <para>
        /// The IDs of the network resources to associate with the policy. You can specify from
        /// 1 to 20 resource IDs.
        /// </para>
        ///  
        /// <para>
        /// You must specify <c>NetworkResourceIds</c>, <c>NetworkResourceScope</c>, or both.
        /// A request can include at most 20 distinct resources in total.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> NetworkResourceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NetworkResourceIds property is set.
        /// </summary>
        internal bool IsSetNetworkResourceIds() => this.NetworkResourceIds != null && (this.NetworkResourceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkResourceScope. 
        /// <para>
        /// The scope of network resources to associate with the policy. Use a scope to associate
        /// the policy with the resources in an account, Amazon VPC, or subnet.
        /// </para>
        ///  
        /// <para>
        /// You must specify <c>NetworkResourceScope</c>, <c>NetworkResourceIds</c>, or both.
        /// </para>
        /// </summary>
        public FlexCostAllocationNetworkResourceScope NetworkResourceScope { get; set; }

        /// <summary>
        /// Checks to see if the NetworkResourceScope property is set.
        /// </summary>
        internal bool IsSetNetworkResourceScope() => this.NetworkResourceScope != null;
    }
}
