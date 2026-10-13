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
    /// This is the response object from the DescribeClusterSchedulerConfig operation.
    /// </summary>
    public partial class DescribeClusterSchedulerConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// ARN of the cluster where the cluster policy is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ClusterSchedulerConfigArn. 
        /// <para>
        /// ARN of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterSchedulerConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterSchedulerConfigArn property is set.
        /// </summary>
        internal bool IsSetClusterSchedulerConfigArn() => this.ClusterSchedulerConfigArn != null;

        /// <summary>
        /// Gets and sets the property ClusterSchedulerConfigId. 
        /// <para>
        /// ID of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 12)]
        public string ClusterSchedulerConfigId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterSchedulerConfigId property is set.
        /// </summary>
        internal bool IsSetClusterSchedulerConfigId() => this.ClusterSchedulerConfigId != null;

        /// <summary>
        /// Gets and sets the property ClusterSchedulerConfigVersion. 
        /// <para>
        /// Version of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ClusterSchedulerConfigVersion { get; set; }

        /// <summary>
        /// Checks to see if the ClusterSchedulerConfigVersion property is set.
        /// </summary>
        internal bool IsSetClusterSchedulerConfigVersion() => this.ClusterSchedulerConfigVersion.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Failure reason of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Last modified time of the cluster policy.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SchedulerConfig. 
        /// <para>
        /// Cluster policy configuration. This policy is used for task prioritization and fair-share
        /// allocation. This helps prioritize critical workloads and distributes idle compute
        /// across entities.
        /// </para>
        /// </summary>
        public SchedulerConfig SchedulerConfig { get; set; }

        /// <summary>
        /// Checks to see if the SchedulerConfig property is set.
        /// </summary>
        internal bool IsSetSchedulerConfig() => this.SchedulerConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the cluster policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchedulerResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Additional details about the status of the cluster policy. This field provides context
        /// when the policy is in a non-active state, such as during creation, updates, or if
        /// failures occur.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> StatusDetails { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null && (this.StatusDetails.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
