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
    /// This is the response object from the DescribeAIBenchmarkJob operation.
    /// </summary>
    public partial class DescribeAIBenchmarkJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AIBenchmarkJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AI benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string AIBenchmarkJobArn { get; set; }

        /// <summary>
        /// Checks to see if the AIBenchmarkJobArn property is set.
        /// </summary>
        internal bool IsSetAIBenchmarkJobArn() => this.AIBenchmarkJobArn != null;

        /// <summary>
        /// Gets and sets the property AIBenchmarkJobName. 
        /// <para>
        /// The name of the AI benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string AIBenchmarkJobName { get; set; }

        /// <summary>
        /// Checks to see if the AIBenchmarkJobName property is set.
        /// </summary>
        internal bool IsSetAIBenchmarkJobName() => this.AIBenchmarkJobName != null;

        /// <summary>
        /// Gets and sets the property AIBenchmarkJobStatus. 
        /// <para>
        /// The status of the AI benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIBenchmarkJobStatus AIBenchmarkJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the AIBenchmarkJobStatus property is set.
        /// </summary>
        internal bool IsSetAIBenchmarkJobStatus() => this.AIBenchmarkJobStatus != null;

        /// <summary>
        /// Gets and sets the property AIWorkloadConfigIdentifier. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the AI workload configuration used for this
        /// benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AIWorkloadConfigIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AIWorkloadConfigIdentifier property is set.
        /// </summary>
        internal bool IsSetAIWorkloadConfigIdentifier() => this.AIWorkloadConfigIdentifier != null;

        /// <summary>
        /// Gets and sets the property BenchmarkTarget. 
        /// <para>
        /// The target endpoint that was benchmarked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIBenchmarkTarget BenchmarkTarget { get; set; }

        /// <summary>
        /// Checks to see if the BenchmarkTarget property is set.
        /// </summary>
        internal bool IsSetBenchmarkTarget() => this.BenchmarkTarget != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the benchmark job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A timestamp that indicates when the benchmark job completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the benchmark job failed, the reason it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// The network configuration for the benchmark job.
        /// </para>
        /// </summary>
        public AIBenchmarkNetworkConfig NetworkConfig { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfig property is set.
        /// </summary>
        internal bool IsSetNetworkConfig() => this.NetworkConfig != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for the benchmark job, including the Amazon S3 output location
        /// and CloudWatch log information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AIBenchmarkOutputResult OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used by the benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A timestamp that indicates when the benchmark job started running.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the benchmark job.
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
