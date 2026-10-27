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
    /// Container for the parameters to the UpdateGateway operation. Modifies the configuration
    /// of a gateway. You can change only the properties that can be applied without interrupting
    /// traffic, and the configuration variant that you provide must match the gateway's type.
    /// <c>UpdateGateway</c> is an asynchronous operation: the changes are applied to each
    /// load balancer the gateway manages, and the gateway reports a status of <c>UPDATE_IN_PROGRESS</c>
    /// until the update completes. If Amazon ECS can't update one or more resources, it makes
    /// a best effort to update the rest and the gateway status changes to <c>UPDATE_FAILED</c>.
    /// Use <c>DescribeGateway</c> to inspect the gateway's <c>statusReason</c> and failures
    /// list, which gives the ARN of each load balancer that was not updated and the operation,
    /// error code, and message for each failure. <para> If you specify <c>infrastructureRoleArn</c>,
    /// you must have the <c>iam:PassRole</c> permission for that role. </para>
    /// </summary>
    public partial class UpdateGatewayRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The updated type-specific configuration for the gateway. The configuration variant
        /// must match the gateway's existing type, and only mutable fields can be changed.
        /// </para>
        /// </summary>
        public UpdateGatewayConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether to enable deletion protection for the gateway. When enabled, the
        /// gateway can't be deleted.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property Gateway. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the gateway to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Gateway { get; set; }

        /// <summary>
        /// Checks to see if the Gateway property is set.
        /// </summary>
        internal bool IsSetGateway() => this.Gateway != null;

        /// <summary>
        /// Gets and sets the property InfrastructureRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the gateway assumes to manage
        /// infrastructure on your behalf.
        /// </para>
        /// </summary>
        public string InfrastructureRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureRoleArn property is set.
        /// </summary>
        internal bool IsSetInfrastructureRoleArn() => this.InfrastructureRoleArn != null;

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the gateway to the infrastructure that
        /// the gateway manages. If you don't specify a value, the gateway's existing setting
        /// is unchanged.
        /// </para>
        /// </summary>
        public PropagateGatewayTags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;
    }
}
