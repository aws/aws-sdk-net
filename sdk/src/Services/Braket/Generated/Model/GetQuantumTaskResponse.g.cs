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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// This is the response object from the GetQuantumTask operation.
    /// </summary>
    public partial class GetQuantumTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActionMetadata. 
        /// <para>
        /// Metadata about the action performed by the quantum task, including information about
        /// the type of action and program counts.
        /// </para>
        /// </summary>
        public ActionMetadata ActionMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ActionMetadata property is set.
        /// </summary>
        internal bool IsSetActionMetadata() => this.ActionMetadata != null;

        /// <summary>
        /// Gets and sets the property Associations. 
        /// <para>
        /// The list of Amazon Braket resources associated with the quantum task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Association> Associations { get; set; } = AWSConfigs.InitializeCollections ? new List<Association>() : null;

        /// <summary>
        /// Checks to see if the Associations property is set.
        /// </summary>
        internal bool IsSetAssociations() => this.Associations != null && (this.Associations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the quantum task was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device the quantum task was run on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceArn property is set.
        /// </summary>
        internal bool IsSetDeviceArn() => this.DeviceArn != null;

        /// <summary>
        /// Gets and sets the property DeviceParameters. 
        /// <para>
        /// The parameters for the device on which the quantum task ran.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeviceParameters { get; set; }

        /// <summary>
        /// Checks to see if the DeviceParameters property is set.
        /// </summary>
        internal bool IsSetDeviceParameters() => this.DeviceParameters != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The time at which the quantum task ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExperimentalCapabilities. 
        /// <para>
        /// Enabled experimental capabilities for the quantum task, if any.
        /// </para>
        /// </summary>
        public ExperimentalCapabilities ExperimentalCapabilities { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentalCapabilities property is set.
        /// </summary>
        internal bool IsSetExperimentalCapabilities() => this.ExperimentalCapabilities != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that a quantum task failed.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The ARN of the Amazon Braket job associated with the quantum task.
        /// </para>
        /// </summary>
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property NumSuccessfulShots. 
        /// <para>
        /// The number of successful shots for the quantum task. This is available after a successfully
        /// completed quantum task.
        /// </para>
        /// </summary>
        public long? NumSuccessfulShots { get; set; }

        /// <summary>
        /// Checks to see if the NumSuccessfulShots property is set.
        /// </summary>
        internal bool IsSetNumSuccessfulShots() => this.NumSuccessfulShots.HasValue;

        /// <summary>
        /// Gets and sets the property OutputS3Bucket. 
        /// <para>
        /// The S3 bucket where quantum task results are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OutputS3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Bucket property is set.
        /// </summary>
        internal bool IsSetOutputS3Bucket() => this.OutputS3Bucket != null;

        /// <summary>
        /// Gets and sets the property OutputS3Directory. 
        /// <para>
        /// The folder in the S3 bucket where quantum task results are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OutputS3Directory { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Directory property is set.
        /// </summary>
        internal bool IsSetOutputS3Directory() => this.OutputS3Directory != null;

        /// <summary>
        /// Gets and sets the property QuantumTaskArn. 
        /// <para>
        /// The ARN of the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string QuantumTaskArn { get; set; }

        /// <summary>
        /// Checks to see if the QuantumTaskArn property is set.
        /// </summary>
        internal bool IsSetQuantumTaskArn() => this.QuantumTaskArn != null;

        /// <summary>
        /// Gets and sets the property QueueInfo. 
        /// <para>
        /// Queue information for the requested quantum task. Only returned if <c>QueueInfo</c>
        /// is specified in the <c>additionalAttributeNames"</c> field in the <c>GetQuantumTask</c>
        /// API request.
        /// </para>
        /// </summary>
        public QuantumTaskQueueInfo QueueInfo { get; set; }

        /// <summary>
        /// Checks to see if the QueueInfo property is set.
        /// </summary>
        internal bool IsSetQueueInfo() => this.QueueInfo != null;

        /// <summary>
        /// Gets and sets the property Shots. 
        /// <para>
        /// The number of shots used in the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Shots { get; set; }

        /// <summary>
        /// Checks to see if the Shots property is set.
        /// </summary>
        internal bool IsSetShots() => this.Shots.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the quantum task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QuantumTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that belong to this quantum task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
