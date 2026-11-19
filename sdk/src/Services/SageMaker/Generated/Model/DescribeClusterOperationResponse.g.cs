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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeClusterOperation operation.
    /// </summary>
    public partial class DescribeClusterOperationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the HyperPod cluster associated with the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the operation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeepHealthCheckDetails. 
        /// <para>
        /// The deep health check details for the operation. This field is populated when the
        /// operation <c>Type</c> is <c>DeepHealthCheck</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 99)]
        public List<InstanceGroupHealthCheckConfiguration> DeepHealthCheckDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceGroupHealthCheckConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DeepHealthCheckDetails property is set.
        /// </summary>
        internal bool IsSetDeepHealthCheckDetails() => this.DeepHealthCheckDetails != null && (this.DeepHealthCheckDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique identifier (UUID) of the operation.
        /// </para>
        /// </summary>
        public string OperationId { get; set; }

        /// <summary>
        /// Checks to see if the OperationId property is set.
        /// </summary>
        internal bool IsSetOperationId() => this.OperationId != null;

        /// <summary>
        /// Gets and sets the property ScalingDetails. 
        /// <para>
        /// The per-instance-group scaling details for the operation. This field is populated
        /// when the operation <c>Type</c> is <c>Scaling</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterOperationScalingDetails> ScalingDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterOperationScalingDetails>() : null;

        /// <summary>
        /// Checks to see if the ScalingDetails property is set.
        /// </summary>
        internal bool IsSetScalingDetails() => this.ScalingDetails != null && (this.ScalingDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the operation. Valid values are <c>InProgress</c>, <c>Superseded</c>,
        /// or <c>Done</c>.
        /// </para>
        /// </summary>
        public ClusterOperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the operation. Valid values are <c>Scaling</c> or <c>DeepHealthCheck</c>.
        /// </para>
        /// </summary>
        public ClusterOperationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
