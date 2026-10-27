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
    /// The details of a gateway, including its configuration, status, and the infrastructure
    /// settings for its type.
    /// </summary>
    public partial class Gateway
    {
        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// Specifies whether the gateway is publicly accessible (<c>PUBLIC</c>) or private (<c>PRIVATE</c>).
        /// The gateway derives this value from its scheme when you create the gateway, and the
        /// value is immutable.
        /// </para>
        /// </summary>
        public AccessType AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The type-specific configuration for the gateway.
        /// </para>
        /// </summary>
        public DescribeGatewayConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the gateway was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether deletion protection is enabled for the gateway.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// The per-resource failure details for asynchronous gateway processes, such as an <c>UpdateGateway</c>
        /// operation that couldn't update every load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<GatewayResourceFailure> Failures { get; set; } = AWSConfigs.InitializeCollections ? new List<GatewayResourceFailure>() : null;

        /// <summary>
        /// Checks to see if the Failures property is set.
        /// </summary>
        internal bool IsSetFailures() => this.Failures != null && (this.Failures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway.
        /// </para>
        /// </summary>
        public string GatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the GatewayArn property is set.
        /// </summary>
        internal bool IsSetGatewayArn() => this.GatewayArn != null;

        /// <summary>
        /// Gets and sets the property InfrastructureRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the gateway uses to manage infrastructure
        /// on your behalf.
        /// </para>
        /// </summary>
        public string InfrastructureRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureRoleArn property is set.
        /// </summary>
        internal bool IsSetInfrastructureRoleArn() => this.InfrastructureRoleArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the gateway.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether the gateway propagates its tags to the infrastructure it manages.
        /// </para>
        /// </summary>
        public PropagateGatewayTags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the gateway.
        /// </para>
        /// </summary>
        public GatewayStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable explanation of the current status. This value is populated when the
        /// gateway is in a failure state, such as <c>UPDATE_FAILED</c>.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata applied to the gateway. Each tag consists of a key and an optional value.
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the gateway was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
