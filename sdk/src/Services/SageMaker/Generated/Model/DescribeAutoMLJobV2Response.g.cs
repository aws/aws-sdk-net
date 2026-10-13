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
    /// This is the response object from the DescribeAutoMLJobV2 operation.
    /// </summary>
    public partial class DescribeAutoMLJobV2Response : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutoMLComputeConfig. 
        /// <para>
        /// The compute configuration used for the AutoML job V2.
        /// </para>
        /// </summary>
        public AutoMLComputeConfig AutoMLComputeConfig { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLComputeConfig property is set.
        /// </summary>
        internal bool IsSetAutoMLComputeConfig() => this.AutoMLComputeConfig != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// Returns the Amazon Resource Name (ARN) of the AutoML job V2.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AutoMLJobArn { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobArn property is set.
        /// </summary>
        internal bool IsSetAutoMLJobArn() => this.AutoMLJobArn != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobArtifacts.
        /// </summary>
        public AutoMLJobArtifacts AutoMLJobArtifacts { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobArtifacts property is set.
        /// </summary>
        internal bool IsSetAutoMLJobArtifacts() => this.AutoMLJobArtifacts != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobInputDataConfig. 
        /// <para>
        /// Returns an array of channel objects describing the input data and their location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<AutoMLJobChannel> AutoMLJobInputDataConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<AutoMLJobChannel>() : null;

        /// <summary>
        /// Checks to see if the AutoMLJobInputDataConfig property is set.
        /// </summary>
        internal bool IsSetAutoMLJobInputDataConfig() => this.AutoMLJobInputDataConfig != null && (this.AutoMLJobInputDataConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoMLJobName. 
        /// <para>
        /// Returns the name of the AutoML job V2.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string AutoMLJobName { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobName property is set.
        /// </summary>
        internal bool IsSetAutoMLJobName() => this.AutoMLJobName != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobObjective. 
        /// <para>
        /// Returns the job's objective.
        /// </para>
        /// </summary>
        public AutoMLJobObjective AutoMLJobObjective { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobObjective property is set.
        /// </summary>
        internal bool IsSetAutoMLJobObjective() => this.AutoMLJobObjective != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobSecondaryStatus. 
        /// <para>
        /// Returns the secondary status of the AutoML job V2.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoMLJobSecondaryStatus AutoMLJobSecondaryStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobSecondaryStatus property is set.
        /// </summary>
        internal bool IsSetAutoMLJobSecondaryStatus() => this.AutoMLJobSecondaryStatus != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobStatus. 
        /// <para>
        /// Returns the status of the AutoML job V2.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoMLJobStatus AutoMLJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobStatus property is set.
        /// </summary>
        internal bool IsSetAutoMLJobStatus() => this.AutoMLJobStatus != null;

        /// <summary>
        /// Gets and sets the property AutoMLProblemTypeConfig. 
        /// <para>
        /// Returns the configuration settings of the problem type set for the AutoML job V2.
        /// </para>
        /// </summary>
        public AutoMLProblemTypeConfig AutoMLProblemTypeConfig { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLProblemTypeConfig property is set.
        /// </summary>
        internal bool IsSetAutoMLProblemTypeConfig() => this.AutoMLProblemTypeConfig != null;

        /// <summary>
        /// Gets and sets the property AutoMLProblemTypeConfigName. 
        /// <para>
        /// Returns the name of the problem type configuration set for the AutoML job V2.
        /// </para>
        /// </summary>
        public AutoMLProblemTypeConfigName AutoMLProblemTypeConfigName { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLProblemTypeConfigName property is set.
        /// </summary>
        internal bool IsSetAutoMLProblemTypeConfigName() => this.AutoMLProblemTypeConfigName != null;

        /// <summary>
        /// Gets and sets the property BestCandidate. 
        /// <para>
        /// Information about the candidate produced by an AutoML training job V2, including its
        /// status, steps, and other properties.
        /// </para>
        /// </summary>
        public AutoMLCandidate BestCandidate { get; set; }

        /// <summary>
        /// Checks to see if the BestCandidate property is set.
        /// </summary>
        internal bool IsSetBestCandidate() => this.BestCandidate != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Returns the creation time of the AutoML job V2.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataSplitConfig. 
        /// <para>
        /// Returns the configuration settings of how the data are split into train and validation
        /// datasets.
        /// </para>
        /// </summary>
        public AutoMLDataSplitConfig DataSplitConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataSplitConfig property is set.
        /// </summary>
        internal bool IsSetDataSplitConfig() => this.DataSplitConfig != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Returns the end time of the AutoML job V2.
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
        /// Returns the reason for the failure of the AutoML job V2, when applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Returns the job's last modified time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelDeployConfig. 
        /// <para>
        /// Indicates whether the model was deployed automatically to an endpoint and the name
        /// of that endpoint if deployed automatically.
        /// </para>
        /// </summary>
        public ModelDeployConfig ModelDeployConfig { get; set; }

        /// <summary>
        /// Checks to see if the ModelDeployConfig property is set.
        /// </summary>
        internal bool IsSetModelDeployConfig() => this.ModelDeployConfig != null;

        /// <summary>
        /// Gets and sets the property ModelDeployResult. 
        /// <para>
        /// Provides information about endpoint for the model deployment.
        /// </para>
        /// </summary>
        public ModelDeployResult ModelDeployResult { get; set; }

        /// <summary>
        /// Checks to see if the ModelDeployResult property is set.
        /// </summary>
        internal bool IsSetModelDeployResult() => this.ModelDeployResult != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Returns the job's output data config.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoMLOutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property PartialFailureReasons. 
        /// <para>
        /// Returns a list of reasons for partial failures within an AutoML job V2.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AutoMLPartialFailureReason> PartialFailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<AutoMLPartialFailureReason>() : null;

        /// <summary>
        /// Checks to see if the PartialFailureReasons property is set.
        /// </summary>
        internal bool IsSetPartialFailureReasons() => this.PartialFailureReasons != null && (this.PartialFailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResolvedAttributes. 
        /// <para>
        /// Returns the resolved attributes used by the AutoML job V2.
        /// </para>
        /// </summary>
        public AutoMLResolvedAttributes ResolvedAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedAttributes property is set.
        /// </summary>
        internal bool IsSetResolvedAttributes() => this.ResolvedAttributes != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that has read permission to the input data location and write
        /// permission to the output data location in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// Returns the security configuration for traffic encryption or Amazon VPC settings.
        /// </para>
        /// </summary>
        public AutoMLSecurityConfig SecurityConfig { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfig property is set.
        /// </summary>
        internal bool IsSetSecurityConfig() => this.SecurityConfig != null;
    }
}
