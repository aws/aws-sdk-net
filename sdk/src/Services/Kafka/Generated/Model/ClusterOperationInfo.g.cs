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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Returns information about a cluster operation.
    /// </summary>
    public partial class ClusterOperationInfo
    {
        /// <summary>
        /// Gets and sets the property ClientRequestId. 
        /// <para>
        /// The ID of the API request that triggered this operation.
        /// </para>
        /// </summary>
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestId property is set.
        /// </summary>
        internal bool IsSetClientRequestId() => this.ClientRequestId != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// ARN of the cluster.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the operation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the operation finished.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Describes the error if the operation fails.
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null;

        /// <summary>
        /// Gets and sets the property OperationArn. 
        /// <para>
        /// ARN of the cluster operation.
        /// </para>
        /// </summary>
        public string OperationArn { get; set; }

        /// <summary>
        /// Checks to see if the OperationArn property is set.
        /// </summary>
        internal bool IsSetOperationArn() => this.OperationArn != null;

        /// <summary>
        /// Gets and sets the property OperationState. 
        /// <para>
        /// State of the cluster operation.
        /// </para>
        /// </summary>
        public string OperationState { get; set; }

        /// <summary>
        /// Checks to see if the OperationState property is set.
        /// </summary>
        internal bool IsSetOperationState() => this.OperationState != null;

        /// <summary>
        /// Gets and sets the property OperationSteps. 
        /// <para>
        /// Steps completed during the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterOperationStep> OperationSteps { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterOperationStep>() : null;

        /// <summary>
        /// Checks to see if the OperationSteps property is set.
        /// </summary>
        internal bool IsSetOperationSteps() => this.OperationSteps != null && (this.OperationSteps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// Type of the cluster operation.
        /// </para>
        /// </summary>
        public string OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property SourceClusterInfo. 
        /// <para>
        /// Information about cluster attributes before a cluster is updated.
        /// </para>
        /// </summary>
        public MutableClusterInfo SourceClusterInfo { get; set; }

        /// <summary>
        /// Checks to see if the SourceClusterInfo property is set.
        /// </summary>
        internal bool IsSetSourceClusterInfo() => this.SourceClusterInfo != null;

        /// <summary>
        /// Gets and sets the property TargetClusterInfo. 
        /// <para>
        /// Information about cluster attributes after a cluster is updated.
        /// </para>
        /// </summary>
        public MutableClusterInfo TargetClusterInfo { get; set; }

        /// <summary>
        /// Checks to see if the TargetClusterInfo property is set.
        /// </summary>
        internal bool IsSetTargetClusterInfo() => this.TargetClusterInfo != null;

        /// <summary>
        /// Gets and sets the property VpcConnectionInfo. 
        /// <para>
        /// Description of the VPC connection for CreateVpcConnection and DeleteVpcConnection
        /// operations.
        /// </para>
        /// </summary>
        public VpcConnectionInfo VpcConnectionInfo { get; set; }

        /// <summary>
        /// Checks to see if the VpcConnectionInfo property is set.
        /// </summary>
        internal bool IsSetVpcConnectionInfo() => this.VpcConnectionInfo != null;
    }
}
