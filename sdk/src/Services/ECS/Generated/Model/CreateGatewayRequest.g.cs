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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGateway operation. Creates a gateway. A
    /// gateway defines and dynamically manages ingress paths for your Amazon ECS services,
    /// handling traffic routing and infrastructure across multiple services while optimizing
    /// infrastructure usage. <c>CreateGateway</c> is a synchronous operation and the gateway
    /// is returned with a status of <c>ACTIVE</c>. The load balancers and other infrastructure
    /// that a gateway manages aren't created until a service in an associated cluster begins
    /// using the gateway. <para> To use this operation, you must have the <c>iam:PassRole</c>
    /// permission for the infrastructure role that you specify in <c>infrastructureRoleArn</c>.
    /// </para>
    /// </summary>
    public partial class CreateGatewayRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If this token matches a previous request, the service
        /// ignores the request, but does not return an error.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The type-specific configuration for the gateway. Exactly one configuration variant
        /// must be set, and it determines the gateway type. For example, <c>hostSharedAlb</c>
        /// configures a gateway that uses Application Load Balancers with host-based routing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GatewayConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether to enable deletion protection for the gateway. When enabled, the
        /// gateway can't be deleted, and the gateway propagates this setting to the load balancers
        /// it manages. The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property InfrastructureRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the gateway assumes to create
        /// and manage infrastructure on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InfrastructureRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureRoleArn property is set.
        /// </summary>
        internal bool IsSetInfrastructureRoleArn() => this.InfrastructureRoleArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the gateway. The name must be unique within your account and can be up
        /// to 255 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the gateway to the infrastructure that
        /// the gateway manages. The default is <c>GATEWAY</c>.
        /// </para>
        /// </summary>
        public PropagateGatewayTags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the gateway to help you categorize and organize it.
        /// Each tag consists of a key and an optional value. Depending on <c>propagateTags</c>,
        /// these tags can be applied to the infrastructure the gateway manages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
