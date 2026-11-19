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
    /// This is the response object from the DescribeTopicReassignment operation.
    /// </summary>
    public partial class DescribeTopicReassignmentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property CompletedTopics. 
        /// <para>
        /// Number of topics fully migrated to the target broker type.
        /// </para>
        /// </summary>
        public int? CompletedTopics { get; set; }

        /// <summary>
        /// Checks to see if the CompletedTopics property is set.
        /// </summary>
        internal bool IsSetCompletedTopics() => this.CompletedTopics.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the operation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Error details. Present only when status is FAILED.
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// Last time the status or progress counters were updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property MigratedPartitions. 
        /// <para>
        /// Number of partitions confirmed on the target broker type.
        /// </para>
        /// </summary>
        public int? MigratedPartitions { get; set; }

        /// <summary>
        /// Checks to see if the MigratedPartitions property is set.
        /// </summary>
        internal bool IsSetMigratedPartitions() => this.MigratedPartitions.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the reassignment operation.
        /// </para>
        /// </summary>
        public TopicReassignmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetInstanceType. 
        /// <para>
        /// The target broker instance type for this reassignment.
        /// </para>
        /// </summary>
        public string TargetInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the TargetInstanceType property is set.
        /// </summary>
        internal bool IsSetTargetInstanceType() => this.TargetInstanceType != null;

        /// <summary>
        /// Gets and sets the property TopicReassignmentOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the topic reassignment operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string TopicReassignmentOperationArn { get; set; }

        /// <summary>
        /// Checks to see if the TopicReassignmentOperationArn property is set.
        /// </summary>
        internal bool IsSetTopicReassignmentOperationArn() => this.TopicReassignmentOperationArn != null;

        /// <summary>
        /// Gets and sets the property TopicsToExclude. 
        /// <para>
        /// The original exclude patterns provided in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TopicsToExclude { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TopicsToExclude property is set.
        /// </summary>
        internal bool IsSetTopicsToExclude() => this.TopicsToExclude != null && (this.TopicsToExclude.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicsToInclude. 
        /// <para>
        /// The original include patterns provided in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TopicsToInclude { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TopicsToInclude property is set.
        /// </summary>
        internal bool IsSetTopicsToInclude() => this.TopicsToInclude != null && (this.TopicsToInclude.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalPartitions. 
        /// <para>
        /// Total number of partitions across all matched topics.
        /// </para>
        /// </summary>
        public int? TotalPartitions { get; set; }

        /// <summary>
        /// Checks to see if the TotalPartitions property is set.
        /// </summary>
        internal bool IsSetTotalPartitions() => this.TotalPartitions.HasValue;

        /// <summary>
        /// Gets and sets the property TotalTopics. 
        /// <para>
        /// Total number of topics matching the selector at resolution time.
        /// </para>
        /// </summary>
        public int? TotalTopics { get; set; }

        /// <summary>
        /// Checks to see if the TotalTopics property is set.
        /// </summary>
        internal bool IsSetTotalTopics() => this.TotalTopics.HasValue;
    }
}
