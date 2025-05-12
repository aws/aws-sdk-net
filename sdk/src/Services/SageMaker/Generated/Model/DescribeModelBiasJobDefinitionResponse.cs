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
    /// This is the response object from the DescribeModelBiasJobDefinition operation.
    /// </summary>
    public partial class DescribeModelBiasJobDefinitionResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _jobDefinitionArn;
        private string _jobDefinitionName;
        private MonitoringResources _jobResources;
        private ModelBiasAppSpecification _modelBiasAppSpecification;
        private ModelBiasBaselineConfig _modelBiasBaselineConfig;
        private ModelBiasJobInput _modelBiasJobInput;
        private MonitoringOutputConfig _modelBiasJobOutputConfig;
        private MonitoringNetworkConfig _networkConfig;
        private string _roleArn;
        private MonitoringStoppingCondition _stoppingCondition;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the model bias job was created.
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
        /// Gets and sets the property JobDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model bias job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string JobDefinitionArn
        {
            get { return this._jobDefinitionArn; }
            set { this._jobDefinitionArn = value; }
        }

        // Check to see if JobDefinitionArn property is set
        internal bool IsSetJobDefinitionArn()
        {
            return this._jobDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the bias job definition. The name must be unique within an Amazon Web
        /// Services Region in the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string JobDefinitionName
        {
            get { return this._jobDefinitionName; }
            set { this._jobDefinitionName = value; }
        }

        // Check to see if JobDefinitionName property is set
        internal bool IsSetJobDefinitionName()
        {
            return this._jobDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property JobResources.
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringResources JobResources
        {
            get { return this._jobResources; }
            set { this._jobResources = value; }
        }

        // Check to see if JobResources property is set
        internal bool IsSetJobResources()
        {
            return this._jobResources != null;
        }

        /// <summary>
        /// Gets and sets the property ModelBiasAppSpecification. 
        /// <para>
        /// Configures the model bias job to run a specified Docker container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelBiasAppSpecification ModelBiasAppSpecification
        {
            get { return this._modelBiasAppSpecification; }
            set { this._modelBiasAppSpecification = value; }
        }

        // Check to see if ModelBiasAppSpecification property is set
        internal bool IsSetModelBiasAppSpecification()
        {
            return this._modelBiasAppSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ModelBiasBaselineConfig. 
        /// <para>
        /// The baseline configuration for a model bias job.
        /// </para>
        /// </summary>
        public ModelBiasBaselineConfig ModelBiasBaselineConfig
        {
            get { return this._modelBiasBaselineConfig; }
            set { this._modelBiasBaselineConfig = value; }
        }

        // Check to see if ModelBiasBaselineConfig property is set
        internal bool IsSetModelBiasBaselineConfig()
        {
            return this._modelBiasBaselineConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelBiasJobInput. 
        /// <para>
        /// Inputs for the model bias job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelBiasJobInput ModelBiasJobInput
        {
            get { return this._modelBiasJobInput; }
            set { this._modelBiasJobInput = value; }
        }

        // Check to see if ModelBiasJobInput property is set
        internal bool IsSetModelBiasJobInput()
        {
            return this._modelBiasJobInput != null;
        }

        /// <summary>
        /// Gets and sets the property ModelBiasJobOutputConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringOutputConfig ModelBiasJobOutputConfig
        {
            get { return this._modelBiasJobOutputConfig; }
            set { this._modelBiasJobOutputConfig = value; }
        }

        // Check to see if ModelBiasJobOutputConfig property is set
        internal bool IsSetModelBiasJobOutputConfig()
        {
            return this._modelBiasJobOutputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Networking options for a model bias job.
        /// </para>
        /// </summary>
        public MonitoringNetworkConfig NetworkConfig
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that has read permission to the input
        /// data location and write permission to the output data location in Amazon S3.
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
        public MonitoringStoppingCondition StoppingCondition
        {
            get { return this._stoppingCondition; }
            set { this._stoppingCondition = value; }
        }

        // Check to see if StoppingCondition property is set
        internal bool IsSetStoppingCondition()
        {
            return this._stoppingCondition != null;
        }

    }
}