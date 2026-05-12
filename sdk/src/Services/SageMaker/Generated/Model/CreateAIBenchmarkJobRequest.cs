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
    /// Container for the parameters to the CreateAIBenchmarkJob operation.
    /// Creates a benchmark job that runs performance benchmarks against inference infrastructure
    /// using a predefined AI workload configuration. The benchmark job measures metrics such
    /// as latency, throughput, and cost for your generative AI inference endpoints.
    /// </summary>
    public partial class CreateAIBenchmarkJobRequest : AmazonSageMakerRequest
    {
        private string _aiBenchmarkJobName;
        private string _aiWorkloadConfigIdentifier;
        private AIBenchmarkTarget _benchmarkTarget;
        private AIBenchmarkNetworkConfig _networkConfig;
        private AIBenchmarkOutputConfig _outputConfig;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AIBenchmarkJobName. 
        /// <para>
        /// The name of the AI benchmark job. The name must be unique within your Amazon Web Services
        /// account in the current Amazon Web Services Region.
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
        /// Gets and sets the property AIWorkloadConfigIdentifier. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the AI workload configuration to use for
        /// this benchmark job.
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
        /// The target endpoint to benchmark. Specify a SageMaker endpoint by providing its name
        /// or Amazon Resource Name (ARN).
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
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// The network configuration for the benchmark job, including VPC settings.
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
        /// The output configuration for the benchmark job, including the Amazon S3 location where
        /// benchmark results are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIBenchmarkOutputConfig OutputConfig
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
        /// The Amazon Resource Name (ARN) of an IAM role that enables Amazon SageMaker AI to
        /// perform tasks on your behalf.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to Amazon Web Services resources to help you categorize
        /// and organize them. Each tag consists of a key and a value, both of which you define.
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