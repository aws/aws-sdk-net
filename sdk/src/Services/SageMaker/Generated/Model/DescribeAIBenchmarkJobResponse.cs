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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private string _aiBenchmarkJobArn;
        private string _aiBenchmarkJobName;
        private AIBenchmarkJobStatus _aiBenchmarkJobStatus;
        private string _aiWorkloadConfigIdentifier;
        private AIBenchmarkTarget _benchmarkTarget;
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private string _failureReason;
        private AIBenchmarkNetworkConfig _networkConfig;
        private AIBenchmarkOutputResult _outputConfig;
        private string _roleArn;
        private DateTime? _startTime;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AIBenchmarkJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AI benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string AIBenchmarkJobArn
        {
            get { return this._aiBenchmarkJobArn; }
            set { this._aiBenchmarkJobArn = value; }
        }

        // Check to see if AIBenchmarkJobArn property is set
        internal bool IsSetAIBenchmarkJobArn()
        {
            return this._aiBenchmarkJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property AIBenchmarkJobName. 
        /// <para>
        /// The name of the AI benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string AIBenchmarkJobName
        {
            get { return this._aiBenchmarkJobName; }
            set { this._aiBenchmarkJobName = value; }
        }

        // Check to see if AIBenchmarkJobName property is set
        internal bool IsSetAIBenchmarkJobName()
        {
            return this._aiBenchmarkJobName != null;
        }

        /// <summary>
        /// Gets and sets the property AIBenchmarkJobStatus. 
        /// <para>
        /// The status of the AI benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIBenchmarkJobStatus AIBenchmarkJobStatus
        {
            get { return this._aiBenchmarkJobStatus; }
            set { this._aiBenchmarkJobStatus = value; }
        }

        // Check to see if AIBenchmarkJobStatus property is set
        internal bool IsSetAIBenchmarkJobStatus()
        {
            return this._aiBenchmarkJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AIWorkloadConfigIdentifier. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the AI workload configuration used for this
        /// benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AIWorkloadConfigIdentifier
        {
            get { return this._aiWorkloadConfigIdentifier; }
            set { this._aiWorkloadConfigIdentifier = value; }
        }

        // Check to see if AIWorkloadConfigIdentifier property is set
        internal bool IsSetAIWorkloadConfigIdentifier()
        {
            return this._aiWorkloadConfigIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property BenchmarkTarget. 
        /// <para>
        /// The target endpoint that was benchmarked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIBenchmarkTarget BenchmarkTarget
        {
            get { return this._benchmarkTarget; }
            set { this._benchmarkTarget = value; }
        }

        // Check to see if BenchmarkTarget property is set
        internal bool IsSetBenchmarkTarget()
        {
            return this._benchmarkTarget != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the benchmark job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A timestamp that indicates when the benchmark job completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the benchmark job failed, the reason it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// The network configuration for the benchmark job.
        /// </para>
        /// </summary>
        public AIBenchmarkNetworkConfig NetworkConfig
        {
            get { return this._networkConfig; }
            set { this._networkConfig = value; }
        }

        // Check to see if NetworkConfig property is set
        internal bool IsSetNetworkConfig()
        {
            return this._networkConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for the benchmark job, including the Amazon S3 output location
        /// and CloudWatch log information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIBenchmarkOutputResult OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used by the benchmark job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A timestamp that indicates when the benchmark job started running.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the benchmark job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}