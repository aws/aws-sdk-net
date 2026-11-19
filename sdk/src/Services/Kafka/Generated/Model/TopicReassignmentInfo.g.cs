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
    /// Summary information about a topic reassignment operation.
    /// </summary>
    public partial class TopicReassignmentInfo
    {
        /// <summary>
        /// Gets and sets the property CompletedTopics. 
        /// <para>
        /// Number of topics fully migrated.
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
        /// Gets and sets the property TotalTopics. 
        /// <para>
        /// Total number of topics matching the selector.
        /// </para>
        /// </summary>
        public int? TotalTopics { get; set; }

        /// <summary>
        /// Checks to see if the TotalTopics property is set.
        /// </summary>
        internal bool IsSetTotalTopics() => this.TotalTopics.HasValue;
    }
}
