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
    /// This is the response object from the DescribeOptimizationJob operation.
    /// </summary>
    public partial class DescribeOptimizationJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private OptimizationJobDeploymentInstanceType _deploymentInstanceType;
        private string _failureReason;
        private DateTime? _lastModifiedTime;
        private OptimizationJobModelSource _modelSource;
        private List<OptimizationConfig> _optimizationConfigs = AWSConfigs.InitializeCollections ? new List<OptimizationConfig>() : null;
        private DateTime? _optimizationEndTime;
        private Dictionary<string, string> _optimizationEnvironment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _optimizationJobArn;
        private string _optimizationJobName;
        private OptimizationJobStatus _optimizationJobStatus;
        private OptimizationOutput _optimizationOutput;
        private DateTime? _optimizationStartTime;
        private OptimizationJobOutputConfig _outputConfig;
        private string _roleArn;
        private StoppingCondition _stoppingCondition;
        private OptimizationVpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when you created the optimization job.
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
        /// Gets and sets the property DeploymentInstanceType. 
        /// <para>
        /// The type of instance that hosts the optimized model that you create with the optimization
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptimizationJobDeploymentInstanceType DeploymentInstanceType
        {
            get { return this._deploymentInstanceType; }
            set { this._deploymentInstanceType = value; }
        }

        // Check to see if DeploymentInstanceType property is set
        internal bool IsSetDeploymentInstanceType()
        {
            return this._deploymentInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the optimization job status is <c>FAILED</c>, the reason for the failure.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the optimization job was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelSource. 
        /// <para>
        /// The location of the source model to optimize with an optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptimizationJobModelSource ModelSource
        {
            get { return this._modelSource; }
            set { this._modelSource = value; }
        }

        // Check to see if ModelSource property is set
        internal bool IsSetModelSource()
        {
            return this._modelSource != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationConfigs. 
        /// <para>
        /// Settings for each of the optimization techniques that the job applies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<OptimizationConfig> OptimizationConfigs
        {
            get { return this._optimizationConfigs; }
            set { this._optimizationConfigs = value; }
        }

        // Check to see if OptimizationConfigs property is set
        internal bool IsSetOptimizationConfigs()
        {
            return this._optimizationConfigs != null && (this._optimizationConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OptimizationEndTime. 
        /// <para>
        /// The time when the optimization job finished processing.
        /// </para>
        /// </summary>
        public DateTime? OptimizationEndTime
        {
            get { return this._optimizationEndTime; }
            set { this._optimizationEndTime = value; }
        }

        // Check to see if OptimizationEndTime property is set
        internal bool IsSetOptimizationEndTime()
        {
            return this._optimizationEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptimizationEnvironment. 
        /// <para>
        /// The environment variables to set in the model container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public Dictionary<string, string> OptimizationEnvironment
        {
            get { return this._optimizationEnvironment; }
            set { this._optimizationEnvironment = value; }
        }

        // Check to see if OptimizationEnvironment property is set
        internal bool IsSetOptimizationEnvironment()
        {
            return this._optimizationEnvironment != null && (this._optimizationEnvironment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OptimizationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string OptimizationJobArn
        {
            get { return this._optimizationJobArn; }
            set { this._optimizationJobArn = value; }
        }

        // Check to see if OptimizationJobArn property is set
        internal bool IsSetOptimizationJobArn()
        {
            return this._optimizationJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationJobName. 
        /// <para>
        /// The name that you assigned to the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string OptimizationJobName
        {
            get { return this._optimizationJobName; }
            set { this._optimizationJobName = value; }
        }

        // Check to see if OptimizationJobName property is set
        internal bool IsSetOptimizationJobName()
        {
            return this._optimizationJobName != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationJobStatus. 
        /// <para>
        /// The current status of the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptimizationJobStatus OptimizationJobStatus
        {
            get { return this._optimizationJobStatus; }
            set { this._optimizationJobStatus = value; }
        }

        // Check to see if OptimizationJobStatus property is set
        internal bool IsSetOptimizationJobStatus()
        {
            return this._optimizationJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationOutput. 
        /// <para>
        /// Output values produced by an optimization job.
        /// </para>
        /// </summary>
        public OptimizationOutput OptimizationOutput
        {
            get { return this._optimizationOutput; }
            set { this._optimizationOutput = value; }
        }

        // Check to see if OptimizationOutput property is set
        internal bool IsSetOptimizationOutput()
        {
            return this._optimizationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationStartTime. 
        /// <para>
        /// The time when the optimization job started.
        /// </para>
        /// </summary>
        public DateTime? OptimizationStartTime
        {
            get { return this._optimizationStartTime; }
            set { this._optimizationStartTime = value; }
        }

        // Check to see if OptimizationStartTime property is set
        internal bool IsSetOptimizationStartTime()
        {
            return this._optimizationStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Details for where to store the optimized model that you create with the optimization
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptimizationJobOutputConfig OutputConfig
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
        /// The ARN of the IAM role that you assigned to the optimization job.
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
        /// Gets and sets the property StoppingCondition.
        /// </summary>
        [AWSProperty(Required=true)]
        public StoppingCondition StoppingCondition
        {
            get { return this._stoppingCondition; }
            set { this._stoppingCondition = value; }
        }

        // Check to see if StoppingCondition property is set
        internal bool IsSetStoppingCondition()
        {
            return this._stoppingCondition != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A VPC in Amazon VPC that your optimized model has access to.
        /// </para>
        /// </summary>
        public OptimizationVpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}