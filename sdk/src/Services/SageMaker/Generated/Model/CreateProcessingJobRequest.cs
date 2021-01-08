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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProcessingJob operation.
    /// Creates a processing job.
    /// </summary>
    public partial class CreateProcessingJobRequest : AmazonSageMakerRequest
    {
        private AppSpecification _appSpecification;
        private Dictionary<string, string> _environment = new Dictionary<string, string>();
        private ExperimentConfig _experimentConfig;
        private NetworkConfig _networkConfig;
        private List<ProcessingInput> _processingInputs = new List<ProcessingInput>();
        private string _processingJobName;
        private ProcessingOutputConfig _processingOutputConfig;
        private ProcessingResources _processingResources;
        private string _roleArn;
        private ProcessingStoppingCondition _stoppingCondition;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AppSpecification. 
        /// <para>
        /// Configures the processing job to run a specified Docker container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppSpecification AppSpecification
        {
            get { return this._appSpecification; }
            set { this._appSpecification = value; }
        }

        // Check to see if AppSpecification property is set
        internal bool IsSetAppSpecification()
        {
            return this._appSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Sets the environment variables in the Docker container.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && this._environment.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExperimentConfig.
        /// </summary>
        public ExperimentConfig ExperimentConfig
        {
            get { return this._experimentConfig; }
            set { this._experimentConfig = value; }
        }

        // Check to see if ExperimentConfig property is set
        internal bool IsSetExperimentConfig()
        {
            return this._experimentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Networking options for a processing job.
        /// </para>
        /// </summary>
        public NetworkConfig NetworkConfig
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
        /// Gets and sets the property ProcessingInputs. 
        /// <para>
        /// List of input configurations for the processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ProcessingInput> ProcessingInputs
        {
            get { return this._processingInputs; }
            set { this._processingInputs = value; }
        }

        // Check to see if ProcessingInputs property is set
        internal bool IsSetProcessingInputs()
        {
            return this._processingInputs != null && this._processingInputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProcessingJobName. 
        /// <para>
        ///  The name of the processing job. The name must be unique within an AWS Region in the
        /// AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ProcessingJobName
        {
            get { return this._processingJobName; }
            set { this._processingJobName = value; }
        }

        // Check to see if ProcessingJobName property is set
        internal bool IsSetProcessingJobName()
        {
            return this._processingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingOutputConfig. 
        /// <para>
        /// Output configuration for the processing job.
        /// </para>
        /// </summary>
        public ProcessingOutputConfig ProcessingOutputConfig
        {
            get { return this._processingOutputConfig; }
            set { this._processingOutputConfig = value; }
        }

        // Check to see if ProcessingOutputConfig property is set
        internal bool IsSetProcessingOutputConfig()
        {
            return this._processingOutputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingResources. 
        /// <para>
        /// Identifies the resources, ML compute instances, and ML storage volumes to deploy for
        /// a processing job. In distributed training, you specify more than one instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingResources ProcessingResources
        {
            get { return this._processingResources; }
            set { this._processingResources = value; }
        }

        // Check to see if ProcessingResources property is set
        internal bool IsSetProcessingResources()
        {
            return this._processingResources != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to
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
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// The time limit for how long the processing job is allowed to run.
        /// </para>
        /// </summary>
        public ProcessingStoppingCondition StoppingCondition
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// (Optional) An array of key-value pairs. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-whatURL">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}